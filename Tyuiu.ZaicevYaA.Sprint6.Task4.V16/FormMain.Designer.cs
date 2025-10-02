namespace Tyuiu.ZaicevYA.Sprint6.Task4.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_ZYА = new Panel();
            groupBoxInput_ZYА = new GroupBox();
            textBoxStop_ZYА = new TextBox();
            labelStop_ZYА = new Label();
            textBoxStart_ZYА = new TextBox();
            labelStart_ZYА = new Label();
            groupBoxOutput_ZYА = new GroupBox();
            textBoxResult_ZYА = new TextBox();
            panelBottom_ZYА = new Panel();
            buttonHelp_ZYА = new Button();
            buttonDone_ZYА = new Button();
            chartFunction_ZYА = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_ZYА.SuspendLayout();
            groupBoxInput_ZYА.SuspendLayout();
            groupBoxOutput_ZYА.SuspendLayout();
            panelBottom_ZYА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZYА).BeginInit();
            SuspendLayout();
            // 
            // panelTop_ZYА
            // 
            panelTop_ZYА.Controls.Add(groupBoxInput_ZYА);
            panelTop_ZYА.Dock = DockStyle.Top;
            panelTop_ZYА.Location = new Point(0, 0);
            panelTop_ZYА.Margin = new Padding(4, 3, 4, 3);
            panelTop_ZYА.Name = "panelTop_ZYА";
            panelTop_ZYА.Size = new Size(1031, 92);
            panelTop_ZYА.TabIndex = 0;
            // 
            // groupBoxInput_ZYА
            // 
            groupBoxInput_ZYА.Controls.Add(textBoxStop_ZYА);
            groupBoxInput_ZYА.Controls.Add(labelStop_ZYА);
            groupBoxInput_ZYА.Controls.Add(textBoxStart_ZYА);
            groupBoxInput_ZYА.Controls.Add(labelStart_ZYА);
            groupBoxInput_ZYА.Location = new Point(14, 14);
            groupBoxInput_ZYА.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_ZYА.Name = "groupBoxInput_ZYА";
            groupBoxInput_ZYА.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_ZYА.Size = new Size(350, 69);
            groupBoxInput_ZYА.TabIndex = 0;
            groupBoxInput_ZYА.TabStop = false;
            groupBoxInput_ZYА.Text = "Ввод данных";
            // 
            // textBoxStop_ZYА
            // 
            textBoxStop_ZYА.Location = new Point(233, 29);
            textBoxStop_ZYА.Margin = new Padding(4, 3, 4, 3);
            textBoxStop_ZYА.Name = "textBoxStop_ZYА";
            textBoxStop_ZYА.Size = new Size(93, 23);
            textBoxStop_ZYА.TabIndex = 3;
            textBoxStop_ZYА.Text = "5";
            // 
            // labelStop_ZYА
            // 
            labelStop_ZYА.AutoSize = true;
            labelStop_ZYА.Location = new Point(175, 32);
            labelStop_ZYА.Margin = new Padding(4, 0, 4, 0);
            labelStop_ZYА.Name = "labelStop_ZYА";
            labelStop_ZYА.Size = new Size(44, 15);
            labelStop_ZYА.TabIndex = 2;
            labelStop_ZYА.Text = "Конец:";
            // 
            // textBoxStart_ZYА
            // 
            textBoxStart_ZYА.Location = new Point(70, 29);
            textBoxStart_ZYА.Margin = new Padding(4, 3, 4, 3);
            textBoxStart_ZYА.Name = "textBoxStart_ZYА";
            textBoxStart_ZYА.Size = new Size(93, 23);
            textBoxStart_ZYА.TabIndex = 1;
            textBoxStart_ZYА.Text = "-5";
            // 
            // labelStart_ZYА
            // 
            labelStart_ZYА.AutoSize = true;
            labelStart_ZYА.Location = new Point(12, 32);
            labelStart_ZYА.Margin = new Padding(4, 0, 4, 0);
            labelStart_ZYА.Name = "labelStart_ZYА";
            labelStart_ZYА.Size = new Size(41, 15);
            labelStart_ZYА.TabIndex = 0;
            labelStart_ZYА.Text = "Старт:";
            // 
            // groupBoxOutput_ZYА
            // 
            groupBoxOutput_ZYА.Controls.Add(textBoxResult_ZYА);
            groupBoxOutput_ZYА.Dock = DockStyle.Left;
            groupBoxOutput_ZYА.Location = new Point(0, 92);
            groupBoxOutput_ZYА.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_ZYА.Name = "groupBoxOutput_ZYА";
            groupBoxOutput_ZYА.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_ZYА.Size = new Size(350, 440);
            groupBoxOutput_ZYА.TabIndex = 1;
            groupBoxOutput_ZYА.TabStop = false;
            groupBoxOutput_ZYА.Text = "Вывод данных";
            // 
            // textBoxResult_ZYА
            // 
            textBoxResult_ZYА.Dock = DockStyle.Fill;
            textBoxResult_ZYА.Location = new Point(4, 19);
            textBoxResult_ZYА.Margin = new Padding(4, 3, 4, 3);
            textBoxResult_ZYА.Multiline = true;
            textBoxResult_ZYА.Name = "textBoxResult_ZYА";
            textBoxResult_ZYА.ReadOnly = true;
            textBoxResult_ZYА.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ZYА.Size = new Size(342, 418);
            textBoxResult_ZYА.TabIndex = 0;
            // 
            // panelBottom_ZYА
            // 
            panelBottom_ZYА.Controls.Add(buttonHelp_ZYА);
            panelBottom_ZYА.Controls.Add(buttonDone_ZYА);
            panelBottom_ZYА.Dock = DockStyle.Bottom;
            panelBottom_ZYА.Location = new Point(350, 474);
            panelBottom_ZYА.Margin = new Padding(4, 3, 4, 3);
            panelBottom_ZYА.Name = "panelBottom_ZYА";
            panelBottom_ZYА.Size = new Size(681, 58);
            panelBottom_ZYА.TabIndex = 2;
            // 
            // buttonHelp_ZYА
            // 
            buttonHelp_ZYА.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_ZYА.BackColor = SystemColors.ActiveCaption;
            buttonHelp_ZYА.Location = new Point(572, 17);
            buttonHelp_ZYА.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_ZYА.Name = "buttonHelp_ZYА";
            buttonHelp_ZYА.Size = new Size(93, 29);
            buttonHelp_ZYА.TabIndex = 1;
            buttonHelp_ZYА.Text = "Справка";
            buttonHelp_ZYА.UseVisualStyleBackColor = false;
            buttonHelp_ZYА.Click += buttonHelp_ZYА_Click;
            // 
            // buttonDone_ZYА
            // 
            buttonDone_ZYА.BackColor = Color.Green;
            buttonDone_ZYА.Location = new Point(18, 17);
            buttonDone_ZYА.Margin = new Padding(4, 3, 4, 3);
            buttonDone_ZYА.Name = "buttonDone_ZYА";
            buttonDone_ZYА.Size = new Size(93, 29);
            buttonDone_ZYА.TabIndex = 0;
            buttonDone_ZYА.Text = "Выполнить";
            buttonDone_ZYА.UseVisualStyleBackColor = false;
            buttonDone_ZYА.Click += buttonDone_ZYА_Click;
            // 
            // chartFunction_ZYА
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_ZYА.ChartAreas.Add(chartArea1);
            chartFunction_ZYА.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_ZYА.Legends.Add(legend1);
            chartFunction_ZYА.Location = new Point(350, 92);
            chartFunction_ZYА.Margin = new Padding(4, 3, 4, 3);
            chartFunction_ZYА.Name = "chartFunction_ZYА";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            chartFunction_ZYА.Series.Add(series1);
            chartFunction_ZYА.Size = new Size(681, 382);
            chartFunction_ZYА.TabIndex = 3;
            chartFunction_ZYА.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 532);
            Controls.Add(chartFunction_ZYА);
            Controls.Add(panelBottom_ZYА);
            Controls.Add(groupBoxOutput_ZYА);
            Controls.Add(panelTop_ZYА);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1047, 571);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 16 | Зайцев Я.А. ПКТб-24-1";
            panelTop_ZYА.ResumeLayout(false);
            groupBoxInput_ZYА.ResumeLayout(false);
            groupBoxInput_ZYА.PerformLayout();
            groupBoxOutput_ZYА.ResumeLayout(false);
            groupBoxOutput_ZYА.PerformLayout();
            panelBottom_ZYА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZYА).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop_ZYА;
        private System.Windows.Forms.GroupBox groupBoxInput_ZYА;
        private System.Windows.Forms.TextBox textBoxStop_ZYА;
        private System.Windows.Forms.Label labelStop_ZYА;
        private System.Windows.Forms.TextBox textBoxStart_ZYА;
        private System.Windows.Forms.Label labelStart_ZYА;
        private System.Windows.Forms.GroupBox groupBoxOutput_ZYА;
        private System.Windows.Forms.TextBox textBoxResult_ZYА;
        private System.Windows.Forms.Panel panelBottom_ZYА;
        private System.Windows.Forms.Button buttonHelp_ZYА;
        private System.Windows.Forms.Button buttonDone_ZYА;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZYА;
    }
}