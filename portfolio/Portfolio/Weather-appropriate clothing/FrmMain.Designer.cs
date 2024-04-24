namespace Weather_appropriate_clothing
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            weatherGroupBox = new GroupBox();
            RdoWinter = new RadioButton();
            RdoSummer = new RadioButton();
            outfitGroupBox = new GroupBox();
            PicSummerImg = new PictureBox();
            groupBox4 = new GroupBox();
            TxtDcpSummer = new TextBox();
            groupBox5 = new GroupBox();
            PicWinterImg = new PictureBox();
            groupBox6 = new GroupBox();
            TxtDcpWinter = new TextBox();
            weatherGroupBox.SuspendLayout();
            outfitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicSummerImg).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicWinterImg).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Font = new Font("나눔고딕코딩", 15F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 41);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "날씨별 옷차림";
            // 
            // weatherGroupBox
            // 
            weatherGroupBox.Controls.Add(RdoWinter);
            weatherGroupBox.Controls.Add(RdoSummer);
            weatherGroupBox.Location = new Point(12, 58);
            weatherGroupBox.Name = "weatherGroupBox";
            weatherGroupBox.Size = new Size(133, 512);
            weatherGroupBox.TabIndex = 1;
            weatherGroupBox.TabStop = false;
            weatherGroupBox.Text = "날씨";
            // 
            // RdoWinter
            // 
            RdoWinter.AutoSize = true;
            RdoWinter.Location = new Point(39, 325);
            RdoWinter.Name = "RdoWinter";
            RdoWinter.Size = new Size(49, 19);
            RdoWinter.TabIndex = 1;
            RdoWinter.TabStop = true;
            RdoWinter.Text = "겨울";
            RdoWinter.UseVisualStyleBackColor = true;
            // 
            // RdoSummer
            // 
            RdoSummer.AutoSize = true;
            RdoSummer.Location = new Point(39, 62);
            RdoSummer.Name = "RdoSummer";
            RdoSummer.Size = new Size(49, 19);
            RdoSummer.TabIndex = 0;
            RdoSummer.TabStop = true;
            RdoSummer.Text = "여름";
            RdoSummer.UseVisualStyleBackColor = true;
            RdoSummer.CheckedChanged += RdoSummer_CheckedChanged;
            // 
            // outfitGroupBox
            // 
            outfitGroupBox.Controls.Add(PicSummerImg);
            outfitGroupBox.Location = new Point(151, 58);
            outfitGroupBox.Name = "outfitGroupBox";
            outfitGroupBox.Size = new Size(256, 184);
            outfitGroupBox.TabIndex = 2;
            outfitGroupBox.TabStop = false;
            outfitGroupBox.Text = "옷차림";
            // 
            // PicSummerImg
            // 
            PicSummerImg.BackColor = Color.LightYellow;
            PicSummerImg.Location = new Point(6, 15);
            PicSummerImg.Name = "PicSummerImg";
            PicSummerImg.Size = new Size(244, 163);
            PicSummerImg.TabIndex = 0;
            PicSummerImg.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TxtDcpSummer);
            groupBox4.Location = new Point(157, 248);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(196, 60);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "옷 종류";
            // 
            // TxtDcpSummer
            // 
            TxtDcpSummer.Location = new Point(6, 22);
            TxtDcpSummer.Name = "TxtDcpSummer";
            TxtDcpSummer.Size = new Size(184, 23);
            TxtDcpSummer.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(PicWinterImg);
            groupBox5.Location = new Point(151, 321);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(256, 184);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "옷차림";
            // 
            // PicWinterImg
            // 
            PicWinterImg.BackColor = Color.LightYellow;
            PicWinterImg.Location = new Point(6, 15);
            PicWinterImg.Name = "PicWinterImg";
            PicWinterImg.Size = new Size(244, 163);
            PicWinterImg.TabIndex = 0;
            PicWinterImg.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(TxtDcpWinter);
            groupBox6.Location = new Point(157, 511);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(196, 59);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "옷 종류";
            // 
            // TxtDcpWinter
            // 
            TxtDcpWinter.Location = new Point(6, 22);
            TxtDcpWinter.Name = "TxtDcpWinter";
            TxtDcpWinter.Size = new Size(184, 23);
            TxtDcpWinter.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 667);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(outfitGroupBox);
            Controls.Add(weatherGroupBox);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            Text = "Form1";
            weatherGroupBox.ResumeLayout(false);
            weatherGroupBox.PerformLayout();
            outfitGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicSummerImg).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicWinterImg).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox weatherGroupBox;
        private GroupBox outfitGroupBox;
        private PictureBox PicSummerImg;
        private GroupBox groupBox4;
        private TextBox TxtDcpSummer;
        private RadioButton RdoWinter;
        private RadioButton RdoSummer;
        private GroupBox groupBox5;
        private PictureBox PicWinterImg;
        private GroupBox groupBox6;
        private TextBox TxtDcpWinter;
    }
}
