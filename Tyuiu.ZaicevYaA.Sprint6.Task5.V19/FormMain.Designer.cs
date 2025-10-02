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
            panelTop_ZYA = new Panel();
            groupBoxInput_ZYA = new GroupBox();
            buttonHelp_ZYA = new Button();
            buttonDone_ZYA = new Button();
            buttonOpenFile_ZYA = new Button();
            textBoxPath_ZYA = new TextBox();
            panelBottom_ZYA = new Panel();
            chartDiag_ZYA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            dataGridViewNums_ZYA = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panelTop_ZYA.SuspendLayout();
            groupBoxInput_ZYA.SuspendLayout();
            panelBottom_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_ZYA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_ZYA).BeginInit();
            SuspendLayout();
            // 
            // panelTop_ZYA
            // 
            panelTop_ZYA.Controls.Add(groupBoxInput_ZYA);
            panelTop_ZYA.Dock = DockStyle.Top;
            panelTop_ZYA.Location = new Point(0, 0);
            panelTop_ZYA.Margin = new Padding(4, 3, 4, 3);
            panelTop_ZYA.Name = "panelTop_ZYA";
            panelTop_ZYA.Size = new Size(933, 92);
            panelTop_ZYA.TabIndex = 0;
            // 
            // groupBoxInput_ZYA
            // 
            groupBoxInput_ZYA.Controls.Add(buttonHelp_ZYA);
            groupBoxInput_ZYA.Controls.Add(buttonDone_ZYA);
            groupBoxInput_ZYA.Controls.Add(buttonOpenFile_ZYA);
            groupBoxInput_ZYA.Controls.Add(textBoxPath_ZYA);
            groupBoxInput_ZYA.Location = new Point(14, 14);
            groupBoxInput_ZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_ZYA.Name = "groupBoxInput_ZYA";
            groupBoxInput_ZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_ZYA.Size = new Size(905, 65);
            groupBoxInput_ZYA.TabIndex = 0;
            groupBoxInput_ZYA.TabStop = false;
            groupBoxInput_ZYA.Text = "Условие: Прочитать данные из файла InPutFileTask5V19.txt. Вывести в dataGridView все целые числа. Построить диаграмму по этим значениям.";
            // 
            // buttonHelp_ZYA
            // 
            buttonHelp_ZYA.Location = new Point(620, 22);
            buttonHelp_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            buttonHelp_ZYA.Size = new Size(88, 27);
            buttonHelp_ZYA.TabIndex = 3;
            buttonHelp_ZYA.Text = "Справка";
            buttonHelp_ZYA.UseVisualStyleBackColor = true;
            buttonHelp_ZYA.Click += buttonHelp_ZYA_Click;
            // 
            // buttonDone_ZYA
            // 
            buttonDone_ZYA.Location = new Point(525, 22);
            buttonDone_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonDone_ZYA.Name = "buttonDone_ZYA";
            buttonDone_ZYA.Size = new Size(88, 27);
            buttonDone_ZYA.TabIndex = 2;
            buttonDone_ZYA.Text = "Вывести";
            buttonDone_ZYA.UseVisualStyleBackColor = true;
            buttonDone_ZYA.Click += buttonDone_ZYA_Click;
            // 
            // buttonOpenFile_ZYA
            // 
            buttonOpenFile_ZYA.Location = new Point(430, 22);
            buttonOpenFile_ZYA.Margin = new Padding(4, 3, 4, 3);
            buttonOpenFile_ZYA.Name = "buttonOpenFile_ZYA";
            buttonOpenFile_ZYA.Size = new Size(88, 27);
            buttonOpenFile_ZYA.TabIndex = 1;
            buttonOpenFile_ZYA.Text = "Открыть файл";
            buttonOpenFile_ZYA.UseVisualStyleBackColor = true;
            buttonOpenFile_ZYA.Click += buttonOpenFile_ZYA_Click;
            // 
            // textBoxPath_ZYA
            // 
            textBoxPath_ZYA.Location = new Point(7, 24);
            textBoxPath_ZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxPath_ZYA.Name = "textBoxPath_ZYA";
            textBoxPath_ZYA.ReadOnly = true;
            textBoxPath_ZYA.Size = new Size(416, 23);
            textBoxPath_ZYA.TabIndex = 0;
            textBoxPath_ZYA.Text = "C:\\DataSprint6\\InPutFileTask5V19.txt";
            // 
            // panelBottom_ZYA
            // 
            panelBottom_ZYA.Controls.Add(chartDiag_ZYA);
            panelBottom_ZYA.Controls.Add(splitter1);
            panelBottom_ZYA.Controls.Add(dataGridViewNums_ZYA);
            panelBottom_ZYA.Dock = DockStyle.Fill;
            panelBottom_ZYA.Location = new Point(0, 92);
            panelBottom_ZYA.Margin = new Padding(4, 3, 4, 3);
            panelBottom_ZYA.Name = "panelBottom_ZYA";
            panelBottom_ZYA.Size = new Size(933, 427);
            panelBottom_ZYA.TabIndex = 1;
            // 
            // chartDiag_ZYA
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_ZYA.ChartAreas.Add(chartArea1);
            chartDiag_ZYA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag_ZYA.Legends.Add(legend1);
            chartDiag_ZYA.Location = new Point(237, 0);
            chartDiag_ZYA.Margin = new Padding(4, 3, 4, 3);
            chartDiag_ZYA.Name = "chartDiag_ZYA";
            chartDiag_ZYA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Целые числа";
            chartDiag_ZYA.Series.Add(series1);
            chartDiag_ZYA.Size = new Size(696, 427);
            chartDiag_ZYA.TabIndex = 2;
            chartDiag_ZYA.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(233, 0);
            splitter1.Margin = new Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 427);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // dataGridViewNums_ZYA
            // 
            dataGridViewNums_ZYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_ZYA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewNums_ZYA.Dock = DockStyle.Left;
            dataGridViewNums_ZYA.Location = new Point(0, 0);
            dataGridViewNums_ZYA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewNums_ZYA.Name = "dataGridViewNums_ZYA";
            dataGridViewNums_ZYA.Size = new Size(233, 427);
            dataGridViewNums_ZYA.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "№";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Значение";
            Column2.Name = "Column2";
            Column2.Width = 80;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelBottom_ZYA);
            Controls.Add(panelTop_ZYA);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 19 | Зайцев Я. А.";
            Load += FormMain_Load;
            panelTop_ZYA.ResumeLayout(false);
            groupBoxInput_ZYA.ResumeLayout(false);
            groupBoxInput_ZYA.PerformLayout();
            panelBottom_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_ZYA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_ZYA).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_ZYA;
        private System.Windows.Forms.GroupBox groupBoxInput_ZYA;
        private System.Windows.Forms.Button buttonHelp_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
        private System.Windows.Forms.Button buttonOpenFile_ZYA;
        private System.Windows.Forms.TextBox textBoxPath_ZYA;
        private System.Windows.Forms.Panel panelBottom_ZYA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_ZYA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewNums_ZYA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}