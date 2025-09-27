namespace Tyuiu.ZaicevYA.Sprint6.Task0.V6
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
            labelCondition_ZYA = new Label();
            textBoxVarX_ZYA = new TextBox();
            labelVarX_ZYA = new Label();
            textBoxResult_ZYA = new TextBox();
            labelResult_ZYA = new Label();
            buttonCalculate_ZYA = new Button();
            buttonHelp_ZYA = new Button();
            SuspendLayout();
            // 
            // labelCondition_ZYA
            // 
            labelCondition_ZYA.AutoSize = true;
            labelCondition_ZYA.Location = new Point(14, 10);
            labelCondition_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelCondition_ZYA.Name = "labelCondition_ZYA";
            labelCondition_ZYA.Size = new Size(386, 15);
            labelCondition_ZYA.TabIndex = 0;
            labelCondition_ZYA.Text = "Вычислить выражение по формуле: y(x) = x / sqrt(x^2 + x), при x = 3";
            // 
            // textBoxVarX_ZYA
            // 
            textBoxVarX_ZYA.Location = new Point(97, 43);
            textBoxVarX_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxVarX_ZYA.Name = "textBoxVarX_ZYA";
            textBoxVarX_ZYA.Size = new Size(116, 23);
            textBoxVarX_ZYA.TabIndex = 2;
            textBoxVarX_ZYA.Text = "3";
            // 
            // labelVarX_ZYA
            // 
            labelVarX_ZYA.AutoSize = true;
            labelVarX_ZYA.Location = new Point(14, 46);
            labelVarX_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelVarX_ZYA.Name = "labelVarX_ZYA";
            labelVarX_ZYA.Size = new Size(46, 15);
            labelVarX_ZYA.TabIndex = 1;
            labelVarX_ZYA.Text = "Ввод X:";
            // 
            // textBoxResult_ZYA
            // 
            textBoxResult_ZYA.Location = new Point(97, 77);
            textBoxResult_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxResult_ZYA.Name = "textBoxResult_ZYA";
            textBoxResult_ZYA.ReadOnly = true;
            textBoxResult_ZYA.Size = new Size(116, 23);
            textBoxResult_ZYA.TabIndex = 4;
            // 
            // labelResult_ZYA
            // 
            labelResult_ZYA.AutoSize = true;
            labelResult_ZYA.Location = new Point(14, 81);
            labelResult_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelResult_ZYA.Name = "labelResult_ZYA";
            labelResult_ZYA.Size = new Size(63, 15);
            labelResult_ZYA.TabIndex = 3;
            labelResult_ZYA.Text = "Результат:";
            // 
            // buttonCalculate_ZYA
            // 
            buttonCalculate_ZYA.Location = new Point(233, 40);
            buttonCalculate_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate_ZYA.Name = "buttonCalculate_ZYA";
            buttonCalculate_ZYA.Size = new Size(88, 27);
            buttonCalculate_ZYA.TabIndex = 5;
            buttonCalculate_ZYA.Text = "Выполнить";
            buttonCalculate_ZYA.UseVisualStyleBackColor = true;
            buttonCalculate_ZYA.Click += buttonCalculate_ZYA_Click;
            // 
            // buttonHelp_ZYA
            // 
            buttonHelp_ZYA.Location = new Point(233, 75);
            buttonHelp_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            buttonHelp_ZYA.Size = new Size(88, 27);
            buttonHelp_ZYA.TabIndex = 6;
            buttonHelp_ZYA.Text = "Справка";
            buttonHelp_ZYA.UseVisualStyleBackColor = true;
            buttonHelp_ZYA.Click += buttonHelp_ZYA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 121);
            Controls.Add(buttonHelp_ZYA);
            Controls.Add(buttonCalculate_ZYA);
            Controls.Add(textBoxResult_ZYA);
            Controls.Add(labelResult_ZYA);
            Controls.Add(textBoxVarX_ZYA);
            Controls.Add(labelVarX_ZYA);
            Controls.Add(labelCondition_ZYA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 6 | Зайцев Я.А.";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCondition_ZYA;
        private System.Windows.Forms.TextBox textBoxVarX_ZYA;
        private System.Windows.Forms.Label labelVarX_ZYA;
        private System.Windows.Forms.TextBox textBoxResult_ZYA;
        private System.Windows.Forms.Label labelResult_ZYA;
        private System.Windows.Forms.Button buttonCalculate_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
    }
}