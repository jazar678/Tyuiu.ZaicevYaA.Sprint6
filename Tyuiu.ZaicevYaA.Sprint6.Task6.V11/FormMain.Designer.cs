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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxIn_ZYA = new System.Windows.Forms.TextBox();
            this.textBoxOut_ZYA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_ZYA = new System.Windows.Forms.Button();
            this.buttonExecute_ZYA = new System.Windows.Forms.Button();
            this.buttonHelp_ZYA = new System.Windows.Forms.Button();
            this.openFileDialogTask_ZYA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_ZYA = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxOpen_ZYA = new System.Windows.Forms.PictureBox();
            this.pictureBoxExecute_ZYA = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelp_ZYA = new System.Windows.Forms.PictureBox();
            this.labelInput_ZYA = new System.Windows.Forms.Label();
            this.labelOutput_ZYA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen_ZYA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExecute_ZYA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp_ZYA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIn_ZYA
            // 
            this.textBoxIn_ZYA.Location = new System.Drawing.Point(12, 35);
            this.textBoxIn_ZYA.Multiline = true;
            this.textBoxIn_ZYA.Name = "textBoxIn_ZYA";
            this.textBoxIn_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_ZYA.Size = new System.Drawing.Size(400, 200);
            this.textBoxIn_ZYA.TabIndex = 0;
            // 
            // textBoxOut_ZYA
            // 
            this.textBoxOut_ZYA.Location = new System.Drawing.Point(12, 270);
            this.textBoxOut_ZYA.Multiline = true;
            this.textBoxOut_ZYA.Name = "textBoxOut_ZYA";
            this.textBoxOut_ZYA.ReadOnly = true;
            this.textBoxOut_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_ZYA.Size = new System.Drawing.Size(400, 200);
            this.textBoxOut_ZYA.TabIndex = 1;
            // 
            // buttonOpenFile_ZYA
            // 
            this.buttonOpenFile_ZYA.Location = new System.Drawing.Point(430, 35);
            this.buttonOpenFile_ZYA.Name = "buttonOpenFile_ZYA";
            this.buttonOpenFile_ZYA.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenFile_ZYA.TabIndex = 2;
            this.buttonOpenFile_ZYA.Text = "Открыть файл";
            this.buttonOpenFile_ZYA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZYA.Click += new System.EventHandler(this.buttonOpenFile_ZYA_Click);
            // 
            // buttonExecute_ZYA
            // 
            this.buttonExecute_ZYA.Enabled = false;
            this.buttonExecute_ZYA.Location = new System.Drawing.Point(430, 85);
            this.buttonExecute_ZYA.Name = "buttonExecute_ZYA";
            this.buttonExecute_ZYA.Size = new System.Drawing.Size(100, 30);
            this.buttonExecute_ZYA.TabIndex = 3;
            this.buttonExecute_ZYA.Text = "Выполнить";
            this.buttonExecute_ZYA.UseVisualStyleBackColor = true;
            this.buttonExecute_ZYA.Click += new System.EventHandler(this.buttonExecute_ZYA_Click);
            // 
            // buttonHelp_ZYA
            // 
            this.buttonHelp_ZYA.Location = new System.Drawing.Point(430, 135);
            this.buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            this.buttonHelp_ZYA.Size = new System.Drawing.Size(100, 30);
            this.buttonHelp_ZYA.TabIndex = 4;
            this.buttonHelp_ZYA.Text = "Справка";
            this.buttonHelp_ZYA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZYA.Click += new System.EventHandler(this.buttonHelp_ZYA_Click);
            // 
            // openFileDialogTask_ZYA
            // 
            this.openFileDialogTask_ZYA.FileName = "openFileDialogTask";
            this.openFileDialogTask_ZYA.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            // 
            // pictureBoxOpen_ZYA
            // 
            this.pictureBoxOpen_ZYA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpen_ZYA.Image")));
            this.pictureBoxOpen_ZYA.Location = new System.Drawing.Point(540, 35);
            this.pictureBoxOpen_ZYA.Name = "pictureBoxOpen_ZYA";
            this.pictureBoxOpen_ZYA.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxOpen_ZYA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpen_ZYA.TabIndex = 5;
            this.pictureBoxOpen_ZYA.TabStop = false;
            this.toolTip_ZYA.SetToolTip(this.pictureBoxOpen_ZYA, "Открыть файл");
            // 
            // pictureBoxExecute_ZYA
            // 
            this.pictureBoxExecute_ZYA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExecute_ZYA.Image")));
            this.pictureBoxExecute_ZYA.Location = new System.Drawing.Point(540, 85);
            this.pictureBoxExecute_ZYA.Name = "pictureBoxExecute_ZYA";
            this.pictureBoxExecute_ZYA.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxExecute_ZYA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExecute_ZYA.TabIndex = 6;
            this.pictureBoxExecute_ZYA.TabStop = false;
            this.toolTip_ZYA.SetToolTip(this.pictureBoxExecute_ZYA, "Выполнить задание");
            // 
            // pictureBoxHelp_ZYA
            // 
            this.pictureBoxHelp_ZYA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHelp_ZYA.Image")));
            this.pictureBoxHelp_ZYA.Location = new System.Drawing.Point(540, 135);
            this.pictureBoxHelp_ZYA.Name = "pictureBoxHelp_ZYA";
            this.pictureBoxHelp_ZYA.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxHelp_ZYA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHelp_ZYA.TabIndex = 7;
            this.pictureBoxHelp_ZYA.TabStop = false;
            this.toolTip_ZYA.SetToolTip(this.pictureBoxHelp_ZYA, "О программе");
            // 
            // labelInput_ZYA
            // 
            this.labelInput_ZYA.AutoSize = true;
            this.labelInput_ZYA.Location = new System.Drawing.Point(12, 15);
            this.labelInput_ZYA.Name = "labelInput_ZYA";
            this.labelInput_ZYA.Size = new System.Drawing.Size(80, 13);
            this.labelInput_ZYA.TabIndex = 8;
            this.labelInput_ZYA.Text = "Входные данные:";
            // 
            // labelOutput_ZYA
            // 
            this.labelOutput_ZYA.AutoSize = true;
            this.labelOutput_ZYA.Location = new System.Drawing.Point(12, 250);
            this.labelOutput_ZYA.Name = "labelOutput_ZYA";
            this.labelOutput_ZYA.Size = new System.Drawing.Size(118, 13);
            this.labelOutput_ZYA.TabIndex = 9;
            this.labelOutput_ZYA.Text = "Предпоследние слова:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.labelOutput_ZYA);
            this.Controls.Add(this.labelInput_ZYA);
            this.Controls.Add(this.pictureBoxHelp_ZYA);
            this.Controls.Add(this.pictureBoxExecute_ZYA);
            this.Controls.Add(this.pictureBoxOpen_ZYA);
            this.Controls.Add(this.buttonHelp_ZYA);
            this.Controls.Add(this.buttonExecute_ZYA);
            this.Controls.Add(this.buttonOpenFile_ZYA);
            this.Controls.Add(this.textBoxOut_ZYA);
            this.Controls.Add(this.textBoxIn_ZYA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 11 | Зайцев Я.А.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen_ZYA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExecute_ZYA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp_ZYA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxIn_ZYA;
        private System.Windows.Forms.TextBox textBoxOut_ZYA;
        private System.Windows.Forms.Button buttonOpenFile_ZYA;
        private System.Windows.Forms.Button buttonExecute_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZYA;
        private System.Windows.Forms.ToolTip toolTip_ZYA;
        private System.Windows.Forms.PictureBox pictureBoxOpen_ZYA;
        private System.Windows.Forms.PictureBox pictureBoxExecute_ZYA;
        private System.Windows.Forms.PictureBox pictureBoxHelp_ZYA;
        private System.Windows.Forms.Label labelInput_ZYA;
        private System.Windows.Forms.Label labelOutput_ZYA;
    }
}