using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApplication1.ImageProcessor;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ImageProcessor IP;

        bool mouseClickedSrcImg = false;
        bool mouseClickedResImg = false;
        public Form1()
        {
            InitializeComponent();

            IP = new ImageProcessor();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= splitContainer1.Location.X && x <= splitContainer1.Location.X + splitContainer1.Width 
                &&
                y >= splitContainer1.Location.Y && y <= splitContainer1.Location.Y + splitContainer1.Height)

            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                try
                {
                    Bitmap img = new Bitmap(files[0]);
                    while (img.Width > SourceImg.Width || img.Height > SourceImg.Height)
                        img = new Bitmap(img, img.Width/2, img.Height/2);

                    SourceImg.Image = img;
                }
                catch { }
            }
        }

        private void ImageProcessButtons(object sender, EventArgs e)
        {
            if (SourceImg.Image != null)
            {
                Thread thrd = null;
                int fv = FactorValue.Value;
                int itr = (int)IterationsCount.Value;
                if (Identity == sender)
                {
                    thrd = new Thread(() => ResultImg.Image = IP.ProcessRequest((Bitmap)SourceImg.Image, ProccessorType.identity, itr, fv));
                }
                else if (Edge1 == sender)
                {
                    thrd = new Thread(() => ResultImg.Image = IP.ProcessRequest((Bitmap)SourceImg.Image, ProccessorType.edge1, itr, fv));
                }
                else if (Edge2 == sender)
                {
                    thrd = new Thread(() => ResultImg.Image = IP.ProcessRequest((Bitmap)SourceImg.Image, ProccessorType.edge2, itr, fv));
                }
                else if (Edge3 == sender)
                {
                    thrd = new Thread(() => ResultImg.Image = IP.ProcessRequest((Bitmap)SourceImg.Image, ProccessorType.edge3, itr, fv));
                }
                else if (Sharpen == sender)
                {
                    thrd = new Thread(() => ResultImg.Image = IP.ProcessRequest((Bitmap)SourceImg.Image, ProccessorType.sharpen, itr, fv));
                }
                else if (Blur == sender)
                {
                    thrd = new Thread(() => ResultImg.Image = IP.ProcessRequest((Bitmap)SourceImg.Image, ProccessorType.blur, itr, fv));
                }
                else if (Pooling == sender)
                {
                    thrd = new Thread(() => ResultImg.Image = IP.ProcessRequest((Bitmap)SourceImg.Image, ProccessorType.pooling, itr, fv));
                }
                thrd.Start();
            }
        }

        private void IterationsCount_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as NumericUpDown).Value > 10)
                Warn.Text = "Обработка изображения\n может занять\n много времени!";
            else
                Warn.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ResultImg.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG files (*.png)|*.png";
                sfd.FileName = "FileName";
                
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    ResultImg.Image.Save(sfd.FileName);
                }
            }
        }
    }
}
