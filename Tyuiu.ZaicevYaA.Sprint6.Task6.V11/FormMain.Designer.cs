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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBoxIn_ZYA = new TextBox();
            textBoxOut_ZYA = new TextBox();
            buttonOpenFile_ZYA = new Button();
            buttonDone_ZYA = new Button();
            buttonHelp_ZYA = new Button();
            openFileDialogTask_ZYA = new OpenFileDialog();
            labelIn_ZYA = new Label();
            labelOut_ZYA = new Label();
            SuspendLayout();
            // 
            // textBoxIn_ZYA
            // 
            textBoxIn_ZYA.Location = new Point(14, 37);
            textBoxIn_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxIn_ZYA.Multiline = true;
            textBoxIn_ZYA.Name = "textBoxIn_ZYA";
            textBoxIn_ZYA.ScrollBars = ScrollBars.Vertical;
            textBoxIn_ZYA.Size = new Size(466, 230);
            textBoxIn_ZYA.TabIndex = 0;
            // 
            // textBoxOut_ZYA
            // 
            textBoxOut_ZYA.Location = new Point(488, 37);
            textBoxOut_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxOut_ZYA.Multiline = true;
            textBoxOut_ZYA.Name = "textBoxOut_ZYA";
            textBoxOut_ZYA.ReadOnly = true;
            textBoxOut_ZYA.ScrollBars = ScrollBars.Vertical;
            textBoxOut_ZYA.Size = new Size(466, 230);
            textBoxOut_ZYA.TabIndex = 1;
            // 
            // buttonOpenFile_ZYA
            // 
            buttonOpenFile_ZYA.BackColor = Color.FromArgb(255, 128, 0);
            buttonOpenFile_ZYA.Location = new Point(14, 275);
            buttonOpenFile_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonOpenFile_ZYA.Name = "buttonOpenFile_ZYA";
            buttonOpenFile_ZYA.Size = new Size(140, 35);
            buttonOpenFile_ZYA.TabIndex = 2;
            buttonOpenFile_ZYA.Text = "Открыть файл";
            buttonOpenFile_ZYA.UseVisualStyleBackColor = false;
            buttonOpenFile_ZYA.Click += buttonOpenFile_ZYA_Click;
            // 
            // buttonDone_ZYA
            // 
            buttonDone_ZYA.BackColor = Color.Lime;
            buttonDone_ZYA.Enabled = false;
            buttonDone_ZYA.Location = new Point(418, 275);
            buttonDone_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonDone_ZYA.Name = "buttonDone_ZYA";
            buttonDone_ZYA.Size = new Size(140, 35);
            buttonDone_ZYA.TabIndex = 3;
            buttonDone_ZYA.Text = "Выполнить";
            buttonDone_ZYA.UseVisualStyleBackColor = false;
            buttonDone_ZYA.Click += buttonDone_ZYA_Click;
            // 
            // buttonHelp_ZYA
            // 
            buttonHelp_ZYA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_ZYA.Location = new Point(814, 275);
            buttonHelp_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            buttonHelp_ZYA.Size = new Size(140, 35);
            buttonHelp_ZYA.TabIndex = 4;
            buttonHelp_ZYA.Text = "Справка";
            buttonHelp_ZYA.UseVisualStyleBackColor = false;
            buttonHelp_ZYA.Click += buttonHelp_ZYA_Click;
            // 
            // openFileDialogTask_ZYA
            // 
            openFileDialogTask_ZYA.FileName = "openFileDialog1";
            openFileDialogTask_ZYA.Filter = "Текстовые файлы|*.txt";
            // 
            // labelIn_ZYA
            // 
            labelIn_ZYA.AutoSize = true;
            labelIn_ZYA.Location = new Point(14, 14);
            labelIn_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelIn_ZYA.Name = "labelIn_ZYA";
            labelIn_ZYA.Size = new Size(99, 15);
            labelIn_ZYA.TabIndex = 5;
            labelIn_ZYA.Text = "Входные данные";
            // 
            // labelOut_ZYA
            // 
            labelOut_ZYA.AutoSize = true;
            labelOut_ZYA.Location = new Point(488, 14);
            labelOut_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelOut_ZYA.Name = "labelOut_ZYA";
            labelOut_ZYA.Size = new Size(60, 15);
            labelOut_ZYA.TabIndex = 6;
            labelOut_ZYA.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 324);
            Controls.Add(labelOut_ZYA);
            Controls.Add(labelIn_ZYA);
            Controls.Add(buttonHelp_ZYA);
            Controls.Add(buttonDone_ZYA);
            Controls.Add(buttonOpenFile_ZYA);
            Controls.Add(textBoxOut_ZYA);
            Controls.Add(textBoxIn_ZYA);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(989, 363);
            MinimumSize = new Size(989, 363);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 11 | Зайцев Я.А.";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIn_ZYA;
        private System.Windows.Forms.TextBox textBoxOut_ZYA;
        private System.Windows.Forms.Button buttonOpenFile_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZYA;
        private System.Windows.Forms.Label labelIn_ZYA;
        private System.Windows.Forms.Label labelOut_ZYA;
    }
}