using System;
using System.Windows.Forms;
using Tyuiu.ZaicevYaA.Sprint6.Task5.V19.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_ZA_Click(object sender, EventArgs e)
        {
            string path = @"C:\DataSprint6\InPutFileTask5V19.txt";
            double[] nums = ds.LoadFromDataFile(path);

            dataGridViewNums_ZA.Rows.Clear();
            dataGridViewNums_ZA.Columns.Clear();

            dataGridViewNums_ZA.Columns.Add("columnIndex", "№");
            dataGridViewNums_ZA.Columns.Add("columnValue", "Значение");

            chartFunction_ZA.Series[0].Points.Clear();

            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewNums_ZA.Rows.Add(i + 1, nums[i]);
                chartFunction_ZA.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonOpenFile_ZA_Click(object sender, EventArgs e)
        {
            string path = @"C:\DataSprint6\InPutFileTask5V19.txt";
            System.Diagnostics.Process.Start(path);
        }

        private void buttonHelp_ZA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-24-1 Зайцев Ярослав Александрович", "Сообщение");
        }
    }
}