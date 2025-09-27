namespace Tyuiu.ZaicevYaA.Sprint6.Task1.V30
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
            groupBoxInput_ZYA = new GroupBox();
            textBoxStopStep_ZYA = new TextBox();
            labelStopStep_ZYA = new Label();
            textBoxStartStep_ZYA = new TextBox();
            labelStartStep_ZYA = new Label();
            groupBoxOutput_ZYA = new GroupBox();
            textBoxResult_ZYA = new TextBox();
            buttonDone_ZYA = new Button();
            buttonHelp_ZYA = new Button();
            groupBoxInput_ZYA.SuspendLayout();
            groupBoxOutput_ZYA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInput_ZYA
            // 
            groupBoxInput_ZYA.Controls.Add(textBoxStopStep_ZYA);
            groupBoxInput_ZYA.Controls.Add(labelStopStep_ZYA);
            groupBoxInput_ZYA.Controls.Add(textBoxStartStep_ZYA);
            groupBoxInput_ZYA.Controls.Add(labelStartStep_ZYA);
            groupBoxInput_ZYA.Location = new Point(14, 14);
            groupBoxInput_ZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_ZYA.Name = "groupBoxInput_ZYA";
            groupBoxInput_ZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_ZYA.Size = new Size(350, 92);
            groupBoxInput_ZYA.TabIndex = 0;
            groupBoxInput_ZYA.TabStop = false;
            groupBoxInput_ZYA.Text = "Ввод данных";
            // 
            // textBoxStopStep_ZYA
            // 
            textBoxStopStep_ZYA.Location = new Point(210, 40);
            textBoxStopStep_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxStopStep_ZYA.Name = "textBoxStopStep_ZYA";
            textBoxStopStep_ZYA.Size = new Size(116, 23);
            textBoxStopStep_ZYA.TabIndex = 3;
            textBoxStopStep_ZYA.Text = "5";
            // 
            // labelStopStep_ZYA
            // 
            labelStopStep_ZYA.AutoSize = true;
            labelStopStep_ZYA.Location = new Point(210, 23);
            labelStopStep_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelStopStep_ZYA.Name = "labelStopStep_ZYA";
            labelStopStep_ZYA.Size = new Size(75, 15);
            labelStopStep_ZYA.TabIndex = 2;
            labelStopStep_ZYA.Text = "Конец шага:";
            // 
            // textBoxStartStep_ZYA
            // 
            textBoxStartStep_ZYA.Location = new Point(23, 40);
            textBoxStartStep_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxStartStep_ZYA.Name = "textBoxStartStep_ZYA";
            textBoxStartStep_ZYA.Size = new Size(116, 23);
            textBoxStartStep_ZYA.TabIndex = 1;
            textBoxStartStep_ZYA.Text = "-5";
            // 
            // labelStartStep_ZYA
            // 
            labelStartStep_ZYA.AutoSize = true;
            labelStartStep_ZYA.Location = new Point(23, 23);
            labelStartStep_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelStartStep_ZYA.Name = "labelStartStep_ZYA";
            labelStartStep_ZYA.Size = new Size(72, 15);
            labelStartStep_ZYA.TabIndex = 0;
            labelStartStep_ZYA.Text = "Старт шага:";
            // 
            // groupBoxOutput_ZYA
            // 
            groupBoxOutput_ZYA.Controls.Add(textBoxResult_ZYA);
            groupBoxOutput_ZYA.Location = new Point(14, 115);
            groupBoxOutput_ZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_ZYA.Name = "groupBoxOutput_ZYA";
            groupBoxOutput_ZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_ZYA.Size = new Size(888, 346);
            groupBoxOutput_ZYA.TabIndex = 1;
            groupBoxOutput_ZYA.TabStop = false;
            groupBoxOutput_ZYA.Text = "Вывод данных";
            // 
            // textBoxResult_ZYA
            // 
            textBoxResult_ZYA.BackColor = SystemColors.ActiveCaption;
            textBoxResult_ZYA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_ZYA.Location = new Point(12, 23);
            textBoxResult_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxResult_ZYA.Multiline = true;
            textBoxResult_ZYA.Name = "textBoxResult_ZYA";
            textBoxResult_ZYA.ReadOnly = true;
            textBoxResult_ZYA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ZYA.Size = new Size(863, 311);
            textBoxResult_ZYA.TabIndex = 0;
            // 
            // buttonDone_ZYA
            // 
            buttonDone_ZYA.BackColor = Color.Green;
            buttonDone_ZYA.Location = new Point(373, 473);
            buttonDone_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonDone_ZYA.Name = "buttonDone_ZYA";
            buttonDone_ZYA.Size = new Size(117, 35);
            buttonDone_ZYA.TabIndex = 3;
            buttonDone_ZYA.Text = "Выполнить";
            buttonDone_ZYA.UseVisualStyleBackColor = false;
            buttonDone_ZYA.Click += buttonDone_ZYA_Click;
            // 
            // buttonHelp_ZYA
            // 
            buttonHelp_ZYA.BackColor = Color.Blue;
            buttonHelp_ZYA.Location = new Point(784, 473);
            buttonHelp_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            buttonHelp_ZYA.Size = new Size(117, 35);
            buttonHelp_ZYA.TabIndex = 4;
            buttonHelp_ZYA.Text = "Справка";
            buttonHelp_ZYA.UseVisualStyleBackColor = false;
            buttonHelp_ZYA.Click += buttonHelp_ZYA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 520);
            Controls.Add(buttonHelp_ZYA);
            Controls.Add(buttonDone_ZYA);
            Controls.Add(groupBoxOutput_ZYA);
            Controls.Add(groupBoxInput_ZYA);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(931, 559);
            MinimumSize = new Size(931, 559);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 30 | Зайцев Я.А.";
            groupBoxInput_ZYA.ResumeLayout(false);
            groupBoxInput_ZYA.PerformLayout();
            groupBoxOutput_ZYA.ResumeLayout(false);
            groupBoxOutput_ZYA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput_ZYA;
        private System.Windows.Forms.TextBox textBoxStopStep_ZYA;
        private System.Windows.Forms.Label labelStopStep_ZYA;
        private System.Windows.Forms.TextBox textBoxStartStep_ZYA;
        private System.Windows.Forms.Label labelStartStep_ZYA;
        private System.Windows.Forms.GroupBox groupBoxOutput_ZYA;
        private System.Windows.Forms.TextBox textBoxResult_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
    }
}