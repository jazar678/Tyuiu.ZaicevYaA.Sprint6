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
            this.panelTop_ZA = new System.Windows.Forms.Panel();
            this.groupBoxTask_ZA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZA = new System.Windows.Forms.TextBox();
            this.panelMid_ZA = new System.Windows.Forms.Panel();
            this.splitContainer_ZA = new System.Windows.Forms.SplitContainer();
            this.dataGridViewNums_ZA = new System.Windows.Forms.DataGridView();
            this.chartFunction_ZA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelBottom_ZA = new System.Windows.Forms.Panel();
            this.buttonDone_ZA = new System.Windows.Forms.Button();
            this.buttonOpenFile_ZA = new System.Windows.Forms.Button();
            this.buttonHelp_ZA = new System.Windows.Forms.Button();
            this.panelTop_ZA.SuspendLayout();
            this.groupBoxTask_ZA.SuspendLayout();
            this.panelMid_ZA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_ZA)).BeginInit();
            this.splitContainer_ZA.Panel1.SuspendLayout();
            this.splitContainer_ZA.Panel2.SuspendLayout();
            this.splitContainer_ZA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_ZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZA)).BeginInit();
            this.panelBottom_ZA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_ZA
            // 
            this.panelTop_ZA.Controls.Add(this.groupBoxTask_ZA);
            this.panelTop_ZA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_ZA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_ZA.Name = "panelTop_ZA";
            this.panelTop_ZA.Size = new System.Drawing.Size(800, 100);
            this.panelTop_ZA.TabIndex = 0;
            // 
            // groupBoxTask_ZA
            // 
            this.groupBoxTask_ZA.Controls.Add(this.textBoxTask_ZA);
            this.groupBoxTask_ZA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ZA.Name = "groupBoxTask_ZA";
            this.groupBoxTask_ZA.Size = new System.Drawing.Size(776, 76);
            this.groupBoxTask_ZA.TabIndex = 0;
            this.groupBoxTask_ZA.TabStop = false;
            this.groupBoxTask_ZA.Text = "Условие";
            // 
            // textBoxTask_ZA
            // 
            this.textBoxTask_ZA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ZA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ZA.Multiline = true;
            this.textBoxTask_ZA.Name = "textBoxTask_ZA";
            this.textBoxTask_ZA.ReadOnly = true;
            this.textBoxTask_ZA.Size = new System.Drawing.Size(770, 57);
            this.textBoxTask_ZA.TabIndex = 0;
            this.textBoxTask_ZA.Text = "Прочитать данные из файла InPutFileTask5V19.txt. Вывести в dataGridView. Вывести " +
    "все целые числа. Построить диаграмму по этим значениям.";
            // 
            // panelMid_ZA
            // 
            this.panelMid_ZA.Controls.Add(this.splitContainer_ZA);
            this.panelMid_ZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid_ZA.Location = new System.Drawing.Point(0, 100);
            this.panelMid_ZA.Name = "panelMid_ZA";
            this.panelMid_ZA.Size = new System.Drawing.Size(800, 300);
            this.panelMid_ZA.TabIndex = 1;
            // 
            // splitContainer_ZA
            // 
            this.splitContainer_ZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_ZA.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_ZA.Name = "splitContainer_ZA";
            // 
            // splitContainer_ZA.Panel1
            // 
            this.splitContainer_ZA.Panel1.Controls.Add(this.dataGridViewNums_ZA);
            // 
            // splitContainer_ZA.Panel2
            // 
            this.splitContainer_ZA.Panel2.Controls.Add(this.chartFunction_ZA);
            this.splitContainer_ZA.Size = new System.Drawing.Size(800, 300);
            this.splitContainer_ZA.SplitterDistance = 266;
            this.splitContainer_ZA.TabIndex = 0;
            // 
            // dataGridViewNums_ZA
            // 
            this.dataGridViewNums_ZA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_ZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_ZA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewNums_ZA.Name = "dataGridViewNums_ZA";
            this.dataGridViewNums_ZA.Size = new System.Drawing.Size(266, 300);
            this.dataGridViewNums_ZA.TabIndex = 0;
            // 
            // chartFunction_ZA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_ZA.ChartAreas.Add(chartArea1);
            this.chartFunction_ZA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_ZA.Legends.Add(legend1);
            this.chartFunction_ZA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_ZA.Name = "chartFunction_ZA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_ZA.Series.Add(series1);
            this.chartFunction_ZA.Size = new System.Drawing.Size(530, 300);
            this.chartFunction_ZA.TabIndex = 0;
            this.chartFunction_ZA.Text = "chart1";
            // 
            // panelBottom_ZA
            // 
            this.panelBottom_ZA.Controls.Add(this.buttonDone_ZA);
            this.panelBottom_ZA.Controls.Add(this.buttonOpenFile_ZA);
            this.panelBottom_ZA.Controls.Add(this.buttonHelp_ZA);
            this.panelBottom_ZA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom_ZA.Location = new System.Drawing.Point(0, 400);
            this.panelBottom_ZA.Name = "panelBottom_ZA";
            this.panelBottom_ZA.Size = new System.Drawing.Size(800, 50);
            this.panelBottom_ZA.TabIndex = 2;
            // 
            // buttonDone_ZA
            // 
            this.buttonDone_ZA.Location = new System.Drawing.Point(542, 15);
            this.buttonDone_ZA.Name = "buttonDone_ZA";
            this.buttonDone_ZA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_ZA.TabIndex = 2;
            this.buttonDone_ZA.Text = "Выполнить";
            this.buttonDone_ZA.UseVisualStyleBackColor = true;
            this.buttonDone_ZA.Click += new System.EventHandler(this.buttonDone_ZA_Click);
            // 
            // buttonOpenFile_ZA
            // 
            this.buttonOpenFile_ZA.Location = new System.Drawing.Point(623, 15);
            this.buttonOpenFile_ZA.Name = "buttonOpenFile_ZA";
            this.buttonOpenFile_ZA.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile_ZA.TabIndex = 1;
            this.buttonOpenFile_ZA.Text = "Открыть файл";
            this.buttonOpenFile_ZA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZA.Click += new System.EventHandler(this.buttonOpenFile_ZA_Click);
            // 
            // buttonHelp_ZA
            // 
            this.buttonHelp_ZA.Location = new System.Drawing.Point(704, 15);
            this.buttonHelp_ZA.Name = "buttonHelp_ZA";
            this.buttonHelp_ZA.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp_ZA.TabIndex = 0;
            this.buttonHelp_ZA.Text = "Справка";
            this.buttonHelp_ZA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZA.Click += new System.EventHandler(this.buttonHelp_ZA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMid_ZA);
            this.Controls.Add(this.panelTop_ZA);
            this.Controls.Add(this.panelBottom_ZA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 19 | Зайцев Я.А.";
            this.panelTop_ZA.ResumeLayout(false);
            this.groupBoxTask_ZA.ResumeLayout(false);
            this.groupBoxTask_ZA.PerformLayout();
            this.panelMid_ZA.ResumeLayout(false);
            this.splitContainer_ZA.Panel1.ResumeLayout(false);
            this.splitContainer_ZA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_ZA)).EndInit();
            this.splitContainer_ZA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_ZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZA)).EndInit();
            this.panelBottom_ZA.ResumeLayout(false);
            this.ResumeLayout(false);

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