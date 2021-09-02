using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        // The image's original size.
        private int ImageWidth, ImageHeight;

        // The current scale.
        private float ImageScale = 1.0f;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }

            Image image = Image.FromFile(choofdlog.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"..\..\..\PIC\ninethval.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Image = image;

            ImageWidth = pictureBox1.Image.Width;
            ImageHeight = pictureBox1.Image.Height;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Size = new Size(ImageWidth, ImageHeight);
            this.MouseWheel += new MouseEventHandler(pictureBox1_MouseWheel);
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            // The amount by which we adjust scale per wheel click.
            const float scale_per_delta = 0.1f / 120;

            // Update the drawing based upon the mouse wheel scrolling.
            ImageScale += e.Delta * scale_per_delta;
            if (ImageScale < 0) ImageScale = 0;

            // Size the image.
            pictureBox1.Size = new Size(
                (int)(ImageWidth * ImageScale),
                (int)(ImageHeight * ImageScale));

            // Display the new scale.
            pictureBox1.Text = ImageScale.ToString("p0");
        }
    }
}
