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
            this.panelTop_ZYA = new System.Windows.Forms.Panel();
            this.groupBoxIn_ZYA = new System.Windows.Forms.GroupBox();
            this.textBoxIn_ZYA = new System.Windows.Forms.TextBox();
            this.groupBoxOut_ZYA = new System.Windows.Forms.GroupBox();
            this.textBoxOut_ZYA = new System.Windows.Forms.TextBox();
            this.panelButtons_ZYA = new System.Windows.Forms.Panel();
            this.buttonHelp_ZYA = new System.Windows.Forms.Button();
            this.buttonDone_ZYA = new System.Windows.Forms.Button();
            this.buttonOpenFile_ZYA = new System.Windows.Forms.Button();
            this.openFileDialogTask_ZYA = new System.Windows.Forms.OpenFileDialog();
            this.panelTop_ZYA.SuspendLayout();
            this.groupBoxIn_ZYA.SuspendLayout();
            this.groupBoxOut_ZYA.SuspendLayout();
            this.panelButtons_ZYA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_ZYA
            // 
            this.panelTop_ZYA.Controls.Add(this.groupBoxOut_ZYA);
            this.panelTop_ZYA.Controls.Add(this.groupBoxIn_ZYA);
            this.panelTop_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop_ZYA.Location = new System.Drawing.Point(0, 60);
            this.panelTop_ZYA.Name = "panelTop_ZYA";
            this.panelTop_ZYA.Size = new System.Drawing.Size(784, 501);
            this.panelTop_ZYA.TabIndex = 0;
            // 
            // groupBoxIn_ZYA
            // 
            this.groupBoxIn_ZYA.Controls.Add(this.textBoxIn_ZYA);
            this.groupBoxIn_ZYA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxIn_ZYA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_ZYA.Name = "groupBoxIn_ZYA";
            this.groupBoxIn_ZYA.Size = new System.Drawing.Size(392, 501);
            this.groupBoxIn_ZYA.TabIndex = 0;
            this.groupBoxIn_ZYA.TabStop = false;
            this.groupBoxIn_ZYA.Text = "Ввод:";
            // 
            // textBoxIn_ZYA
            // 
            this.textBoxIn_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_ZYA.Location = new System.Drawing.Point(3, 16);
            this.textBoxIn_ZYA.Multiline = true;
            this.textBoxIn_ZYA.Name = "textBoxIn_ZYA";
            this.textBoxIn_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIn_ZYA.Size = new System.Drawing.Size(386, 482);
            this.textBoxIn_ZYA.TabIndex = 0;
            // 
            // groupBoxOut_ZYA
            // 
            this.groupBoxOut_ZYA.Controls.Add(this.textBoxOut_ZYA);
            this.groupBoxOut_ZYA.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOut_ZYA.Location = new System.Drawing.Point(392, 0);
            this.groupBoxOut_ZYA.Name = "groupBoxOut_ZYA";
            this.groupBoxOut_ZYA.Size = new System.Drawing.Size(392, 501);
            this.groupBoxOut_ZYA.TabIndex = 1;
            this.groupBoxOut_ZYA.TabStop = false;
            this.groupBoxOut_ZYA.Text = "Вывод:";
            // 
            // textBoxOut_ZYA
            // 
            this.textBoxOut_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_ZYA.Location = new System.Drawing.Point(3, 16);
            this.textBoxOut_ZYA.Multiline = true;
            this.textBoxOut_ZYA.Name = "textBoxOut_ZYA";
            this.textBoxOut_ZYA.ReadOnly = true;
            this.textBoxOut_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOut_ZYA.Size = new System.Drawing.Size(386, 482);
            this.textBoxOut_ZYA.TabIndex = 0;
            // 
            // panelButtons_ZYA
            // 
            this.panelButtons_ZYA.Controls.Add(this.buttonHelp_ZYA);
            this.panelButtons_ZYA.Controls.Add(this.buttonDone_ZYA);
            this.panelButtons_ZYA.Controls.Add(this.buttonOpenFile_ZYA);
            this.panelButtons_ZYA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_ZYA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_ZYA.Name = "panelButtons_ZYA";
            this.panelButtons_ZYA.Size = new System.Drawing.Size(784, 60);
            this.panelButtons_ZYA.TabIndex = 1;
            // 
            // buttonHelp_ZYA
            // 
            this.buttonHelp_ZYA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZYA.Location = new System.Drawing.Point(697, 12);
            this.buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            this.buttonHelp_ZYA.Size = new System.Drawing.Size(75, 35);
            this.buttonHelp_ZYA.TabIndex = 2;
            this.buttonHelp_ZYA.Text = "Справка";
            this.buttonHelp_ZYA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZYA.Click += new System.EventHandler(this.buttonHelp_ZYA_Click);
            // 
            // buttonDone_ZYA
            // 
            this.buttonDone_ZYA.Enabled = false;
            this.buttonDone_ZYA.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_ZYA.Name = "buttonDone_ZYA";
            this.buttonDone_ZYA.Size = new System.Drawing.Size(75, 35);
            this.buttonDone_ZYA.TabIndex = 1;
            this.buttonDone_ZYA.Text = "Выполнить";
            this.buttonDone_ZYA.UseVisualStyleBackColor = true;
            this.buttonDone_ZYA.Click += new System.EventHandler(this.buttonDone_ZYA_Click);
            // 
            // buttonOpenFile_ZYA
            // 
            this.buttonOpenFile_ZYA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_ZYA.Name = "buttonOpenFile_ZYA";
            this.buttonOpenFile_ZYA.Size = new System.Drawing.Size(75, 35);
            this.buttonOpenFile_ZYA.TabIndex = 0;
            this.buttonOpenFile_ZYA.Text = "Открыть файл";
            this.buttonOpenFile_ZYA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZYA.Click += new System.EventHandler(this.buttonOpenFile_ZYA_Click);
            // 
            // openFileDialogTask_ZYA
            // 
            this.openFileDialogTask_ZYA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelTop_ZYA);
            this.Controls.Add(this.panelButtons_ZYA);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 22 | Зайцев Я.А.";
            this.panelTop_ZYA.ResumeLayout(false);
            this.groupBoxIn_ZYA.ResumeLayout(false);
            this.groupBoxIn_ZYA.PerformLayout();
            this.groupBoxOut_ZYA.ResumeLayout(false);
            this.groupBoxOut_ZYA.PerformLayout();
            this.panelButtons_ZYA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_ZYA;
        private System.Windows.Forms.GroupBox groupBoxOut_ZYA;
        private System.Windows.Forms.TextBox textBoxOut_ZYA;
        private System.Windows.Forms.GroupBox groupBoxIn_ZYA;
        private System.Windows.Forms.TextBox textBoxIn_ZYA;
        private System.Windows.Forms.Panel panelButtons_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
        private System.Windows.Forms.Button buttonOpenFile_ZYA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZYA;
    }
}