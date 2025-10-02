using System;
using System.Windows.Forms;
using Tyuiu.ZaicevYaA.Sprint6.Task5.V19.Lib;
using System.IO;
using System.Linq;

namespace Tyuiu.ZaicevYaA.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V19.txt";

        private void buttonOpenFile_ZYA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_ZYA.ColumnCount = 2;
            dataGridViewNums_ZYA.Columns[0].Width = 20;
            dataGridViewNums_ZYA.Columns[1].Width = 50;
            dataGridViewNums_ZYA.Columns[0].HeaderText = "№";
            dataGridViewNums_ZYA.Columns[1].HeaderText = "Значение";

            this.chartDiag_ZYA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_ZYA.ChartAreas[0].AxisY.Title = "Ось Y";
            this.chartDiag_ZYA.Series[0].Points.Clear();

            double[] nums = ds.LoadFromDataFile(path);

            dataGridViewNums_ZYA.Rows.Clear();

            // Фильтруем только целые числа
            double[] integerNumbers = nums.Where(x => Math.Abs(x % 1) < 0.0001).ToArray();

            for (int i = 0; i < integerNumbers.Length; i++)
            {
                dataGridViewNums_ZYA.Rows.Add(i, integerNumbers[i]);
                this.chartDiag_ZYA.Series[0].Points.AddXY(i, integerNumbers[i]);
            }
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-24-1 Зайцев Ярослав Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.chartDiag_ZYA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_ZYA.ChartAreas[0].AxisY.Title = "Ось Y";
        }
    }
}