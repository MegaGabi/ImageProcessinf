using Accord.Math;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ImageProcessor
    {
        //to another class
        const int x = 3,
                  y = 3;//convolutional

        public enum ProccessorType { identity, edge1, edge2, edge3, sharpen, blur, pooling };

        public Bitmap ProcessRequest(Bitmap toProcess, ProccessorType pt, double iterations = 1, int factor = 1)
        {
            Bitmap f = new Bitmap(toProcess);

            Bitmap l = new Bitmap(f.Width, f.Height);

            DateTime dt = DateTime.Now;

            #region old
            //var bldr = Matrix<double>.Build;
            //Matrix<double> convolutional;

            //if (pt == ProccessorType.identity)
            //{
            //    convolutional = bldr.DenseOfArray(new double[1, y * x]
            //        {
            //        { 0, 0, 0,0, 1, 0,0, 0, 0}
            //        });
            //}
            //else if (pt == ProccessorType.edge1)
            //{
            //    convolutional = bldr.DenseOfArray(new double[1, y * x]
            //        {
            //        { 1, 0, -1,0, 0, 0,-1, 0, 1}
            //        });
            //}
            //else if (pt == ProccessorType.edge2)
            //{
            //    convolutional = bldr.DenseOfArray(new double[1, y * x]
            //        {
            //        { 0, 1, 0,1, -4, 1, 0, 1, 0}
            //        });
            //}
            //else if (pt == ProccessorType.edge3)
            //{
            //    convolutional = bldr.DenseOfArray(new double[1, y * x]
            //        {
            //        { -1, -1, -1,-1, 8, -1,-1, -1, -1}
            //        });
            //}
            //else if (pt == ProccessorType.sharpen)
            //{
            //    convolutional = bldr.DenseOfArray(new double[1, y * x]
            //        {
            //        { 0, -1, 0,-1, 5, -1,0, -1, 0}
            //        });
            //}
            //else if (pt == ProccessorType.blur)
            //{
            //    convolutional = bldr.DenseOfArray(new double[1, y * x]
            //        {
            //        { 0.1, 0.1, 0.1,0.1, 0.1, 0.1,0.1, 0.1, 0.1}
            //        });
            //}
            //else if (pt == ProccessorType.pooling)
            //{
            //    convolutional = bldr.DenseOfArray(new double[1, y * x]
            //        {
            //        { 1, 1, 1,1, 1, 1,1, 1, 1}
            //        });
            //}
            //else
            //{
            //    convolutional = bldr.DenseOfArray(new double[1,y * x]
            //        {
            //        { 0, 0, 0,0, 1, 0,0, 0, 0 }
            //        });
            //}


            //int xf = (int)(x * factor), yf = (int)(y * factor);
            //for (int itr = 0; itr < iterations; itr++)
            //{
            //    var mtrx = BitmapToMatrix(f);
            //    for (int i = 0; i < 3; i++)
            //    {
            //        int rows = mtrx[i].RowCount, cols = mtrx[i].ColumnCount;

            //        mtrx[i] = MatrixToConv(mtrx[i], 3);
            //        mtrx[i] *= convolutional.Transpose();
            //        mtrx[i] = ConvToMatrix(mtrx[i], rows, cols);
            //    }

            //    l = MatrixToBitmap(mtrx);
            //    f = l;
            //}
            #endregion old

            double[,] convolutional = null;

            if (pt == ProccessorType.identity)
            {
                convolutional = new double[1, y * x]
                    {
                        { 0, 0, 0,0, 1, 0,0, 0, 0}
                    };
            }
            else if (pt == ProccessorType.edge1)
            {
                convolutional = new double[1, y * x]
                    {
                        { 1, 0, -1,0, 0, 0,-1, 0, 1}
                    };
            }
            else if (pt == ProccessorType.edge2)
            {
                convolutional = new double[1, y * x]
                    {
                        { 0, 1, 0,1, -4, 1, 0, 1, 0}
                    };
            }
            else if (pt == ProccessorType.edge3)
            {
                convolutional = new double[1, y * x]
                    {
                        { -1, -1, -1,-1, 8, -1,-1, -1, -1}
                    };
            }
            else if (pt == ProccessorType.sharpen)
            {
                convolutional = new double[1, y * x]
                    {
                        { 0, -1, 0,-1, 5, -1,0, -1, 0}
                    };
            }
            else if (pt == ProccessorType.blur)
            {
                convolutional = new double[1, y * x]
                    {
                        { 0.1, 0.1, 0.1,0.1, 0.1, 0.1,0.1, 0.1, 0.1}
                    };
            }
            else if (pt == ProccessorType.pooling)
            {
                int poolsize = 2;
                l = new Bitmap(f.Width / poolsize + 1, f.Height / poolsize + 1);
                for(int i = 0; i < f.Height; i += poolsize)
                {
                    for (int j = 0; j < f.Width; j += poolsize)
                    {
                        l.SetPixel(j / poolsize, i / poolsize, Pool(f, i, j, poolsize, poolsize));
                    }
                }
            }
            else
            {
                convolutional = new double[1, y * x]
                    {
                        { 0, 0, 0,0, 1, 0,0, 0, 0 }
                    };
            }

            if (pt != ProccessorType.pooling)
            {
                for (int i = 0; i < iterations; i++)
                {
                    var BtM = BitmapToMatrix(f);

                    for (int lr = 0; lr < BtM.GetLength(0); lr++)
                    {
                        int rows = BtM[lr].GetLength(0), cols = BtM[lr].GetLength(1);

                        BtM[lr] = MatrixToConv(BtM[lr], x);

                        //MessageBox.Show(BtM[lr].ToString(DefaultMatrixFormatProvider.CurrentCulture));

                        BtM[lr] = BtM[lr].Dot(convolutional.Transpose());

                        //MessageBox.Show(BtM[lr].ToString(DefaultMatrixFormatProvider.CurrentCulture));

                        var buf = ConvToMatrix(BtM[lr], rows, cols);

                        //MessageBox.Show(buf.ToString(DefaultMatrixFormatProvider.CurrentCulture));

                        BtM[lr] = new double[rows, cols];
                        BtM[lr] = buf;
                        //Matrix.Reshape(buf, rows, cols, BtM[lr]);

                        //MessageBox.Show(BtM[lr].ToString(DefaultMatrixFormatProvider.CurrentCulture));
                    }
                    l = MatrixToBitmap(BtM);
                    f = l;
                }
            }

            MessageBox.Show((DateTime.Now - dt).ToString());

            return l;
        }

        static private double[][,] BitmapToMatrix(Bitmap bmp)
        {
            var rgb_src = new double[3][,];
            for (int i = 0; i < rgb_src.GetLength(0); i++)
                rgb_src[i] = new double[bmp.Height, bmp.Width];

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color p = bmp.GetPixel(j, i);

                    rgb_src[0][i, j] = p.R;
                    rgb_src[1][i, j] = p.G;
                    rgb_src[2][i, j] = p.B;
                }
            }

            return rgb_src;
        }

        static private double[,] MatrixToConv(double[,] mtrx, int convsize)
        {
            double[,] toReturn = new double[mtrx.GetLength(0) * mtrx.GetLength(1), convsize * convsize];

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    for (int y = 0; y < convsize; y++)
                    {
                        int StartY = i - (convsize / 2) + y;
                        for (int x = 0; x < convsize; x++)
                        {
                            int StartX = j - (convsize / 2) + x;

                            StartY = StartY < 0 ? 0 : StartY >= mtrx.GetLength(0) ? mtrx.GetLength(0) - 1 : StartY;
                            StartX = StartX < 0 ? 0 : StartX >= mtrx.GetLength(1) ? mtrx.GetLength(1) - 1 : StartX;

                            double val;

                            val = mtrx[StartY, StartX];

                            int ri = i * mtrx.GetLength(1) + j, rj = y * convsize + x;

                            if (ri >= 0 && ri < toReturn.GetLength(0) && rj >= 0 && rj < toReturn.GetLength(1))
                                toReturn[ri, rj] = val;
                        }
                    }
                }
            }

            return toReturn;
        }

        static private Bitmap MatrixToBitmap(double[][,] rgb)
        {
            Bitmap res = new Bitmap(rgb[0].GetLength(1), rgb[0].GetLength(0));

            for (int i = 0; i < res.Height; i++)
            {
                for (int j = 0; j < res.Width; j++)
                {
                    int R = (int)rgb[0][i, j], G = (int)rgb[1][i, j], B = (int)rgb[2][i, j];
                    R = R < 0 ? 0 : R > 255 ? 255 : R;
                    G = G < 0 ? 0 : G > 255 ? 255 : G;
                    B = B < 0 ? 0 : B > 255 ? 255 : B;
                    Color p = Color.FromArgb(R, G, B);

                    res.SetPixel(j, i, p);
                }
            }

            return res;
        }

        private double[,] ConvToMatrix(double[,] matrix, int rows, int cols)
        {
            double[,] toReturn = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    toReturn[i, j] = matrix[i * cols + j, 0];
                }
            }

            return toReturn;
        }

        //private Matrix<double> ConvToMatrix(Matrix<double> matrix, int rows, int cols)
        //{
        //    Matrix<double> toReturn = (Matrix<double>.Build).Dense(rows, cols);

        //    for(int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //           toReturn[i,j] = matrix[i*cols + j,0];
        //        }
        //    }

        //    return toReturn;
        //}

        //static private Matrix<double> MatrixToConv(Matrix<double> toConv, int convsize)
        //{
        //    Matrix<double> toReturn = (Matrix<double>.Build).Dense(toConv.ColumnCount * toConv.RowCount,
        //                                                           convsize * convsize);

        //    for(int i = 0; i < toConv.RowCount; i++)
        //    {
        //        for (int j = 0; j < toConv.ColumnCount; j++)
        //        {
        //            for (int y = 0; y < convsize; y++)
        //            {
        //                int StartY = i - (convsize/2) + y;
        //                for (int x = 0; x < convsize; x++)
        //                {
        //                    int StartX = j - (convsize / 2) + x;

        //                    double val;

        //                    if(StartY < 0 || StartY >= toConv.RowCount || StartX < 0 || StartX >= toConv.ColumnCount)
        //                    {
        //                        val = 0;
        //                    }
        //                    else 
        //                        val = toConv[StartY, StartX];

        //                    int ri = i * toConv.ColumnCount + j, rj = y * convsize + x;

        //                    if (ri >= 0 && ri < toReturn.RowCount && rj >= 0 && rj < toReturn.ColumnCount)
        //                        toReturn[ri, rj] = val;
        //                }
        //            }
        //        }
        //    }

        //    return toReturn;
        //}

        //static private Matrix<double>[] BitmapToMatrix(Bitmap bmp)
        //{
        //    MatrixBuilder<double> bldr = Matrix<double>.Build;
        //    Matrix<double>[] rgb = new Matrix<double>[3];
        //    var rgb_src = new double[3][,];
        //    for (int i = 0; i < rgb_src.GetLength(0); i++)
        //        rgb_src[i] = new double[bmp.Height, bmp.Width];

        //    for (int i = 0; i < bmp.Height; i++)
        //    {
        //        for (int j = 0; j < bmp.Width; j++)
        //        {
        //            Color p = bmp.GetPixel(j, i);

        //            rgb_src[0][i, j] = p.R;
        //            rgb_src[1][i, j] = p.G;
        //            rgb_src[2][i, j] = p.B;
        //        }
        //    }

        //    for (int i = 0; i < 3; i++)
        //    {
        //        rgb[i] = bldr.DenseOfArray(rgb_src[i]);
        //    }

        //    return rgb;
        //}

        //static private Bitmap MatrixToBitmap(Matrix<double>[] rgb)
        //{
        //    Bitmap res = new Bitmap(rgb[0].ColumnCount, rgb[0].RowCount);

        //    for(int i = 0; i < res.Height; i++)
        //    {
        //        for (int j = 0; j < res.Width; j++)
        //        {
        //            int R = (int)rgb[0][i, j], G = (int)rgb[1][i, j], B = (int)rgb[2][i, j];
        //            R = R < 0 ? 0 : R > 255 ? 255 : R;
        //            G = G < 0 ? 0 : G > 255 ? 255 : G;
        //            B = B < 0 ? 0 : B > 255 ? 255 : B;
        //            Color p = Color.FromArgb(R, G, B);

        //            res.SetPixel(j, i, p);
        //        }
        //    }

        //    return res;
        //}

        private Color Pool(Bitmap f, int i, int j, int px, int py)
        {
            Color maxPixel = Color.FromArgb(0,0,0);
            int fR = 0, fG = 0, fB = 0;

            for (int z = i, cz = 0; cz < py; z++, cz++)
            {
                for (int c = j, cc = 0; cc < px; c++, cc++)
                {
                    if (z < f.Height && c < f.Width)
                    {
                        Color pixel = f.GetPixel(c, z);

                        fR += pixel.R;
                        fG += pixel.G;
                        fB += pixel.B;
                    }
                }
            }

            int size = px * py;
            maxPixel = Color.FromArgb(fR/size, fG/size, fB/size);

            return maxPixel;
        }

        private  Color BlurColors(Bitmap f, double[,] convolutional, int i, int j, int factor)
        {
            int lR = 0, lB = 0, lG = 0; //Red after

            for (int z = i - (y / 2), cz = 0; cz < y; z++, cz++)
            {
                for (int c = j - (x / 2), cc = 0; cc < x; c++, cc++)
                {
                    if ((c >= 0 && c < f.Height) && (z >= 0 && z < f.Width))
                    {
                        Color pixel = f.GetPixel(z, c);

                        double fR = pixel.R * convolutional[cz, cc];
                        lR += (int)fR;

                        double fB = pixel.B * convolutional[cz, cc];
                        lB += (int)fB;

                        double fG = pixel.G * convolutional[cz, cc];
                        lG += (int)fG;
                    }
                }
            }
            lR *= (int)factor;
            lB *= (int)factor;
            lG *= (int)factor;

            lR = (lR < 0 ? 0 : (lR > 255 ? 255 : lR));
            lB = (lB < 0 ? 0 : (lB > 255 ? 255 : lB));
            lG = (lG < 0 ? 0 : (lG > 255 ? 255 : lG));

            return Color.FromArgb(lR, lG, lB);
        }
    }
}
