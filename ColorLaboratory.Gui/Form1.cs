using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorLaboratoryGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonApplyRgb_Click(object sender, EventArgs e)
        {
            ApplyColor();
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {
            if(int.Parse(textBoxR.Text) > 255)
            {
                textBoxR.Text = "255";
            }
        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBoxG.Text) > 255)
            {
                textBoxG.Text = "255";
            }
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBoxB.Text) > 255)
            {
                textBoxB.Text = "255";
            }
        }

        private void SetRGB(int R, int G, int B)
        {
            textBoxR.Text = R.ToString();
            textBoxG.Text = G.ToString();
            textBoxB.Text = B.ToString();
            ApplyColor();
            RGB2CMYK();
        }

        private void ApplyColor()
        {
            int R = int.Parse(textBoxR.Text);
            int G = int.Parse(textBoxG.Text);
            int B = int.Parse(textBoxB.Text);
            panel1.BackColor = Color.FromArgb(R, G, B);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            SetRGB(255, 0, 0);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            SetRGB(255, 255, 0);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            SetRGB(0, 0, 255);
        }

        private void RGB2CMYK()
        {
            // https://www.rapidtables.com/convert/color/rgb-to-cmyk.html

            int R_ = int.Parse(textBoxR.Text);
            int G_ = int.Parse(textBoxG.Text);
            int B_ = int.Parse(textBoxB.Text);

            double R = (double) R_ / 255;
            double G = (double) G_ / 255;
            double B = (double) B_ / 255;

            double K = 1 - (new double[] { R, G, B }.Max());
            if (K < 1)
            {
                double C = (1 - R - K) / (1 - K);
                double M = (1 - G - K) / (1 - K);
                double Y = (1 - B - K) / (1 - K);
                textBoxC.Text = C.ToString();
                textBoxM.Text = M.ToString();
                textBoxY.Text = Y.ToString();
                textBoxK.Text = K.ToString();
            }
            else
            {
                textBoxC.Text = "0";
                textBoxM.Text = "0";
                textBoxY.Text = "0";
                textBoxK.Text = K.ToString();
            }
        }
        private void CMYK2RGB()
        {
            // https://www.rapidtables.com/convert/color/cmyk-to-rgb.html

            double C = 0;
            double M = 0;
            double Y = 0;
            double K = 0;

            if (textBoxC.Text != "")
            {
                C = double.Parse(textBoxC.Text);
            }
            if (textBoxM.Text != "")
            {
                M = double.Parse(textBoxM.Text);
            }
            if (textBoxY.Text != "")
            {
                Y = double.Parse(textBoxY.Text);
            }
            if (textBoxK.Text != "")
            {
                K = double.Parse(textBoxK.Text);
            }

            int R = (int)(255 * (1 - C) * (1 - K));
            int G = (int)(255 * (1 - M) * (1 - K));
            int B = (int)(255 * (1 - Y) * (1 - K));

            textBoxR.Text = R.ToString();
            textBoxG.Text = G.ToString();
            textBoxB.Text = B.ToString();
        }
        private void textBoxY_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxM_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxK_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonRgb2Cmyk_Click(object sender, EventArgs e)
        {
            RGB2CMYK();
            ApplyColor();
        }

        private void buttonCmyk2Rgb_Click(object sender, EventArgs e)
        {
            CMYK2RGB();
            ApplyColor();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            SetRGB(0, 255, 0);
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            SetRGB(255, 0, 255);
        }
    }
}
