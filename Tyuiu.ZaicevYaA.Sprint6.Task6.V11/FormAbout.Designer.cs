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

        private void InitializeComponent()
        {
            this.labelInfo_ZYA = new System.Windows.Forms.Label();
            this.buttonOk_ZYA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo_ZYA
            // 
            this.labelInfo_ZYA.AutoSize = true;
            this.labelInfo_ZYA.Location = new System.Drawing.Point(12, 20);
            this.labelInfo_ZYA.Name = "labelInfo_ZYA";
            this.labelInfo_ZYA.Size = new System.Drawing.Size(356, 78);
            this.labelInfo_ZYA.TabIndex = 0;
            this.labelInfo_ZYA.Text = "Разработчик: Зайцев Ярослав Александрович\r\nГруппа: ПКТб-24-1\r\n\r\nПрограмма выводит предпоследнее слово каждой строки\r\nиз заданного файла\r\n\r\nВнутреннее имя: Tyuiu.ZaicevYaA.Sprint6.Task6.V11";
            // 
            // buttonOk_ZYA
            // 
            this.buttonOk_ZYA.Location = new System.Drawing.Point(293, 116);
            this.buttonOk_ZYA.Name = "buttonOk_ZYA";
            this.buttonOk_ZYA.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_ZYA.TabIndex = 1;
            this.buttonOk_ZYA.Text = "ОК";
            this.buttonOk_ZYA.UseVisualStyleBackColor = true;
            this.buttonOk_ZYA.Click += new System.EventHandler(this.buttonOk_ZYA_Click);
            // 
            // FormAbout
            // 
            this.ClientSize = new System.Drawing.Size(380, 151);
            this.Controls.Add(this.buttonOk_ZYA);
            this.Controls.Add(this.labelInfo_ZYA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelInfo_ZYA;
        private System.Windows.Forms.Button buttonOk_ZYA;
    }
}