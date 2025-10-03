namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelInfo_ZYA = new Label();
            buttonOk_ZYA = new Button();
            pictureBoxLogo_ZYA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_ZYA).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_ZYA
            // 
            labelInfo_ZYA.AutoSize = true;
            labelInfo_ZYA.Location = new Point(142, 23);
            labelInfo_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelInfo_ZYA.Name = "labelInfo_ZYA";
            labelInfo_ZYA.Size = new Size(282, 75);
            labelInfo_ZYA.TabIndex = 0;
            labelInfo_ZYA.Text = "Разработчик: Зайцев Ярослав Александрович\r\nГруппа: ПКТб-24-1\r\n\r\nПрограмма разработана в рамках изучения C#\r\nТюменский индустриальный университет (c) 2024";
            // 
            // buttonOk_ZYA
            // 
            buttonOk_ZYA.Location = new Point(292, 115);
            buttonOk_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonOk_ZYA.Name = "buttonOk_ZYA";
            buttonOk_ZYA.Size = new Size(88, 27);
            buttonOk_ZYA.TabIndex = 1;
            buttonOk_ZYA.Text = "ОК";
            buttonOk_ZYA.UseVisualStyleBackColor = true;
            buttonOk_ZYA.Click += buttonOk_ZYA_Click;
            // 
            // pictureBoxLogo_ZYA
            // 
            pictureBoxLogo_ZYA.BackColor = SystemColors.Window;
            pictureBoxLogo_ZYA.Image = Properties.Resources.IMG_2954;
            pictureBoxLogo_ZYA.Location = new Point(13, 12);
            pictureBoxLogo_ZYA.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLogo_ZYA.Name = "pictureBoxLogo_ZYA";
            pictureBoxLogo_ZYA.Size = new Size(145, 128);
            pictureBoxLogo_ZYA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo_ZYA.TabIndex = 2;
            pictureBoxLogo_ZYA.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 163);
            Controls.Add(labelInfo_ZYA);
            Controls.Add(pictureBoxLogo_ZYA);
            Controls.Add(buttonOk_ZYA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_ZYA).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_ZYA;
        private System.Windows.Forms.Button buttonOk_ZYA;
        private System.Windows.Forms.PictureBox pictureBoxLogo_ZYA;
    }
}