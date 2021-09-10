using ColorModelsConverter.Application.Services.Contracts;
using ColorModelsConverter.Application.Services.Interfaces;
using ColorModelsConverter.Domain;
using MapsterMapper;
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

namespace ColorModelsConverterGui
{
    public partial class Form1 : Form
    {
        private readonly IColorModelsConverterService _colorLaboratoryService;
        private readonly IMapper _mapper;
        private readonly CancellationToken cancellationToken;
        public Form1()
        {
            _colorLaboratoryService = (IColorModelsConverterService)Program.ServiceProvider.GetService(typeof(IColorModelsConverterService));
            _mapper = (IMapper)Program.ServiceProvider.GetService(typeof(IMapper));
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
            var request = new RgbDto() { };
            request.R = byte.Parse(textBoxR.Text);
            request.G = byte.Parse(textBoxG.Text);
            request.B = byte.Parse(textBoxB.Text);

            var response = await _colorLaboratoryService.Rgb2Cmyk(request,cancellationToken);
            textBoxC.Text = response.C.ToString();
            textBoxM.Text = response.M.ToString();
            textBoxY.Text = response.Y.ToString();
            textBoxK.Text = response.K.ToString();
        }
        private async Task Cmyk2RgbAsync()
        {
            var request = new CmykDto() { };
            request.C = double.Parse(textBoxC.Text);
            request.M = double.Parse(textBoxM.Text);
            request.Y = double.Parse(textBoxY.Text);
            request.K = double.Parse(textBoxK.Text);

            var response = await _colorLaboratoryService.Cmyk2Rgb(request, cancellationToken);
            textBoxR.Text = response.R.ToString();
            textBoxG.Text = response.G.ToString();
            textBoxB.Text = response.B.ToString();
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
            SetRGB(128, 0, 128);
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            SetRGB(255, 127, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonPurple.BackColor = Color.FromArgb(128, 0, 128);       // 2. //
            buttonRedPurple.BackColor = Color.FromArgb(199, 21, 133);   // 3. //
            buttonRed.BackColor = Color.FromArgb(255, 0, 0);            // 1. //
            buttonRedOrange.BackColor = Color.FromArgb(255, 63, 0);     // 3.
            buttonOrange.BackColor = Color.FromArgb(255, 128, 0);       // 2. //
            buttonYellowOrange.BackColor = Color.FromArgb(255, 191, 0); // 3.
            buttonYellow.BackColor = Color.FromArgb(255, 255, 0);       // 1. //
            buttonYellowGreen.BackColor = Color.FromArgb(127, 255, 0);  // 3.
            buttonGreen.BackColor = Color.FromArgb(0, 255, 0);          // 2. //
            buttonBlueGreen.BackColor = Color.FromArgb(0, 127, 127);    // 3.
            buttonBlue.BackColor = Color.FromArgb(0, 0, 255);           // 1. //
            buttonBluePurple.BackColor = Color.FromArgb(126, 0, 255);   // 3.
        }

        private void buttonRedOrange_Click(object sender, EventArgs e)
        {
            SetRGB(255, 63, 0);
        }

        private void buttonYellowOrange_Click(object sender, EventArgs e)
        {
            SetRGB(255, 191, 0);
        }

        private void buttonRedPurple_Click(object sender, EventArgs e)
        {
            SetRGB(199, 21, 133);
        }

        private void buttonBluePurple_Click(object sender, EventArgs e)
        {
            SetRGB(126, 0, 255);
        }

        private void buttonBlueGreen_Click(object sender, EventArgs e)
        {
            SetRGB(0, 128, 128);
        }

        private void buttonYellowGreen_Click(object sender, EventArgs e)
        {
            SetRGB(127, 255, 0);
        }
    }
}
