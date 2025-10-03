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
            panelTop = new Panel();
            buttonHelp = new Button();
            buttonOpenFile = new Button();
            labelTask = new Label();
            panelBottom = new Panel();
            splitContainer = new SplitContainer();
            textBoxIn = new TextBox();
            textBoxOut = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonHelp);
            panelTop.Controls.Add(buttonOpenFile);
            panelTop.Controls.Add(labelTask);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(933, 115);
            panelTop.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.Location = new Point(832, 14);
            buttonHelp.Margin = new Padding(4, 3, 4, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(88, 27);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.FromArgb(0, 192, 0);
            buttonOpenFile.Location = new Point(14, 67);
            buttonOpenFile.Margin = new Padding(4, 3, 4, 3);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(88, 27);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.Text = "Открыть";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(14, 10);
            labelTask.Margin = new Padding(4, 0, 4, 0);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(417, 15);
            labelTask.TabIndex = 0;
            labelTask.Text = "Вывести предпоследнее слово каждой строки в одну строку через пробел";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(splitContainer);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 115);
            panelBottom.Margin = new Padding(4, 3, 4, 3);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(933, 404);
            panelBottom.TabIndex = 1;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(4, 3, 4, 3);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(textBoxIn);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(textBoxOut);
            splitContainer.Size = new Size(933, 404);
            splitContainer.SplitterDistance = 466;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 0;
            // 
            // textBoxIn
            // 
            textBoxIn.BackColor = SystemColors.ScrollBar;
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(0, 0);
            textBoxIn.Margin = new Padding(4, 3, 4, 3);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ScrollBars = ScrollBars.Both;
            textBoxIn.Size = new Size(466, 404);
            textBoxIn.TabIndex = 0;
            // 
            // textBoxOut
            // 
            textBoxOut.BackColor = SystemColors.AppWorkspace;
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(0, 0);
            textBoxOut.Margin = new Padding(4, 3, 4, 3);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.ScrollBars = ScrollBars.Both;
            textBoxOut.Size = new Size(462, 404);
            textBoxOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 11 | Зайцев Я.А.";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
    }
}