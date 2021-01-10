using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_4
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Bitmap originalBitmap;
        private object lockObject = new object();
        private bool isRunning = false;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Файлы изображений| *.bmp; *.png;* .jpg; |Все файлы|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.bitmap = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
            this.originalBitmap = bitmap;
            this.saveFileDialog1.FileName = openFileDialog1.FileName;
            this.pictureBox1.Image = bitmap;
        }

        private void buttonRotatorLeft_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }
            
            bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = bitmap;
        }

        private void buttonRotatorRight_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }

            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = bitmap;
        }

        private void buttonReflectHorizontal_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }

            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bitmap;
        }

        private void buttonReflectVertical_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }

            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = bitmap;
        }

        private async void buttonEnlarge_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }

            var run = false;
            if (!isRunning)
            {
                lock (lockObject)
                {
                    if (!isRunning)
                    {
                        isRunning = true;
                        run = true;
                    }
                }
            }

            if (run)
            {
                await Task.Run(() =>
                {
                    try
                    {

                        var size = new Size(bitmap.Size.Width * 3 / 2, bitmap.Size.Height * 3 / 2);
                        bitmap = new Bitmap(this.originalBitmap, size);
                        pictureBox1.Image = bitmap;

                    }
                    catch (Exception exception)
                    {
                        throw new ArgumentException(exception.Message);
                    }
                });

                lock (lockObject)
                {
                    isRunning = false;
                }
            }
        }

        private async void buttonReduce_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }

            var run = false;
            if (!isRunning)
            {
                lock (lockObject)
                {
                    if (!isRunning)
                    {
                        isRunning = true;
                        run = true;
                    }
                }
            }

            if (run)
            {
                await Task.Run(() =>
                {
                    try
                    {
                        var size = new Size(bitmap.Size.Width / 3 * 2, bitmap.Size.Height / 3 * 2);
                        bitmap = new Bitmap(this.originalBitmap, size);
                        pictureBox1.Image = bitmap;
                    }
                    catch (Exception exception)
                    {
                        throw new ArgumentException(exception.Message);
                    }
                });

                lock (lockObject)
                {
                    isRunning = false;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }

            var bitmapSave = bitmap;
            bitmapSave.Save(saveFileDialog1.FileName);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }

            saveFileDialog1.Filter = "Файлы изображений| *.bmp; *.png;* .jpg; |Все файлы|*.*";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            bitmap.Save(saveFileDialog1.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.ValueOfBrightness.Text = this.trackBar1.Value.ToString();
            if (bitmap == null || isRunning)
            {
                return;
            }

            var tempBitmap = this.bitmap;
            var final = this.trackBar1.Value / 255.0f;
            var newBitmap = new Bitmap(tempBitmap.Width, tempBitmap.Height);
            
            var cm = new ColorMatrix(new float[][]
            {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {final, final, final, 1, 1},
            });
            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            Point[] points =
            {
                new Point(0, 0),
                new Point(tempBitmap.Width, 0),
                new Point(0, tempBitmap.Height),
            };
            var rect = new Rectangle(0, 0, tempBitmap.Width, tempBitmap.Height);

            using (var gr = Graphics.FromImage(newBitmap))
            {
                gr.DrawImage(this.bitmap, points, rect,
                    GraphicsUnit.Pixel, attributes);
            }

            this.pictureBox1.Image = newBitmap;
        }

        private void relief_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }

            for (int i = 0; i < this.bitmap.Width; i++)
            {
                for (int j = 0; j < this.bitmap.Height; j++)
                {
                    var c = this.bitmap.GetPixel(i, j);
                    Color newColor;

                    if ((i == this.bitmap.Width - 1))
                    {
                        newColor = Color.FromArgb(0, 0, 0);
                    }
                    else
                    {
                        var next = this.bitmap.GetPixel(i + 1, j);
                        var y1 = (byte)(0.11 * c.R + 0.598 * c.G + 0.3 * c.B);
                        var y2 = (byte)(0.11 * next.R + 0.598 * next.G + 0.3 * next.B);
                        var d = (byte)((y1 - y2 + 255) / 2);
                        newColor = Color.FromArgb(d, d, d);
                    }

                    this.bitmap.SetPixel(i, j, newColor);
                }
            }

            pictureBox1.Image = this.bitmap;
        }

        private void outline_Click(object sender, EventArgs e)
        {
            if (bitmap == null || isRunning)
            {
                return;
            }

            var pixel = new int[this.bitmap.Height, this.bitmap.Width];
            for (int y = 0; y < this.bitmap.Height; y++)
                for (int x = 0; x < this.bitmap.Width; x++)
                    pixel[y, x] = (int)(this.bitmap.GetPixel(x, y).ToArgb());

            var tempBitmap = this.bitmap;
            pixel = Filter.Matrix_filtration(tempBitmap.Width, tempBitmap.Height, pixel, Filter.N1, Filter.countur);
            
            for (int y = 0; y < tempBitmap.Height; y++)
                for (int x = 0; x < tempBitmap.Width; x++)
                    tempBitmap.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));

            this.pictureBox1.Image = tempBitmap;
        }

        class RGB
        {
            public float R;
            public float G;
            public float B;
        }

        static class Filter
        {
            public static int[,] Matrix_filtration(int W, int H, int[,] pixel, int N, double[,] matryx)
            {
                int i, j, k, m;
                var gap = (int)(N / 2);
                var tmpH = H + 2 * gap;
                var tmpW = W + 2 * gap;
                var tmppixel = new int[tmpH, tmpW];
                var newpixel = new int[H, W];
                
                for (i = 0; i < gap; i++)
                    for (j = 0; j < gap; j++)
                    {
                        tmppixel[i, j] = pixel[0, 0];
                        tmppixel[i, tmpW - 1 - j] = pixel[0, W - 1];
                        tmppixel[tmpH - 1 - i, j] = pixel[H - 1, 0];
                        tmppixel[tmpH - 1 - i, tmpW - 1 - j] = pixel[H - 1, W - 1];
                    }
               
                for (i = gap; i < tmpH - gap; i++)
                    for (j = 0; j < gap; j++)
                    {
                        tmppixel[i, j] = pixel[i - gap, j];
                        tmppixel[i, tmpW - 1 - j] = pixel[i - gap, W - 1 - j];
                    }
                
                for (i = 0; i < gap; i++)
                    for (j = gap; j < tmpW - gap; j++)
                    {
                        tmppixel[i, j] = pixel[i, j - gap];
                        tmppixel[tmpH - 1 - i, j] = pixel[H - 1 - i, j - gap];
                    }
                
                for (i = 0; i < H; i++)
                    for (j = 0; j < W; j++)
                        tmppixel[i + gap, j + gap] = pixel[i, j];
                
                var сolorOfPixel = new RGB();
                for (i = gap; i < tmpH - gap; i++)
                    for (j = gap; j < tmpW - gap; j++)
                    {
                        сolorOfPixel.R = 0;
                        сolorOfPixel.G = 0;
                        сolorOfPixel.B = 0;
                        for (k = 0; k < N; k++)
                            for (m = 0; m < N; m++)
                            {
                                var ColorOfCell = calculationOfColor(tmppixel[i - gap + k, j - gap + m], matryx[k, m]);
                                сolorOfPixel.R += ColorOfCell.R;
                                сolorOfPixel.G += ColorOfCell.G;
                                сolorOfPixel.B += ColorOfCell.B;
                            }
                        
                        if (сolorOfPixel.R < 0) сolorOfPixel.R = 0;
                        if (сolorOfPixel.R > 255) сolorOfPixel.R = 255;
                        if (сolorOfPixel.G < 0) сolorOfPixel.G = 0;
                        if (сolorOfPixel.G > 255) сolorOfPixel.G = 255;
                        if (сolorOfPixel.B < 0) сolorOfPixel.B = 0;
                        if (сolorOfPixel.B > 255) сolorOfPixel.B = 255;

                        newpixel[i - gap, j - gap] = build(сolorOfPixel);
                    }

                return newpixel;
            }

            
            public static RGB calculationOfColor(int pixel, double coefficient)
            {
                var сolor = new RGB();
                сolor.R = (float)(coefficient * ((pixel & 0x00FF0000) >> 16));
                сolor.G = (float)(coefficient * ((pixel & 0x0000FF00) >> 8));
                сolor.B = (float)(coefficient * (pixel & 0x000000FF));
                return сolor;
            }

            
            public static int build(RGB ColorOfPixel)
            {
                var color = 0xFF000000 | ((UInt32)ColorOfPixel.R << 16) | ((UInt32)ColorOfPixel.G << 8) | ((UInt32)ColorOfPixel.B);
                return (int)color;
            }

            public const int N1 = 3;
            public static int Coeff = 3;
            public static double[,] countur = new double[N1, N1] {{-1 * Coeff, -1 * Coeff, -1 * Coeff},
            {-1 * Coeff, 8 * Coeff, -1 * Coeff},
            {-1 * Coeff, -1 * Coeff, -1 * Coeff }};
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.trackBar1.Value = 0;
            this.bitmap = this.originalBitmap;
            this.pictureBox1.Image = this.bitmap;
        }
    }
}
