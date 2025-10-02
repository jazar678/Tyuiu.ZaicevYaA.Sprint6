namespace Tyuiu.ZaicevYaA.Sprint6.Task2.V15
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
            groupBoxInput_ZYA = new GroupBox();
            textBoxStopStep_ZYA = new TextBox();
            textBoxStartStep_ZYA = new TextBox();
            labelStopStep_ZYA = new Label();
            labelStartStep_ZYA = new Label();
            groupBoxOutput_ZYA = new GroupBox();
            dataGridViewResult_ZYA = new DataGridView();
            ColumnX_ZYA = new DataGridViewTextBoxColumn();
            ColumnFx_ZYA = new DataGridViewTextBoxColumn();
            chartFunction_ZYA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelButtons_ZYA = new Panel();
            buttonHelp_ZYA = new Button();
            buttonDone_ZYA = new Button();
            groupBoxInput_ZYA.SuspendLayout();
            groupBoxOutput_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZYA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZYA).BeginInit();
            panelButtons_ZYA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInput_ZYA
            // 
            groupBoxInput_ZYA.Controls.Add(textBoxStopStep_ZYA);
            groupBoxInput_ZYA.Controls.Add(textBoxStartStep_ZYA);
            groupBoxInput_ZYA.Controls.Add(labelStopStep_ZYA);
            groupBoxInput_ZYA.Controls.Add(labelStartStep_ZYA);
            groupBoxInput_ZYA.Location = new Point(14, 14);
            groupBoxInput_ZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_ZYA.Name = "groupBoxInput_ZYA";
            groupBoxInput_ZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_ZYA.Size = new Size(350, 115);
            groupBoxInput_ZYA.TabIndex = 0;
            groupBoxInput_ZYA.TabStop = false;
            groupBoxInput_ZYA.Text = "Ввод данных";
            // 
            // textBoxStopStep_ZYA
            // 
            textBoxStopStep_ZYA.Location = new Point(175, 69);
            textBoxStopStep_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxStopStep_ZYA.Name = "textBoxStopStep_ZYA";
            textBoxStopStep_ZYA.Size = new Size(116, 23);
            textBoxStopStep_ZYA.TabIndex = 3;
            textBoxStopStep_ZYA.Text = "5";
            // 
            // textBoxStartStep_ZYA
            // 
            textBoxStartStep_ZYA.Location = new Point(175, 29);
            textBoxStartStep_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxStartStep_ZYA.Name = "textBoxStartStep_ZYA";
            textBoxStartStep_ZYA.Size = new Size(116, 23);
            textBoxStartStep_ZYA.TabIndex = 2;
            textBoxStartStep_ZYA.Text = "-5";
            // 
            // labelStopStep_ZYA
            // 
            labelStopStep_ZYA.AutoSize = true;
            labelStopStep_ZYA.Location = new Point(23, 73);
            labelStopStep_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelStopStep_ZYA.Name = "labelStopStep_ZYA";
            labelStopStep_ZYA.Size = new Size(75, 15);
            labelStopStep_ZYA.TabIndex = 1;
            labelStopStep_ZYA.Text = "Конец шага:";
            // 
            // labelStartStep_ZYA
            // 
            labelStartStep_ZYA.AutoSize = true;
            labelStartStep_ZYA.Location = new Point(23, 32);
            labelStartStep_ZYA.Margin = new Padding(4, 0, 4, 0);
            labelStartStep_ZYA.Name = "labelStartStep_ZYA";
            labelStartStep_ZYA.Size = new Size(72, 15);
            labelStartStep_ZYA.TabIndex = 0;
            labelStartStep_ZYA.Text = "Старт шага:";
            // 
            // groupBoxOutput_ZYA
            // 
            groupBoxOutput_ZYA.Controls.Add(dataGridViewResult_ZYA);
            groupBoxOutput_ZYA.Location = new Point(385, 14);
            groupBoxOutput_ZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_ZYA.Name = "groupBoxOutput_ZYA";
            groupBoxOutput_ZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_ZYA.Size = new Size(350, 462);
            groupBoxOutput_ZYA.TabIndex = 1;
            groupBoxOutput_ZYA.TabStop = false;
            groupBoxOutput_ZYA.Text = "Вывод данных";
            // 
            // dataGridViewResult_ZYA
            // 
            dataGridViewResult_ZYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_ZYA.Columns.AddRange(new DataGridViewColumn[] { ColumnX_ZYA, ColumnFx_ZYA });
            dataGridViewResult_ZYA.Location = new Point(12, 23);
            dataGridViewResult_ZYA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewResult_ZYA.Name = "dataGridViewResult_ZYA";
            dataGridViewResult_ZYA.Size = new Size(327, 427);
            dataGridViewResult_ZYA.TabIndex = 0;
            // 
            // ColumnX_ZYA
            // 
            ColumnX_ZYA.HeaderText = "X";
            ColumnX_ZYA.Name = "ColumnX_ZYA";
            ColumnX_ZYA.Width = 120;
            // 
            // ColumnFx_ZYA
            // 
            ColumnFx_ZYA.HeaderText = "F(x)";
            ColumnFx_ZYA.Name = "ColumnFx_ZYA";
            ColumnFx_ZYA.Width = 120;
            // 
            // chartFunction_ZYA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_ZYA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_ZYA.Legends.Add(legend1);
            chartFunction_ZYA.Location = new Point(14, 150);
            chartFunction_ZYA.Margin = new Padding(4, 3, 4, 3);
            chartFunction_ZYA.Name = "chartFunction_ZYA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_ZYA.Series.Add(series1);
            chartFunction_ZYA.Size = new Size(350, 288);
            chartFunction_ZYA.TabIndex = 2;
            chartFunction_ZYA.Text = "chart1";
            // 
            // panelButtons_ZYA
            // 
            panelButtons_ZYA.Controls.Add(buttonHelp_ZYA);
            panelButtons_ZYA.Controls.Add(buttonDone_ZYA);
            panelButtons_ZYA.Location = new Point(14, 450);
            panelButtons_ZYA.Margin = new Padding(4, 3, 4, 3);
            panelButtons_ZYA.Name = "panelButtons_ZYA";
            panelButtons_ZYA.Size = new Size(350, 58);
            panelButtons_ZYA.TabIndex = 3;
            // 
            // buttonHelp_ZYA
            // 
            buttonHelp_ZYA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_ZYA.Location = new Point(175, 12);
            buttonHelp_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            buttonHelp_ZYA.Size = new Size(117, 35);
            buttonHelp_ZYA.TabIndex = 1;
            buttonHelp_ZYA.Text = "Справка";
            buttonHelp_ZYA.UseVisualStyleBackColor = false;
            buttonHelp_ZYA.Click += buttonHelp_ZYA_Click;
            // 
            // buttonDone_ZYA
            // 
            buttonDone_ZYA.BackColor = Color.Green;
            buttonDone_ZYA.Location = new Point(35, 12);
            buttonDone_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonDone_ZYA.Name = "buttonDone_ZYA";
            buttonDone_ZYA.Size = new Size(117, 35);
            buttonDone_ZYA.TabIndex = 0;
            buttonDone_ZYA.Text = "Выполнить";
            buttonDone_ZYA.UseVisualStyleBackColor = false;
            buttonDone_ZYA.Click += buttonDone_ZYA_Click;
            buttonDone_ZYA.MouseEnter += buttonDone_ZYA_MouseEnter;
            buttonDone_ZYA.MouseLeave += buttonDone_ZYA_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 520);
            Controls.Add(panelButtons_ZYA);
            Controls.Add(chartFunction_ZYA);
            Controls.Add(groupBoxOutput_ZYA);
            Controls.Add(groupBoxInput_ZYA);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(767, 559);
            MinimizeBox = false;
            MinimumSize = new Size(767, 559);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 15 | Зайцев Я.А.";
            groupBoxInput_ZYA.ResumeLayout(false);
            groupBoxInput_ZYA.PerformLayout();
            groupBoxOutput_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZYA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZYA).EndInit();
            panelButtons_ZYA.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput_ZYA;
        private System.Windows.Forms.TextBox textBoxStopStep_ZYA;
        private System.Windows.Forms.TextBox textBoxStartStep_ZYA;
        private System.Windows.Forms.Label labelStopStep_ZYA;
        private System.Windows.Forms.Label labelStartStep_ZYA;
        private System.Windows.Forms.GroupBox groupBoxOutput_ZYA;
        private System.Windows.Forms.DataGridView dataGridViewResult_ZYA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_ZYA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx_ZYA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZYA;
        private System.Windows.Forms.Panel panelButtons_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
    }
}