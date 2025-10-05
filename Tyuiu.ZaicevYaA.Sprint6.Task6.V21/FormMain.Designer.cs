using Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib;
namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V21
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
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();

            // textBoxIn
            this.textBoxIn.Location = new System.Drawing.Point(12, 12);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn.Size = new System.Drawing.Size(400, 200);
            this.textBoxIn.TabIndex = 0;

            // textBoxOut
            this.textBoxOut.Location = new System.Drawing.Point(12, 218);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(400, 200);
            this.textBoxOut.TabIndex = 1;

            // buttonOpenFile
            this.buttonOpenFile.Image = global::Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Properties.Resources.folder_normal;
            this.buttonOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFile.Location = new System.Drawing.Point(418, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(120, 40);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Открыть";
            this.buttonOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            this.buttonOpenFile.MouseEnter += new System.EventHandler(this.buttonOpenFile_MouseEnter);
            this.buttonOpenFile.MouseLeave += new System.EventHandler(this.buttonOpenFile_MouseLeave);

            // buttonDone
            this.buttonDone.Enabled = false;
            this.buttonDone.Image = global::Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Properties.Resources.run_disabled;
            this.buttonDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDone.Location = new System.Drawing.Point(418, 58);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(120, 40);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);

            // buttonHelp
            this.buttonHelp.Image = global::Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Properties.Resources.help_normal;
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.Location = new System.Drawing.Point(418, 104);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(120, 40);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.MouseEnter += new System.EventHandler(this.buttonHelp_MouseEnter);
            this.buttonHelp.MouseLeave += new System.EventHandler(this.buttonHelp_MouseLeave);

            // openFileDialogTask
            this.openFileDialogTask.FileName = "InPutFileTask6V21";
            this.openFileDialogTask.Filter = "Текстовые файлы|*.txt";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 430);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 21 | Зайцев Я.А.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
    }
}