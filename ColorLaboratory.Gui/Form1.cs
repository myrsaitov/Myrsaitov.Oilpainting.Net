using ColorLaboratory.Application.Services.Contracts;
using ColorLaboratory.Application.Services.Interfaces;
using ColorLaboratory.Domain;
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

namespace ColorLaboratoryGui
{
    public partial class Form1 : Form
    {
        private readonly IColorLaboratoryService _colorLaboratoryService;
        private readonly CancellationToken cancellationToken;
        public Form1()
        {
            _colorLaboratoryService = (IColorLaboratoryService)Program.ServiceProvider.GetService(typeof(IColorLaboratoryService));
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
            Rgb2CmykAsync();
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

        private async Task Rgb2CmykAsync()
        {
            var request = new Rgb2Cmyk.Request() { rgb = new Rgb() };
            request.rgb.R = byte.Parse(textBoxR.Text);
            request.rgb.G = byte.Parse(textBoxG.Text);
            request.rgb.B = byte.Parse(textBoxB.Text);

            var response = await _colorLaboratoryService.Rgb2Cmyk(request,cancellationToken);
            textBoxC.Text = response.cmyk.C.ToString();
            textBoxM.Text = response.cmyk.M.ToString();
            textBoxY.Text = response.cmyk.Y.ToString();
            textBoxK.Text = response.cmyk.K.ToString();
        }
        private async Task Cmyk2RgbAsync()
        {
            var request = new Cmyk2Rgb.Request() { cmyk = new Cmyk() };
            request.cmyk.C = double.Parse(textBoxC.Text);
            request.cmyk.M = double.Parse(textBoxM.Text);
            request.cmyk.Y = double.Parse(textBoxY.Text);
            request.cmyk.K = double.Parse(textBoxK.Text);

            var response = await _colorLaboratoryService.Cmyk2Rgb(request, cancellationToken);
            textBoxR.Text = response.rgb.R.ToString();
            textBoxG.Text = response.rgb.G.ToString();
            textBoxB.Text = response.rgb.B.ToString();
            /*
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
            */
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
            Rgb2CmykAsync();
            ApplyColor();
        }

        private void buttonCmyk2Rgb_Click(object sender, EventArgs e)
        {
            Cmyk2RgbAsync();
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
