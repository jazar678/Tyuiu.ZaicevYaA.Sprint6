using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ZaicevYaA.Sprint6.Task2.V15.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task2.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startStep = Convert.ToInt32(textBoxStartStep_ZYA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_ZYA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_ZYA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ZYA.ChartAreas[0].AxisY.Title = "Ось F(x)";

                this.chartFunction_ZYA.Series[0].Points.Clear();
                dataGridViewResult_ZYA.Rows.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewResult_ZYA.Rows.Add(Convert.ToString(startStep + i), Convert.ToString(valueArray[i]));
                    this.chartFunction_ZYA.Series[0].Points.AddXY(startStep + i, valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = (2sin(x))/(3x+1.2) + cos(x) - 7x*2 на диапазоне [-5;5] с шагом 1. Выполнил: Зайцев Ярослав Александрович, ПКТб-24-1", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_ZYA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_ZYA.BackColor = Color.Red;
        }

        private void buttonDone_ZYA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_ZYA.BackColor = Color.Green;
        }
    }
}