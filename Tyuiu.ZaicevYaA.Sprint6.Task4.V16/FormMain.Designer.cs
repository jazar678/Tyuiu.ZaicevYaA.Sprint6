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
            panelTop_ZY = new Panel();
            groupBoxInput_ZY = new GroupBox();
            textBoxStop_ZY = new TextBox();
            labelStop_ZY = new Label();
            textBoxStart_ZY = new TextBox();
            labelStart_ZY = new Label();
            groupBoxOutput_ZY = new GroupBox();
            textBoxResult_ZY = new TextBox();
            panelBottom_ZY = new Panel();
            buttonHelp_ZY = new Button();
            buttonSave_ZY = new Button();
            buttonDone_ZY = new Button();
            chartFunction_ZY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_ZY.SuspendLayout();
            groupBoxInput_ZY.SuspendLayout();
            groupBoxOutput_ZY.SuspendLayout();
            panelBottom_ZY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZY).BeginInit();
            SuspendLayout();
            // 
            // panelTop_ZY
            // 
            panelTop_ZY.Controls.Add(groupBoxInput_ZY);
            panelTop_ZY.Controls.Add(groupBoxOutput_ZY);
            panelTop_ZY.Dock = DockStyle.Top;
            panelTop_ZY.Location = new Point(0, 0);
            panelTop_ZY.Name = "panelTop_ZY";
            panelTop_ZY.Size = new Size(702, 188);
            panelTop_ZY.TabIndex = 0;
            // 
            // groupBoxInput_ZY
            // 
            groupBoxInput_ZY.Controls.Add(textBoxStop_ZY);
            groupBoxInput_ZY.Controls.Add(labelStop_ZY);
            groupBoxInput_ZY.Controls.Add(textBoxStart_ZY);
            groupBoxInput_ZY.Controls.Add(labelStart_ZY);
            groupBoxInput_ZY.Location = new Point(10, 11);
            groupBoxInput_ZY.Name = "groupBoxInput_ZY";
            groupBoxInput_ZY.Size = new Size(262, 164);
            groupBoxInput_ZY.TabIndex = 0;
            groupBoxInput_ZY.TabStop = false;
            groupBoxInput_ZY.Text = "Ввод данных";
            // 
            // textBoxStop_ZY
            // 
            textBoxStop_ZY.Location = new Point(131, 75);
            textBoxStop_ZY.Name = "textBoxStop_ZY";
            textBoxStop_ZY.Size = new Size(88, 23);
            textBoxStop_ZY.TabIndex = 3;
            textBoxStop_ZY.Text = "5";
            // 
            // labelStop_ZY
            // 
            labelStop_ZY.AutoSize = true;
            labelStop_ZY.Location = new Point(18, 78);
            labelStop_ZY.Name = "labelStop_ZY";
            labelStop_ZY.Size = new Size(109, 15);
            labelStop_ZY.TabIndex = 2;
            labelStop_ZY.Text = "Конец шага (stop):";
            // 
            // textBoxStart_ZY
            // 
            textBoxStart_ZY.Location = new Point(131, 38);
            textBoxStart_ZY.Name = "textBoxStart_ZY";
            textBoxStart_ZY.Size = new Size(88, 23);
            textBoxStart_ZY.TabIndex = 1;
            textBoxStart_ZY.Text = "-5";
            // 
            // labelStart_ZY
            // 
            labelStart_ZY.AutoSize = true;
            labelStart_ZY.Location = new Point(18, 40);
            labelStart_ZY.Name = "labelStart_ZY";
            labelStart_ZY.Size = new Size(106, 15);
            labelStart_ZY.TabIndex = 0;
            labelStart_ZY.Text = "Старт шага (start):";
            // 
            // groupBoxOutput_ZY
            // 
            groupBoxOutput_ZY.Controls.Add(textBoxResult_ZY);
            groupBoxOutput_ZY.Location = new Point(289, 11);
            groupBoxOutput_ZY.Name = "groupBoxOutput_ZY";
            groupBoxOutput_ZY.Size = new Size(401, 164);
            groupBoxOutput_ZY.TabIndex = 1;
            groupBoxOutput_ZY.TabStop = false;
            groupBoxOutput_ZY.Text = "Вывод данных";
            // 
            // textBoxResult_ZY
            // 
            textBoxResult_ZY.Dock = DockStyle.Fill;
            textBoxResult_ZY.Location = new Point(3, 19);
            textBoxResult_ZY.Multiline = true;
            textBoxResult_ZY.Name = "textBoxResult_ZY";
            textBoxResult_ZY.ReadOnly = true;
            textBoxResult_ZY.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ZY.Size = new Size(395, 142);
            textBoxResult_ZY.TabIndex = 0;
            // 
            // panelBottom_ZY
            // 
            panelBottom_ZY.Controls.Add(buttonHelp_ZY);
            panelBottom_ZY.Controls.Add(buttonSave_ZY);
            panelBottom_ZY.Controls.Add(buttonDone_ZY);
            panelBottom_ZY.Dock = DockStyle.Bottom;
            panelBottom_ZY.Location = new Point(0, 382);
            panelBottom_ZY.Name = "panelBottom_ZY";
            panelBottom_ZY.Size = new Size(702, 47);
            panelBottom_ZY.TabIndex = 1;
            // 
            // buttonHelp_ZY
            // 
            buttonHelp_ZY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_ZY.BackColor = SystemColors.ActiveCaption;
            buttonHelp_ZY.Location = new Point(626, 14);
            buttonHelp_ZY.Name = "buttonHelp_ZY";
            buttonHelp_ZY.Size = new Size(66, 22);
            buttonHelp_ZY.TabIndex = 2;
            buttonHelp_ZY.Text = "Справка";
            buttonHelp_ZY.UseVisualStyleBackColor = false;
            buttonHelp_ZY.Click += buttonHelp_ZY_Click;
            // 
            // buttonSave_ZY
            // 
            buttonSave_ZY.BackColor = Color.FromArgb(255, 224, 192);
            buttonSave_ZY.Enabled = false;
            buttonSave_ZY.Location = new Point(82, 14);
            buttonSave_ZY.Name = "buttonSave_ZY";
            buttonSave_ZY.Size = new Size(66, 22);
            buttonSave_ZY.TabIndex = 1;
            buttonSave_ZY.Text = "Сохранить";
            buttonSave_ZY.UseVisualStyleBackColor = false;
            buttonSave_ZY.Click += buttonSave_ZY_Click;
            // 
            // buttonDone_ZY
            // 
            buttonDone_ZY.BackColor = Color.Green;
            buttonDone_ZY.Location = new Point(11, 14);
            buttonDone_ZY.Name = "buttonDone_ZY";
            buttonDone_ZY.Size = new Size(66, 22);
            buttonDone_ZY.TabIndex = 0;
            buttonDone_ZY.Text = "Выполнить";
            buttonDone_ZY.UseVisualStyleBackColor = false;
            buttonDone_ZY.Click += buttonDone_ZY_Click;
            // 
            // chartFunction_ZY
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_ZY.ChartAreas.Add(chartArea1);
            chartFunction_ZY.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_ZY.Legends.Add(legend1);
            chartFunction_ZY.Location = new Point(0, 188);
            chartFunction_ZY.Name = "chartFunction_ZY";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            chartFunction_ZY.Series.Add(series1);
            chartFunction_ZY.Size = new Size(702, 194);
            chartFunction_ZY.TabIndex = 2;
            chartFunction_ZY.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 429);
            Controls.Add(chartFunction_ZY);
            Controls.Add(panelBottom_ZY);
            Controls.Add(panelTop_ZY);
            MinimumSize = new Size(718, 468);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 16 | Зайцев Я.А.";
            panelTop_ZY.ResumeLayout(false);
            groupBoxInput_ZY.ResumeLayout(false);
            groupBoxInput_ZY.PerformLayout();
            groupBoxOutput_ZY.ResumeLayout(false);
            groupBoxOutput_ZY.PerformLayout();
            panelBottom_ZY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZY).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_ZY;
        private System.Windows.Forms.GroupBox groupBoxInput_ZY;
        private System.Windows.Forms.TextBox textBoxStop_ZY;
        private System.Windows.Forms.Label labelStop_ZY;
        private System.Windows.Forms.TextBox textBoxStart_ZY;
        private System.Windows.Forms.Label labelStart_ZY;
        private System.Windows.Forms.GroupBox groupBoxOutput_ZY;
        private System.Windows.Forms.TextBox textBoxResult_ZY;
        private System.Windows.Forms.Panel panelBottom_ZY;
        private System.Windows.Forms.Button buttonHelp_ZY;
        private System.Windows.Forms.Button buttonSave_ZY;
        private System.Windows.Forms.Button buttonDone_ZY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZY;
    }
}