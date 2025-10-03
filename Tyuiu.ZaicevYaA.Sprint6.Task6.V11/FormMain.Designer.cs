namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11
{
    partial class FormMain
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
            this.buttonOpenFile_ZYA = new System.Windows.Forms.Button();
            this.buttonDone_ZYA = new System.Windows.Forms.Button();
            this.buttonHelp_ZYA = new System.Windows.Forms.Button();
            this.textBoxIn_ZYA = new System.Windows.Forms.TextBox();
            this.textBoxOut_ZYA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_ZYA = new System.Windows.Forms.OpenFileDialog();
            this.labelInput_ZYA = new System.Windows.Forms.Label();
            this.labelOutput_ZYA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenFile_ZYA
            // 
            this.buttonOpenFile_ZYA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_ZYA.Name = "buttonOpenFile_ZYA";
            this.buttonOpenFile_ZYA.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenFile_ZYA.TabIndex = 0;
            this.buttonOpenFile_ZYA.Text = "Открыть файл";
            this.buttonOpenFile_ZYA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZYA.Click += new System.EventHandler(this.buttonOpenFile_ZYA_Click);
            // 
            // buttonDone_ZYA
            // 
            this.buttonDone_ZYA.Enabled = false;
            this.buttonDone_ZYA.Location = new System.Drawing.Point(118, 12);
            this.buttonDone_ZYA.Name = "buttonDone_ZYA";
            this.buttonDone_ZYA.Size = new System.Drawing.Size(100, 30);
            this.buttonDone_ZYA.TabIndex = 1;
            this.buttonDone_ZYA.Text = "Выполнить";
            this.buttonDone_ZYA.UseVisualStyleBackColor = true;
            this.buttonDone_ZYA.Click += new System.EventHandler(this.buttonDone_ZYA_Click);
            // 
            // buttonHelp_ZYA
            // 
            this.buttonHelp_ZYA.Location = new System.Drawing.Point(682, 12);
            this.buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            this.buttonHelp_ZYA.Size = new System.Drawing.Size(100, 30);
            this.buttonHelp_ZYA.TabIndex = 2;
            this.buttonHelp_ZYA.Text = "Справка";
            this.buttonHelp_ZYA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZYA.Click += new System.EventHandler(this.buttonHelp_ZYA_Click);
            // 
            // textBoxIn_ZYA
            // 
            this.textBoxIn_ZYA.Location = new System.Drawing.Point(12, 70);
            this.textBoxIn_ZYA.Multiline = true;
            this.textBoxIn_ZYA.Name = "textBoxIn_ZYA";
            this.textBoxIn_ZYA.ReadOnly = true;
            this.textBoxIn_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_ZYA.Size = new System.Drawing.Size(380, 379);
            this.textBoxIn_ZYA.TabIndex = 3;
            // 
            // textBoxOut_ZYA
            // 
            this.textBoxOut_ZYA.Location = new System.Drawing.Point(402, 70);
            this.textBoxOut_ZYA.Multiline = true;
            this.textBoxOut_ZYA.Name = "textBoxOut_ZYA";
            this.textBoxOut_ZYA.ReadOnly = true;
            this.textBoxOut_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_ZYA.Size = new System.Drawing.Size(380, 379);
            this.textBoxOut_ZYA.TabIndex = 4;
            // 
            // openFileDialogTask_ZYA
            // 
            this.openFileDialogTask_ZYA.FileName = "openFileDialog1";
            this.openFileDialogTask_ZYA.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            // 
            // labelInput_ZYA
            // 
            this.labelInput_ZYA.AutoSize = true;
            this.labelInput_ZYA.Location = new System.Drawing.Point(12, 54);
            this.labelInput_ZYA.Name = "labelInput_ZYA";
            this.labelInput_ZYA.Size = new System.Drawing.Size(89, 13);
            this.labelInput_ZYA.TabIndex = 5;
            this.labelInput_ZYA.Text = "Исходный файл:";
            // 
            // labelOutput_ZYA
            // 
            this.labelOutput_ZYA.AutoSize = true;
            this.labelOutput_ZYA.Location = new System.Drawing.Point(399, 54);
            this.labelOutput_ZYA.Name = "labelOutput_ZYA";
            this.labelOutput_ZYA.Size = new System.Drawing.Size(65, 13);
            this.labelOutput_ZYA.TabIndex = 6;
            this.labelOutput_ZYA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(794, 461);
            this.Controls.Add(this.labelOutput_ZYA);
            this.Controls.Add(this.labelInput_ZYA);
            this.Controls.Add(this.textBoxOut_ZYA);
            this.Controls.Add(this.textBoxIn_ZYA);
            this.Controls.Add(this.buttonHelp_ZYA);
            this.Controls.Add(this.buttonDone_ZYA);
            this.Controls.Add(this.buttonOpenFile_ZYA);
            this.MinimumSize = new System.Drawing.Size(810, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 11 | Зайцев Я.А.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonOpenFile_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
        private System.Windows.Forms.TextBox textBoxIn_ZYA;
        private System.Windows.Forms.TextBox textBoxOut_ZYA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZYA;
        private System.Windows.Forms.Label labelInput_ZYA;
        private System.Windows.Forms.Label labelOutput_ZYA;
    }
}