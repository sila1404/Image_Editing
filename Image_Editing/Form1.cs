using System.Windows.Forms;

namespace Image_Editing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap pic_O, pic_C;

        // Convert to Gray 1 Function
        private Bitmap ConvertToGray1(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        // Convert to Gray 2 Function
        private Bitmap ConvertToGray2(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int nP = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(nP, nP, nP));
                }
            }
            return bmp;
        }

        // Black and White Function
        private Bitmap BlackAndWhite(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(txt_thread.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg > t)
                    {
                        avg = 255;
                    }
                    else
                    {
                        avg = 0;
                    }
                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        // Invert Function
        private Bitmap Invert(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg == 255)
                    {
                        avg = 0;
                    }
                    else if (avg == 0)
                    {
                        avg = 255;
                    }
                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        // Negative Function
        private Bitmap Negative(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int r1, g1, b1;
                    r1 = 255 - (int)(c.R);
                    g1 = 255 - (int)(c.G);
                    b1 = 255 - (int)(c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return bmp;
        }

        // Log Transform Function
        private Bitmap LogTransform(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int cVal = int.Parse(txt_c_1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int r1, g1, b1;
                    r1 = (int)(cVal * Math.Log(1 + c.R));
                    g1 = (int)(cVal * Math.Log(1 + c.G));
                    b1 = (int)(cVal * Math.Log(1 + c.B));

                    bmp.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }

            return bmp;
        }

        // Power Law Function
        private Bitmap PowerLaw(Bitmap source, float alpha)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            float cVal = float.Parse(txt_c_2.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    float r1, g1, b1;
                    r1 = (float)(cVal * Math.Pow((c.R), alpha));
                    g1 = (float)(cVal * Math.Pow((c.G), alpha));
                    b1 = (float)(cVal * Math.Pow((c.B), alpha));

                    // Ensure the values are within the valid color range (0-255)
                    r1 = Math.Max(0, Math.Min(255, r1));
                    g1 = Math.Max(0, Math.Min(255, g1));
                    b1 = Math.Max(0, Math.Min(255, b1));

                    bmp.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }

            return bmp;
        }

        // Open Picture Button
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_O = new Bitmap(opf.FileName);
                pictureBox1.Image = pic_O;
            }
        }

        // Convert to Gray 1 Button
        private void btn_gray_1_Click(object sender, EventArgs e)
        {
            pic_C = ConvertToGray1(pic_O);
            pictureBox1.Image = pic_C;
        }

        // Convert to Gray 2 Button
        private void btn_gray_2_Click(object sender, EventArgs e)
        {
            pic_C = ConvertToGray2(pic_O);
            pictureBox1.Image = pic_C;
        }

        // Origin Button
        private void btn_origin_Click(object sender, EventArgs e)
        {
            pic_C = pic_O;
            pictureBox1.Image = pic_C;
        }

        // Black and White Button
        private void btn_b_w_Click(object sender, EventArgs e)
        {
            pic_C = BlackAndWhite(pic_O);
            pictureBox1.Image = pic_C;
        }

        // Negative Button
        private void btn_negative_Click(object sender, EventArgs e)
        {
            pic_C = Negative(pic_O);
            pictureBox1.Image = pic_C;
        }

        // Invert Button
        private void btn_invert_Click(object sender, EventArgs e)
        {
            pic_C = Invert(pic_O);
            pictureBox1.Image = pic_C;
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            pic_C = LogTransform(pic_O);
            pictureBox1.Image = pic_C;
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            float alpha = float.Parse(txt_alpha.Text);

            pic_C = PowerLaw(pic_O, alpha);
            pictureBox1.Image = pic_C;
        }
    }
}