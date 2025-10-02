using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ZaicevYA.Sprint6.Task4.V16.Lib;

namespace Tyuiu.ZaicevYA.Sprint6.Task4.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_ZYА_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = Convert.ToInt32(textBoxStart_ZYА.Text);
                int stopValue = Convert.ToInt32(textBoxStop_ZYА.Text);

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                // Вывод в textBox
                textBoxResult_ZYА.Text = "Результаты табулирования функции F(x) = cos(x)/(x-0.4) + sin(x)*8x + 2:\r\n";
                textBoxResult_ZYА.AppendText("Старт шага: " + startValue + "\r\n");
                textBoxResult_ZYА.AppendText("Конец шага: " + stopValue + "\r\n");
                textBoxResult_ZYА.AppendText("-----------------------------------\r\n");

                for (int i = 0; i < valueArray.Length; i++)
                {
                    textBoxResult_ZYА.AppendText($"F({startValue + i}) = {valueArray[i]}\r\n");
                }

                // Сохранение в файл
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V16.txt";
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Результаты табулирования функции F(x) = cos(x)/(x-0.4) + sin(x)*8x + 2:");
                    writer.WriteLine($"Старт шага: {startValue}");
                    writer.WriteLine($"Конец шага: {stopValue}");
                    writer.WriteLine("-----------------------------------");

                    for (int i = 0; i < valueArray.Length; i++)
                    {
                        writer.WriteLine($"F({startValue + i}) = {valueArray[i]}");
                    }
                }

                // Построение графика
                chartFunction_ZYА.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_ZYА.ChartAreas[0].AxisY.Title = "Ось F(x)";
                chartFunction_ZYА.Series[0].Points.Clear();

                for (int i = 0; i < valueArray.Length; i++)
                {
                    chartFunction_ZYА.Series[0].Points.AddXY(startValue + i, valueArray[i]);
                }

                MessageBox.Show("Результаты сохранены в файл: " + path, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZYА_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = cos(x)/(x-0.4) + sin(x)*8x + 2\n" +
                          "на диапазоне от -5 до 5 с шагом 1.\n\n" +
                          "Выполнил: Зайцев Я.А. ПКТб-24-1", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}