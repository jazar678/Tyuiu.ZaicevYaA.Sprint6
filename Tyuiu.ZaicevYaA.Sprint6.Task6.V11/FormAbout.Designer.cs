namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_ZYA = new PictureBox();
            labelInfo_ZYA = new Label();
            buttonOK_ZYA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_ZYA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_ZYA
            // 
            pictureBoxAvatar_ZYA.Location = new Point(10, 11);
            pictureBoxAvatar_ZYA.Name = "pictureBoxAvatar_ZYA";
            pictureBoxAvatar_ZYA.Size = new Size(88, 94);
            pictureBoxAvatar_ZYA.TabIndex = 0;
            pictureBoxAvatar_ZYA.TabStop = false;
            // 
            // labelInfo_ZYA
            // 
            labelInfo_ZYA.AutoSize = true;
            labelInfo_ZYA.Location = new Point(103, 11);
            labelInfo_ZYA.Name = "labelInfo_ZYA";
            labelInfo_ZYA.Size = new Size(303, 135);
            labelInfo_ZYA.TabIndex = 1;
            labelInfo_ZYA.Text = resources.GetString("labelInfo_ZYA.Text");
            // 
            // buttonOK_ZYA
            // 
            buttonOK_ZYA.Location = new Point(171, 169);
            buttonOK_ZYA.Name = "buttonOK_ZYA";
            buttonOK_ZYA.Size = new Size(66, 22);
            buttonOK_ZYA.TabIndex = 2;
            buttonOK_ZYA.Text = "OK";
            buttonOK_ZYA.UseVisualStyleBackColor = true;
            buttonOK_ZYA.Click += buttonOK_ZYA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 213);
            Controls.Add(buttonOK_ZYA);
            Controls.Add(labelInfo_ZYA);
            Controls.Add(pictureBoxAvatar_ZYA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_ZYA).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_ZYA;
        private System.Windows.Forms.Label labelInfo_ZYA;
        private System.Windows.Forms.Button buttonOK_ZYA;
    }
}