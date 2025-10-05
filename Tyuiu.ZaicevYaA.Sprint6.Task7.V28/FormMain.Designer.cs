namespace Tyuiu.ZaicevYaA.Sprint6.Task7.V28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.panelTop.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBoxOutput);
            this.panelTop.Controls.Add(this.groupBoxInput);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(884, 411);
            this.panelTop.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridViewOut);
            this.groupBoxOutput.Location = new System.Drawing.Point(448, 12);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(424, 350);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            this.dataGridViewOut.AllowUserToAddRows = false;
            this.dataGridViewOut.AllowUserToDeleteRows = false;
            this.dataGridViewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut.Name = "dataGridViewOut";
            this.dataGridViewOut.ReadOnly = true;
            this.dataGridViewOut.Size = new System.Drawing.Size(418, 331);
            this.dataGridViewOut.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.dataGridViewIn);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(430, 350);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            this.dataGridViewIn.AllowUserToAddRows = false;
            this.dataGridViewIn.AllowUserToDeleteRows = false;
            this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn.Name = "dataGridViewIn";
            this.dataGridViewIn.ReadOnly = true;
            this.dataGridViewIn.Size = new System.Drawing.Size(424, 331);
            this.dataGridViewIn.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonHelp);
            this.panelButtons.Controls.Add(this.buttonSaveFile);
            this.panelButtons.Controls.Add(this.buttonDone);
            this.panelButtons.Controls.Add(this.buttonOpenFile);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 411);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(884, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.Location = new System.Drawing.Point(752, 10);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(120, 30);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.Image")));
            this.buttonSaveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveFile.Location = new System.Drawing.Point(264, 10);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(120, 30);
            this.buttonSaveFile.TabIndex = 2;
            this.buttonSaveFile.Text = "Сохранить";
            this.buttonSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Enabled = false;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDone.Location = new System.Drawing.Point(138, 10);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(120, 30);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 10);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(120, 30);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | Зайцев Я.А.";
            this.panelTop.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}