namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V21
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
            pictureBoxLogo_ZYA = new PictureBox();
            labelInfo_ZYA = new Label();
            buttonOk_ZYA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_ZYA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo_ZYA
            // 
            pictureBoxLogo_ZYA.Location = new Point(23, 23);
            pictureBoxLogo_ZYA.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLogo_ZYA.Name = "pictureBoxLogo_ZYA";
            pictureBoxLogo_ZYA.Size = new Size(117, 115);
            pictureBoxLogo_ZYA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo_ZYA.TabIndex = 0;
            pictureBoxLogo_ZYA.TabStop = false;
            pictureBoxLogo_ZYA.Click += pictureBoxLogo_ZYA_Click;
            // 
            // labelInfo_ZYA
            // 
            labelInfo_ZYA.AutoSize = true;
            labelInfo_ZYA.Location = new Point(163, 23);
            labelInfo_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelInfo_ZYA.Name = "labelInfo_ZYA";
            labelInfo_ZYA.Size = new Size(303, 105);
            labelInfo_ZYA.TabIndex = 1;
            labelInfo_ZYA.Text = "Разработчик: Зайцев Я.А.\r\nгруппа ПКТб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТомский политехнический университет (с) 2024\r\nВысшая школа цифровых технологий (с) 2024\r\n";
            // 
            // buttonOk_ZYA
            // 
            buttonOk_ZYA.Location = new Point(408, 185);
            buttonOk_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonOk_ZYA.Name = "buttonOk_ZYA";
            buttonOk_ZYA.Size = new Size(105, 35);
            buttonOk_ZYA.TabIndex = 2;
            buttonOk_ZYA.Text = "ОК";
            buttonOk_ZYA.UseVisualStyleBackColor = true;
            buttonOk_ZYA.Click += buttonOk_ZYA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 232);
            Controls.Add(buttonOk_ZYA);
            Controls.Add(labelInfo_ZYA);
            Controls.Add(pictureBoxLogo_ZYA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_ZYA).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo_ZYA;
        private System.Windows.Forms.Label labelInfo_ZYA;
        private System.Windows.Forms.Button buttonOk_ZYA;
    }
}