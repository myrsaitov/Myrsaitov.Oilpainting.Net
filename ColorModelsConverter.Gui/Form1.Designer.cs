
namespace ColorModelsConverterGui
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
            this.buttonApplyRgb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonPurple = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRgb2Cmyk = new System.Windows.Forms.Button();
            this.buttonCmyk2Rgb = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonRedOrange = new System.Windows.Forms.Button();
            this.buttonYellowOrange = new System.Windows.Forms.Button();
            this.buttonYellowGreen = new System.Windows.Forms.Button();
            this.buttonBlueGreen = new System.Windows.Forms.Button();
            this.buttonBluePurple = new System.Windows.Forms.Button();
            this.buttonRedPurple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonApplyRgb
            // 
            this.buttonApplyRgb.Location = new System.Drawing.Point(68, 212);
            this.buttonApplyRgb.Name = "buttonApplyRgb";
            this.buttonApplyRgb.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyRgb.TabIndex = 0;
            this.buttonApplyRgb.Text = "Apply RGB";
            this.buttonApplyRgb.UseVisualStyleBackColor = true;
            this.buttonApplyRgb.Click += new System.EventHandler(this.buttonApplyRgb_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(47, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 118);
            this.panel1.TabIndex = 1;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(68, 84);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(31, 20);
            this.textBoxR.TabIndex = 2;
            this.textBoxR.Text = "255";
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxR_TextChanged);
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(68, 121);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(31, 20);
            this.textBoxG.TabIndex = 3;
            this.textBoxG.Text = "255";
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxG_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(68, 158);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(31, 20);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.Text = "255";
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "1. Первичные цвета";
            // 
            // buttonRed
            // 
            this.buttonRed.Location = new System.Drawing.Point(538, 230);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(55, 55);
            this.buttonRed.TabIndex = 9;
            this.buttonRed.Text = "1.";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.Location = new System.Drawing.Point(773, 230);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(55, 55);
            this.buttonYellow.TabIndex = 10;
            this.buttonYellow.Text = "1.";
            this.buttonYellow.UseVisualStyleBackColor = true;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.Location = new System.Drawing.Point(654, 404);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(55, 55);
            this.buttonBlue.TabIndex = 11;
            this.buttonBlue.Text = "1.";
            this.buttonBlue.UseVisualStyleBackColor = true;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonPurple
            // 
            this.buttonPurple.Location = new System.Drawing.Point(538, 338);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(55, 55);
            this.buttonPurple.TabIndex = 15;
            this.buttonPurple.Text = "2.";
            this.buttonPurple.UseVisualStyleBackColor = true;
            this.buttonPurple.Click += new System.EventHandler(this.buttonPurple_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.Location = new System.Drawing.Point(773, 338);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(55, 55);
            this.buttonGreen.TabIndex = 14;
            this.buttonGreen.Text = "2.";
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.Location = new System.Drawing.Point(654, 164);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(55, 55);
            this.buttonOrange.TabIndex = 13;
            this.buttonOrange.Text = "2.";
            this.buttonOrange.UseVisualStyleBackColor = true;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "2. Вторичные цвета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Yellow";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Magenta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cyan";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(243, 84);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 18;
            this.textBoxC.Text = "0";
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(243, 121);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(100, 20);
            this.textBoxM.TabIndex = 17;
            this.textBoxM.Text = "0";
            this.textBoxM.TextChanged += new System.EventHandler(this.textBoxM_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(243, 158);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 16;
            this.textBoxY.Text = "0";
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxY_TextChanged);
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(243, 203);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(100, 20);
            this.textBoxK.TabIndex = 22;
            this.textBoxK.Text = "0";
            this.textBoxK.TextChanged += new System.EventHandler(this.textBoxK_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Key";
            // 
            // buttonRgb2Cmyk
            // 
            this.buttonRgb2Cmyk.Location = new System.Drawing.Point(24, 12);
            this.buttonRgb2Cmyk.Name = "buttonRgb2Cmyk";
            this.buttonRgb2Cmyk.Size = new System.Drawing.Size(173, 23);
            this.buttonRgb2Cmyk.TabIndex = 24;
            this.buttonRgb2Cmyk.Text = "(RGB => CMYK) + Apply RGB";
            this.buttonRgb2Cmyk.UseVisualStyleBackColor = true;
            this.buttonRgb2Cmyk.Click += new System.EventHandler(this.buttonRgb2Cmyk_Click);
            // 
            // buttonCmyk2Rgb
            // 
            this.buttonCmyk2Rgb.Location = new System.Drawing.Point(242, 12);
            this.buttonCmyk2Rgb.Name = "buttonCmyk2Rgb";
            this.buttonCmyk2Rgb.Size = new System.Drawing.Size(161, 23);
            this.buttonCmyk2Rgb.TabIndex = 25;
            this.buttonCmyk2Rgb.Text = "(RGB <= CMYK) + Apply RGB";
            this.buttonCmyk2Rgb.UseVisualStyleBackColor = true;
            this.buttonCmyk2Rgb.Click += new System.EventHandler(this.buttonCmyk2Rgb_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "(byte) 0...255";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "(double) 0...1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(552, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "3. Третичные цвета";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(521, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Круг Иттена:";
            // 
            // buttonRedOrange
            // 
            this.buttonRedOrange.Location = new System.Drawing.Point(576, 158);
            this.buttonRedOrange.Name = "buttonRedOrange";
            this.buttonRedOrange.Size = new System.Drawing.Size(55, 55);
            this.buttonRedOrange.TabIndex = 30;
            this.buttonRedOrange.Text = "3.";
            this.buttonRedOrange.UseVisualStyleBackColor = true;
            this.buttonRedOrange.Click += new System.EventHandler(this.buttonRedOrange_Click);
            // 
            // buttonYellowOrange
            // 
            this.buttonYellowOrange.Location = new System.Drawing.Point(740, 158);
            this.buttonYellowOrange.Name = "buttonYellowOrange";
            this.buttonYellowOrange.Size = new System.Drawing.Size(55, 55);
            this.buttonYellowOrange.TabIndex = 31;
            this.buttonYellowOrange.Text = "3.";
            this.buttonYellowOrange.UseVisualStyleBackColor = true;
            this.buttonYellowOrange.Click += new System.EventHandler(this.buttonYellowOrange_Click);
            // 
            // buttonYellowGreen
            // 
            this.buttonYellowGreen.Location = new System.Drawing.Point(851, 288);
            this.buttonYellowGreen.Name = "buttonYellowGreen";
            this.buttonYellowGreen.Size = new System.Drawing.Size(55, 55);
            this.buttonYellowGreen.TabIndex = 32;
            this.buttonYellowGreen.Text = "3.";
            this.buttonYellowGreen.UseVisualStyleBackColor = true;
            this.buttonYellowGreen.Click += new System.EventHandler(this.buttonYellowGreen_Click);
            // 
            // buttonBlueGreen
            // 
            this.buttonBlueGreen.Location = new System.Drawing.Point(740, 404);
            this.buttonBlueGreen.Name = "buttonBlueGreen";
            this.buttonBlueGreen.Size = new System.Drawing.Size(55, 55);
            this.buttonBlueGreen.TabIndex = 33;
            this.buttonBlueGreen.Text = "3.";
            this.buttonBlueGreen.UseVisualStyleBackColor = true;
            this.buttonBlueGreen.Click += new System.EventHandler(this.buttonBlueGreen_Click);
            // 
            // buttonBluePurple
            // 
            this.buttonBluePurple.Location = new System.Drawing.Point(567, 404);
            this.buttonBluePurple.Name = "buttonBluePurple";
            this.buttonBluePurple.Size = new System.Drawing.Size(55, 55);
            this.buttonBluePurple.TabIndex = 34;
            this.buttonBluePurple.Text = "3.";
            this.buttonBluePurple.UseVisualStyleBackColor = true;
            this.buttonBluePurple.Click += new System.EventHandler(this.buttonBluePurple_Click);
            // 
            // buttonRedPurple
            // 
            this.buttonRedPurple.Location = new System.Drawing.Point(465, 279);
            this.buttonRedPurple.Name = "buttonRedPurple";
            this.buttonRedPurple.Size = new System.Drawing.Size(55, 55);
            this.buttonRedPurple.TabIndex = 35;
            this.buttonRedPurple.Text = "3.";
            this.buttonRedPurple.UseVisualStyleBackColor = true;
            this.buttonRedPurple.Click += new System.EventHandler(this.buttonRedPurple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 564);
            this.Controls.Add(this.buttonRedPurple);
            this.Controls.Add(this.buttonBluePurple);
            this.Controls.Add(this.buttonBlueGreen);
            this.Controls.Add(this.buttonYellowGreen);
            this.Controls.Add(this.buttonYellowOrange);
            this.Controls.Add(this.buttonRedOrange);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonCmyk2Rgb);
            this.Controls.Add(this.buttonRgb2Cmyk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.buttonPurple);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonOrange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonApplyRgb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApplyRgb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonPurple;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRgb2Cmyk;
        private System.Windows.Forms.Button buttonCmyk2Rgb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonRedOrange;
        private System.Windows.Forms.Button buttonYellowOrange;
        private System.Windows.Forms.Button buttonYellowGreen;
        private System.Windows.Forms.Button buttonBlueGreen;
        private System.Windows.Forms.Button buttonBluePurple;
        private System.Windows.Forms.Button buttonRedPurple;
    }
}

