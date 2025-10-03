namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop_ZYA = new System.Windows.Forms.Panel();
            this.buttonHelp_ZYA = new System.Windows.Forms.Button();
            this.buttonExecute_ZYA = new System.Windows.Forms.Button();
            this.buttonOpenFile_ZYA = new System.Windows.Forms.Button();
            this.panelBottom_ZYA = new System.Windows.Forms.Panel();
            this.splitContainer_ZYA = new System.Windows.Forms.SplitContainer();
            this.textBoxIn_ZYA = new System.Windows.Forms.TextBox();
            this.textBoxOut_ZYA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_ZYA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_ZYA = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_ZYA.SuspendLayout();
            this.panelBottom_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_ZYA)).BeginInit();
            this.splitContainer_ZYA.Panel1.SuspendLayout();
            this.splitContainer_ZYA.Panel2.SuspendLayout();
            this.splitContainer_ZYA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_ZYA
            // 
            this.panelTop_ZYA.Controls.Add(this.buttonHelp_ZYA);
            this.panelTop_ZYA.Controls.Add(this.buttonExecute_ZYA);
            this.panelTop_ZYA.Controls.Add(this.buttonOpenFile_ZYA);
            this.panelTop_ZYA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_ZYA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_ZYA.Name = "panelTop_ZYA";
            this.panelTop_ZYA.Size = new System.Drawing.Size(800, 60);
            this.panelTop_ZYA.TabIndex = 0;
            // 
            // buttonHelp_ZYA
            // 
            this.buttonHelp_ZYA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZYA.Location = new System.Drawing.Point(700, 12);
            this.buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            this.buttonHelp_ZYA.Size = new System.Drawing.Size(88, 35);
            this.buttonHelp_ZYA.TabIndex = 2;
            this.buttonHelp_ZYA.Text = "Справка";
            this.toolTip_ZYA.SetToolTip(this.buttonHelp_ZYA, "О программе");
            this.buttonHelp_ZYA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZYA.Click += new System.EventHandler(this.buttonHelp_ZYA_Click);
            // 
            // buttonExecute_ZYA
            // 
            this.buttonExecute_ZYA.Enabled = false;
            this.buttonExecute_ZYA.Location = new System.Drawing.Point(106, 12);
            this.buttonExecute_ZYA.Name = "buttonExecute_ZYA";
            this.buttonExecute_ZYA.Size = new System.Drawing.Size(88, 35);
            this.buttonExecute_ZYA.TabIndex = 1;
            this.buttonExecute_ZYA.Text = "Выполнить";
            this.toolTip_ZYA.SetToolTip(this.buttonExecute_ZYA, "Выполнить задание");
            this.buttonExecute_ZYA.UseVisualStyleBackColor = true;
            this.buttonExecute_ZYA.Click += new System.EventHandler(this.buttonExecute_ZYA_Click);
            // 
            // buttonOpenFile_ZYA
            // 
            this.buttonOpenFile_ZYA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_ZYA.Name = "buttonOpenFile_ZYA";
            this.buttonOpenFile_ZYA.Size = new System.Drawing.Size(88, 35);
            this.buttonOpenFile_ZYA.TabIndex = 0;
            this.buttonOpenFile_ZYA.Text = "Открыть файл";
            this.toolTip_ZYA.SetToolTip(this.buttonOpenFile_ZYA, "Открыть файл");
            this.buttonOpenFile_ZYA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZYA.Click += new System.EventHandler(this.buttonOpenFile_ZYA_Click);
            // 
            // panelBottom_ZYA
            // 
            this.panelBottom_ZYA.Controls.Add(this.splitContainer_ZYA);
            this.panelBottom_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom_ZYA.Location = new System.Drawing.Point(0, 60);
            this.panelBottom_ZYA.Name = "panelBottom_ZYA";
            this.panelBottom_ZYA.Size = new System.Drawing.Size(800, 390);
            this.panelBottom_ZYA.TabIndex = 1;
            // 
            // splitContainer_ZYA
            // 
            this.splitContainer_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_ZYA.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_ZYA.Name = "splitContainer_ZYA";
            // 
            // splitContainer_ZYA.Panel1
            // 
            this.splitContainer_ZYA.Panel1.Controls.Add(this.textBoxIn_ZYA);
            // 
            // splitContainer_ZYA.Panel2
            // 
            this.splitContainer_ZYA.Panel2.Controls.Add(this.textBoxOut_ZYA);
            this.splitContainer_ZYA.Size = new System.Drawing.Size(800, 390);
            this.splitContainer_ZYA.SplitterDistance = 400;
            this.splitContainer_ZYA.TabIndex = 0;
            // 
            // textBoxIn_ZYA
            // 
            this.textBoxIn_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_ZYA.Location = new System.Drawing.Point(0, 0);
            this.textBoxIn_ZYA.Multiline = true;
            this.textBoxIn_ZYA.Name = "textBoxIn_ZYA";
            this.textBoxIn_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_ZYA.Size = new System.Drawing.Size(400, 390);
            this.textBoxIn_ZYA.TabIndex = 0;
            // 
            // textBoxOut_ZYA
            // 
            this.textBoxOut_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_ZYA.Location = new System.Drawing.Point(0, 0);
            this.textBoxOut_ZYA.Multiline = true;
            this.textBoxOut_ZYA.Name = "textBoxOut_ZYA";
            this.textBoxOut_ZYA.ReadOnly = true;
            this.textBoxOut_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_ZYA.Size = new System.Drawing.Size(396, 390);
            this.textBoxOut_ZYA.TabIndex = 0;
            // 
            // openFileDialogTask_ZYA
            // 
            this.openFileDialogTask_ZYA.FileName = "openFileDialog1";
            this.openFileDialogTask_ZYA.Filter = "Текстовые файлы|*.txt";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBottom_ZYA);
            this.Controls.Add(this.panelTop_ZYA);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 11 | Зайцев Я.А.";
            this.panelTop_ZYA.ResumeLayout(false);
            this.panelBottom_ZYA.ResumeLayout(false);
            this.splitContainer_ZYA.Panel1.ResumeLayout(false);
            this.splitContainer_ZYA.Panel1.PerformLayout();
            this.splitContainer_ZYA.Panel2.ResumeLayout(false);
            this.splitContainer_ZYA.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_ZYA)).EndInit();
            this.splitContainer_ZYA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_ZYA;
        private System.Windows.Forms.Panel panelBottom_ZYA;
        private System.Windows.Forms.SplitContainer splitContainer_ZYA;
        private System.Windows.Forms.TextBox textBoxIn_ZYA;
        private System.Windows.Forms.TextBox textBoxOut_ZYA;
        private System.Windows.Forms.Button buttonOpenFile_ZYA;
        private System.Windows.Forms.Button buttonExecute_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZYA;
        private System.Windows.Forms.ToolTip toolTip_ZYA;
    }
}