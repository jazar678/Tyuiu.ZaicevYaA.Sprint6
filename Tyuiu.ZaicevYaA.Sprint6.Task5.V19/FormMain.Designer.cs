namespace Tyuiu.ZaicevYaA.Sprint6.Task5.V19
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
            panelTop_ZA = new Panel();
            groupBoxTask_ZA = new GroupBox();
            textBoxTask_ZA = new TextBox();
            panelMid_ZA = new Panel();
            splitContainer_ZA = new SplitContainer();
            dataGridViewNums_ZA = new DataGridView();
            chartFunction_ZA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelBottom_ZA = new Panel();
            buttonDone_ZA = new Button();
            buttonOpenFile_ZA = new Button();
            buttonHelp_ZA = new Button();
            panelTop_ZA.SuspendLayout();
            groupBoxTask_ZA.SuspendLayout();
            panelMid_ZA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_ZA).BeginInit();
            splitContainer_ZA.Panel1.SuspendLayout();
            splitContainer_ZA.Panel2.SuspendLayout();
            splitContainer_ZA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_ZA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZA).BeginInit();
            panelBottom_ZA.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_ZA
            // 
            panelTop_ZA.Controls.Add(groupBoxTask_ZA);
            panelTop_ZA.Dock = DockStyle.Top;
            panelTop_ZA.Location = new Point(0, 0);
            panelTop_ZA.Margin = new Padding(4, 3, 4, 3);
            panelTop_ZA.Name = "panelTop_ZA";
            panelTop_ZA.Size = new Size(933, 115);
            panelTop_ZA.TabIndex = 0;
            // 
            // groupBoxTask_ZA
            // 
            groupBoxTask_ZA.Controls.Add(textBoxTask_ZA);
            groupBoxTask_ZA.Location = new Point(14, 14);
            groupBoxTask_ZA.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_ZA.Name = "groupBoxTask_ZA";
            groupBoxTask_ZA.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_ZA.Size = new Size(905, 88);
            groupBoxTask_ZA.TabIndex = 0;
            groupBoxTask_ZA.TabStop = false;
            groupBoxTask_ZA.Text = "Условие";
            // 
            // textBoxTask_ZA
            // 
            textBoxTask_ZA.BorderStyle = BorderStyle.None;
            textBoxTask_ZA.Dock = DockStyle.Fill;
            textBoxTask_ZA.Location = new Point(4, 19);
            textBoxTask_ZA.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_ZA.Multiline = true;
            textBoxTask_ZA.Name = "textBoxTask_ZA";
            textBoxTask_ZA.ReadOnly = true;
            textBoxTask_ZA.Size = new Size(897, 66);
            textBoxTask_ZA.TabIndex = 0;
            textBoxTask_ZA.Text = "Прочитать данные из файла InPutFileTask5V19.txt. Вывести в dataGridView. Вывести все целые числа. Построить диаграмму по этим значениям.";
            // 
            // panelMid_ZA
            // 
            panelMid_ZA.Controls.Add(splitContainer_ZA);
            panelMid_ZA.Dock = DockStyle.Fill;
            panelMid_ZA.Location = new Point(0, 115);
            panelMid_ZA.Margin = new Padding(4, 3, 4, 3);
            panelMid_ZA.Name = "panelMid_ZA";
            panelMid_ZA.Size = new Size(933, 346);
            panelMid_ZA.TabIndex = 1;
            // 
            // splitContainer_ZA
            // 
            splitContainer_ZA.Dock = DockStyle.Fill;
            splitContainer_ZA.Location = new Point(0, 0);
            splitContainer_ZA.Margin = new Padding(4, 3, 4, 3);
            splitContainer_ZA.Name = "splitContainer_ZA";
            // 
            // splitContainer_ZA.Panel1
            // 
            splitContainer_ZA.Panel1.Controls.Add(dataGridViewNums_ZA);
            // 
            // splitContainer_ZA.Panel2
            // 
            splitContainer_ZA.Panel2.Controls.Add(chartFunction_ZA);
            splitContainer_ZA.Size = new Size(933, 346);
            splitContainer_ZA.SplitterDistance = 310;
            splitContainer_ZA.SplitterWidth = 5;
            splitContainer_ZA.TabIndex = 0;
            // 
            // dataGridViewNums_ZA
            // 
            dataGridViewNums_ZA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_ZA.Dock = DockStyle.Fill;
            dataGridViewNums_ZA.Location = new Point(0, 0);
            dataGridViewNums_ZA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewNums_ZA.Name = "dataGridViewNums_ZA";
            dataGridViewNums_ZA.Size = new Size(310, 346);
            dataGridViewNums_ZA.TabIndex = 0;
            // 
            // chartFunction_ZA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_ZA.ChartAreas.Add(chartArea1);
            chartFunction_ZA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_ZA.Legends.Add(legend1);
            chartFunction_ZA.Location = new Point(0, 0);
            chartFunction_ZA.Margin = new Padding(4, 3, 4, 3);
            chartFunction_ZA.Name = "chartFunction_ZA";
            chartFunction_ZA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_ZA.Series.Add(series1);
            chartFunction_ZA.Size = new Size(618, 346);
            chartFunction_ZA.TabIndex = 0;
            chartFunction_ZA.Text = "chart1";
            // 
            // panelBottom_ZA
            // 
            panelBottom_ZA.Controls.Add(buttonDone_ZA);
            panelBottom_ZA.Controls.Add(buttonOpenFile_ZA);
            panelBottom_ZA.Controls.Add(buttonHelp_ZA);
            panelBottom_ZA.Dock = DockStyle.Bottom;
            panelBottom_ZA.Location = new Point(0, 461);
            panelBottom_ZA.Margin = new Padding(4, 3, 4, 3);
            panelBottom_ZA.Name = "panelBottom_ZA";
            panelBottom_ZA.Size = new Size(933, 58);
            panelBottom_ZA.TabIndex = 2;
            // 
            // buttonDone_ZA
            // 
            buttonDone_ZA.BackColor = Color.Cyan;
            buttonDone_ZA.Location = new Point(632, 17);
            buttonDone_ZA.Margin = new Padding(4, 3, 4, 3);
            buttonDone_ZA.Name = "buttonDone_ZA";
            buttonDone_ZA.Size = new Size(88, 27);
            buttonDone_ZA.TabIndex = 2;
            buttonDone_ZA.Text = "Выполнить";
            buttonDone_ZA.UseVisualStyleBackColor = false;
            buttonDone_ZA.Click += buttonDone_ZA_Click;
            // 
            // buttonOpenFile_ZA
            // 
            buttonOpenFile_ZA.BackColor = Color.Brown;
            buttonOpenFile_ZA.Location = new Point(727, 17);
            buttonOpenFile_ZA.Margin = new Padding(4, 3, 4, 3);
            buttonOpenFile_ZA.Name = "buttonOpenFile_ZA";
            buttonOpenFile_ZA.Size = new Size(88, 27);
            buttonOpenFile_ZA.TabIndex = 1;
            buttonOpenFile_ZA.Text = "Открыть файл";
            buttonOpenFile_ZA.UseVisualStyleBackColor = false;
            buttonOpenFile_ZA.Click += buttonOpenFile_ZA_Click;
            // 
            // buttonHelp_ZA
            // 
            buttonHelp_ZA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_ZA.Location = new Point(821, 17);
            buttonHelp_ZA.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_ZA.Name = "buttonHelp_ZA";
            buttonHelp_ZA.Size = new Size(88, 27);
            buttonHelp_ZA.TabIndex = 0;
            buttonHelp_ZA.Text = "Справка";
            buttonHelp_ZA.UseVisualStyleBackColor = false;
            buttonHelp_ZA.Click += buttonHelp_ZA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelMid_ZA);
            Controls.Add(panelTop_ZA);
            Controls.Add(panelBottom_ZA);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 19 | Зайцев Я.А.";
            panelTop_ZA.ResumeLayout(false);
            groupBoxTask_ZA.ResumeLayout(false);
            groupBoxTask_ZA.PerformLayout();
            panelMid_ZA.ResumeLayout(false);
            splitContainer_ZA.Panel1.ResumeLayout(false);
            splitContainer_ZA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_ZA).EndInit();
            splitContainer_ZA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_ZA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZA).EndInit();
            panelBottom_ZA.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_ZA;
        private System.Windows.Forms.GroupBox groupBoxTask_ZA;
        private System.Windows.Forms.TextBox textBoxTask_ZA;
        private System.Windows.Forms.Panel panelMid_ZA;
        private System.Windows.Forms.SplitContainer splitContainer_ZA;
        private System.Windows.Forms.DataGridView dataGridViewNums_ZA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZA;
        private System.Windows.Forms.Panel panelBottom_ZA;
        private System.Windows.Forms.Button buttonDone_ZA;
        private System.Windows.Forms.Button buttonOpenFile_ZA;
        private System.Windows.Forms.Button buttonHelp_ZA;
    }
}