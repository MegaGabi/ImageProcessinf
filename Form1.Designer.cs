namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourceImg = new System.Windows.Forms.PictureBox();
            this.ResultImg = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Identity = new System.Windows.Forms.Button();
            this.Edge1 = new System.Windows.Forms.Button();
            this.Edge2 = new System.Windows.Forms.Button();
            this.Edge3 = new System.Windows.Forms.Button();
            this.Sharpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FactorValue = new System.Windows.Forms.TrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.IterationsCount = new System.Windows.Forms.NumericUpDown();
            this.Warn = new System.Windows.Forms.Label();
            this.Blur = new System.Windows.Forms.Button();
            this.Pooling = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IterationsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceImg
            // 
            this.SourceImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourceImg.Cursor = System.Windows.Forms.Cursors.Default;
            this.SourceImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceImg.Location = new System.Drawing.Point(0, 20);
            this.SourceImg.Name = "SourceImg";
            this.SourceImg.Size = new System.Drawing.Size(328, 468);
            this.SourceImg.TabIndex = 0;
            this.SourceImg.TabStop = false;
            // 
            // ResultImg
            // 
            this.ResultImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultImg.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResultImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultImg.Location = new System.Drawing.Point(0, 20);
            this.ResultImg.Name = "ResultImg";
            this.ResultImg.Size = new System.Drawing.Size(379, 468);
            this.ResultImg.TabIndex = 1;
            this.ResultImg.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(163, 488);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оригинал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат";
            // 
            // Identity
            // 
            this.Identity.Location = new System.Drawing.Point(12, 12);
            this.Identity.Name = "Identity";
            this.Identity.Size = new System.Drawing.Size(117, 23);
            this.Identity.TabIndex = 5;
            this.Identity.Text = "Идентичность";
            this.Identity.UseVisualStyleBackColor = true;
            this.Identity.Click += new System.EventHandler(this.ImageProcessButtons);
            // 
            // Edge1
            // 
            this.Edge1.Location = new System.Drawing.Point(12, 61);
            this.Edge1.Name = "Edge1";
            this.Edge1.Size = new System.Drawing.Size(117, 23);
            this.Edge1.TabIndex = 6;
            this.Edge1.Text = "Первый тип";
            this.Edge1.UseVisualStyleBackColor = true;
            this.Edge1.Click += new System.EventHandler(this.ImageProcessButtons);
            // 
            // Edge2
            // 
            this.Edge2.Location = new System.Drawing.Point(12, 90);
            this.Edge2.Name = "Edge2";
            this.Edge2.Size = new System.Drawing.Size(117, 23);
            this.Edge2.TabIndex = 7;
            this.Edge2.Text = "Второй тип";
            this.Edge2.UseVisualStyleBackColor = true;
            this.Edge2.Click += new System.EventHandler(this.ImageProcessButtons);
            // 
            // Edge3
            // 
            this.Edge3.Location = new System.Drawing.Point(12, 119);
            this.Edge3.Name = "Edge3";
            this.Edge3.Size = new System.Drawing.Size(117, 23);
            this.Edge3.TabIndex = 8;
            this.Edge3.Text = "Третий тип";
            this.Edge3.UseVisualStyleBackColor = true;
            this.Edge3.Click += new System.EventHandler(this.ImageProcessButtons);
            // 
            // Sharpen
            // 
            this.Sharpen.Location = new System.Drawing.Point(12, 164);
            this.Sharpen.Name = "Sharpen";
            this.Sharpen.Size = new System.Drawing.Size(117, 23);
            this.Sharpen.TabIndex = 9;
            this.Sharpen.Text = "Резкость";
            this.Sharpen.UseVisualStyleBackColor = true;
            this.Sharpen.Click += new System.EventHandler(this.ImageProcessButtons);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Углы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Фактор";
            // 
            // FactorValue
            // 
            this.FactorValue.Location = new System.Drawing.Point(0, 304);
            this.FactorValue.Minimum = 1;
            this.FactorValue.Name = "FactorValue";
            this.FactorValue.Size = new System.Drawing.Size(146, 45);
            this.FactorValue.TabIndex = 12;
            this.FactorValue.Value = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(152, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SourceImg);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ResultImg);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(711, 488);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Кол-во итераций";
            // 
            // IterationsCount
            // 
            this.IterationsCount.Location = new System.Drawing.Point(0, 368);
            this.IterationsCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IterationsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IterationsCount.Name = "IterationsCount";
            this.IterationsCount.Size = new System.Drawing.Size(146, 20);
            this.IterationsCount.TabIndex = 15;
            this.IterationsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IterationsCount.ValueChanged += new System.EventHandler(this.IterationsCount_ValueChanged);
            // 
            // Warn
            // 
            this.Warn.AutoSize = true;
            this.Warn.Location = new System.Drawing.Point(9, 390);
            this.Warn.Name = "Warn";
            this.Warn.Size = new System.Drawing.Size(10, 13);
            this.Warn.TabIndex = 16;
            this.Warn.Text = " ";
            // 
            // Blur
            // 
            this.Blur.Location = new System.Drawing.Point(12, 207);
            this.Blur.Name = "Blur";
            this.Blur.Size = new System.Drawing.Size(117, 23);
            this.Blur.TabIndex = 17;
            this.Blur.Text = "Сглаживание";
            this.Blur.UseVisualStyleBackColor = true;
            this.Blur.Click += new System.EventHandler(this.ImageProcessButtons);
            // 
            // Pooling
            // 
            this.Pooling.Location = new System.Drawing.Point(12, 250);
            this.Pooling.Name = "Pooling";
            this.Pooling.Size = new System.Drawing.Size(117, 23);
            this.Pooling.TabIndex = 18;
            this.Pooling.Text = "Пулинг";
            this.Pooling.UseVisualStyleBackColor = true;
            this.Pooling.Click += new System.EventHandler(this.ImageProcessButtons);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Сохранить результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pooling);
            this.Controls.Add(this.Blur);
            this.Controls.Add(this.Warn);
            this.Controls.Add(this.IterationsCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.FactorValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sharpen);
            this.Controls.Add(this.Edge3);
            this.Controls.Add(this.Edge2);
            this.Controls.Add(this.Edge1);
            this.Controls.Add(this.Identity);
            this.Controls.Add(this.splitter1);
            this.MinimumSize = new System.Drawing.Size(879, 527);
            this.Name = "Form1";
            this.Text = "Обработка изображений";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorValue)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IterationsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SourceImg;
        private System.Windows.Forms.PictureBox ResultImg;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Identity;
        private System.Windows.Forms.Button Edge1;
        private System.Windows.Forms.Button Edge2;
        private System.Windows.Forms.Button Edge3;
        private System.Windows.Forms.Button Sharpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar FactorValue;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IterationsCount;
        private System.Windows.Forms.Label Warn;
        private System.Windows.Forms.Button Blur;
        private System.Windows.Forms.Button Pooling;
        private System.Windows.Forms.Button button1;
    }
}

