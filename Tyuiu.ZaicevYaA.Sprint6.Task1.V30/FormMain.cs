using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.ZaicevYaA.Sprint6.Task1.V30.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task1.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_ZYA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_ZYA.Text);

                int len = stopStep - startStep + 1;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_ZYA.Text = "";
                textBoxResult_ZYA.AppendText("Таблица значений функции F(x) = (2x-3)/(cos(x)-2x) + 5x - 6" + Environment.NewLine);
                textBoxResult_ZYA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_ZYA.AppendText("|    X     |   F(x)   |" + Environment.NewLine);
                textBoxResult_ZYA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    textBoxResult_ZYA.AppendText($"| {startStep + i,5}    | {valueArray[i],8:f2} |" + Environment.NewLine);
                }

                textBoxResult_ZYA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = (2x-3)/(cos(x)-2x) + 5x - 6 на диапазоне [-5;5] с шагом 1. Выполнил: Зайцев Ярослав Александрович, ПКТб-24-1", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}