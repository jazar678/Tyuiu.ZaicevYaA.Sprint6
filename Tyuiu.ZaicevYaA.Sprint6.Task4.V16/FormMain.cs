using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ZaicevYA.Sprint6.Task4.V16.Lib;

namespace Tyuiu.ZaicevYA.Sprint6.Task4.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_ZY_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_ZY.Text);
                int stopValue = Convert.ToInt32(textBoxStop_ZY.Text);

                if (startValue > stopValue)
                {
                    MessageBox.Show("Стартовое значение не может быть больше конечного!", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_ZY.Text = "";

                chartFunction_ZY.Series[0].Points.Clear();
                for (int i = 0; i < valueArray.Length; i++)
                {
                    textBoxResult_ZY.AppendText(valueArray[i].ToString("F2") + Environment.NewLine);
                    chartFunction_ZY.Series[0].Points.AddXY(startValue + i, valueArray[i]);
                }

                buttonSave_ZY.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_ZY_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_ZY.Text);
                int stopValue = Convert.ToInt32(textBoxStop_ZY.Text);

                string path = ds.SaveToFile(startValue, stopValue);

                DialogResult result = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = cos(x)/(x - 0.4) + sin(x)*8*x + 2\n" +
                          "на диапазоне от -5 до 5 с шагом 1.\n\n" +
                          "Выполнил: Зайцев Я.А. | ПКТб-24-1",
                          "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}