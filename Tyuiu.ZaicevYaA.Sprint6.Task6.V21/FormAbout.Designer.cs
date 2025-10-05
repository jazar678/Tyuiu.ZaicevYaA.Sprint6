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
            this.pictureBoxLogo_ZYA = new System.Windows.Forms.PictureBox();
            this.labelInfo_ZYA = new System.Windows.Forms.Label();
            this.buttonOk_ZYA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_ZYA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo_ZYA
            // 
            this.pictureBoxLogo_ZYA.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxLogo_ZYA.Name = "pictureBoxLogo_ZYA";
            this.pictureBoxLogo_ZYA.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo_ZYA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo_ZYA.TabIndex = 0;
            this.pictureBoxLogo_ZYA.TabStop = false;
            // 
            // labelInfo_ZYA
            // 
            this.labelInfo_ZYA.AutoSize = true;
            this.labelInfo_ZYA.Location = new System.Drawing.Point(140, 20);
            this.labelInfo_ZYA.Name = "labelInfo_ZYA";
            this.labelInfo_ZYA.Size = new System.Drawing.Size(300, 130);
            this.labelInfo_ZYA.TabIndex = 1;
            this.labelInfo_ZYA.Text = "Разработчик: Зайцев Я.А.\r\nгруппа ПКТб-24-1\r\n\r\nПрограмма разработана в рамках изу" +
    "чения языка C#\r\n\r\nТомский политехнический университет (с) 2024\r\nВысшая школа ци" +
    "фровых технологий (с) 2024\r\n";
            // 
            // buttonOk_ZYA
            // 
            this.buttonOk_ZYA.Location = new System.Drawing.Point(350, 160);
            this.buttonOk_ZYA.Name = "buttonOk_ZYA";
            this.buttonOk_ZYA.Size = new System.Drawing.Size(90, 30);
            this.buttonOk_ZYA.TabIndex = 2;
            this.buttonOk_ZYA.Text = "ОК";
            this.buttonOk_ZYA.UseVisualStyleBackColor = true;
            this.buttonOk_ZYA.Click += new System.EventHandler(this.buttonOk_ZYA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 201);
            this.Controls.Add(this.buttonOk_ZYA);
            this.Controls.Add(this.labelInfo_ZYA);
            this.Controls.Add(this.pictureBoxLogo_ZYA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_ZYA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo_ZYA;
        private System.Windows.Forms.Label labelInfo_ZYA;
        private System.Windows.Forms.Button buttonOk_ZYA;
    }
}