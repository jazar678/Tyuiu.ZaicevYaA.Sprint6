namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V22
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
            this.groupBoxInput_ZYA = new System.Windows.Forms.GroupBox();
            this.textBoxInput_ZYA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_ZYA = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_ZYA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_ZYA = new System.Windows.Forms.Button();
            this.buttonDone_ZYA = new System.Windows.Forms.Button();
            this.buttonHelp_ZYA = new System.Windows.Forms.Button();
            this.openFileDialog_ZYA = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxInput_ZYA.SuspendLayout();
            this.groupBoxOutput_ZYA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInput_ZYA
            // 
            this.groupBoxInput_ZYA.Controls.Add(this.textBoxInput_ZYA);
            this.groupBoxInput_ZYA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput_ZYA.Name = "groupBoxInput_ZYA";
            this.groupBoxInput_ZYA.Size = new System.Drawing.Size(380, 400);
            this.groupBoxInput_ZYA.TabIndex = 0;
            this.groupBoxInput_ZYA.TabStop = false;
            this.groupBoxInput_ZYA.Text = "Ввод";
            // 
            // textBoxInput_ZYA
            // 
            this.textBoxInput_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_ZYA.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput_ZYA.Multiline = true;
            this.textBoxInput_ZYA.Name = "textBoxInput_ZYA";
            this.textBoxInput_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_ZYA.Size = new System.Drawing.Size(374, 381);
            this.textBoxInput_ZYA.TabIndex = 0;
            // 
            // groupBoxOutput_ZYA
            // 
            this.groupBoxOutput_ZYA.Controls.Add(this.textBoxOutput_ZYA);
            this.groupBoxOutput_ZYA.Location = new System.Drawing.Point(398, 12);
            this.groupBoxOutput_ZYA.Name = "groupBoxOutput_ZYA";
            this.groupBoxOutput_ZYA.Size = new System.Drawing.Size(380, 400);
            this.groupBoxOutput_ZYA.TabIndex = 1;
            this.groupBoxOutput_ZYA.TabStop = false;
            this.groupBoxOutput_ZYA.Text = "Вывод";
            // 
            // textBoxOutput_ZYA
            // 
            this.textBoxOutput_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput_ZYA.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput_ZYA.Multiline = true;
            this.textBoxOutput_ZYA.Name = "textBoxOutput_ZYA";
            this.textBoxOutput_ZYA.ReadOnly = true;
            this.textBoxOutput_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_ZYA.Size = new System.Drawing.Size(374, 381);
            this.textBoxOutput_ZYA.TabIndex = 0;
            // 
            // buttonOpenFile_ZYA
            // 
            this.buttonOpenFile_ZYA.Location = new System.Drawing.Point(12, 418);
            this.buttonOpenFile_ZYA.Name = "buttonOpenFile_ZYA";
            this.buttonOpenFile_ZYA.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenFile_ZYA.TabIndex = 2;
            this.buttonOpenFile_ZYA.Text = "Открыть файл";
            this.buttonOpenFile_ZYA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZYA.Click += new System.EventHandler(this.buttonOpenFile_ZYA_Click);
            // 
            // buttonDone_ZYA
            // 
            this.buttonDone_ZYA.Enabled = false;
            this.buttonDone_ZYA.Location = new System.Drawing.Point(118, 418);
            this.buttonDone_ZYA.Name = "buttonDone_ZYA";
            this.buttonDone_ZYA.Size = new System.Drawing.Size(100, 30);
            this.buttonDone_ZYA.TabIndex = 3;
            this.buttonDone_ZYA.Text = "Выполнить";
            this.buttonDone_ZYA.UseVisualStyleBackColor = true;
            this.buttonDone_ZYA.Click += new System.EventHandler(this.buttonDone_ZYA_Click);
            // 
            // buttonHelp_ZYA
            // 
            this.buttonHelp_ZYA.Location = new System.Drawing.Point(678, 418);
            this.buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            this.buttonHelp_ZYA.Size = new System.Drawing.Size(100, 30);
            this.buttonHelp_ZYA.TabIndex = 4;
            this.buttonHelp_ZYA.Text = "Справка";
            this.buttonHelp_ZYA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZYA.Click += new System.EventHandler(this.buttonHelp_ZYA_Click);
            // 
            // openFileDialog_ZYA
            // 
            this.openFileDialog_ZYA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 460);
            this.Controls.Add(this.buttonHelp_ZYA);
            this.Controls.Add(this.buttonDone_ZYA);
            this.Controls.Add(this.buttonOpenFile_ZYA);
            this.Controls.Add(this.groupBoxOutput_ZYA);
            this.Controls.Add(this.groupBoxInput_ZYA);
            this.MinimumSize = new System.Drawing.Size(806, 499);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 22 | Зайцев Я.А.";
            this.groupBoxInput_ZYA.ResumeLayout(false);
            this.groupBoxInput_ZYA.PerformLayout();
            this.groupBoxOutput_ZYA.ResumeLayout(false);
            this.groupBoxOutput_ZYA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput_ZYA;
        private System.Windows.Forms.TextBox textBoxInput_ZYA;
        private System.Windows.Forms.GroupBox groupBoxOutput_ZYA;
        private System.Windows.Forms.TextBox textBoxOutput_ZYA;
        private System.Windows.Forms.Button buttonOpenFile_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ZYA;
    }
}