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

        private void buttonDone_ZY�_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = Convert.ToInt32(textBoxStart_ZY�.Text);
                int stopValue = Convert.ToInt32(textBoxStop_ZY�.Text);

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                // ����� � textBox
                textBoxResult_ZY�.Text = "���������� ������������� ������� F(x) = cos(x)/(x-0.4) + sin(x)*8x + 2:\r\n";
                textBoxResult_ZY�.AppendText("����� ����: " + startValue + "\r\n");
                textBoxResult_ZY�.AppendText("����� ����: " + stopValue + "\r\n");
                textBoxResult_ZY�.AppendText("-----------------------------------\r\n");

                for (int i = 0; i < valueArray.Length; i++)
                {
                    textBoxResult_ZY�.AppendText($"F({startValue + i}) = {valueArray[i]}\r\n");
                }

                // ���������� � ����
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V16.txt";
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("���������� ������������� ������� F(x) = cos(x)/(x-0.4) + sin(x)*8x + 2:");
                    writer.WriteLine($"����� ����: {startValue}");
                    writer.WriteLine($"����� ����: {stopValue}");
                    writer.WriteLine("-----------------------------------");

                    for (int i = 0; i < valueArray.Length; i++)
                    {
                        writer.WriteLine($"F({startValue + i}) = {valueArray[i]}");
                    }
                }

                // ���������� �������
                chartFunction_ZY�.ChartAreas[0].AxisX.Title = "��� X";
                chartFunction_ZY�.ChartAreas[0].AxisY.Title = "��� F(x)";
                chartFunction_ZY�.Series[0].Points.Clear();

                for (int i = 0; i < valueArray.Length; i++)
                {
                    chartFunction_ZY�.Series[0].Points.AddXY(startValue + i, valueArray[i]);
                }

                MessageBox.Show("���������� ��������� � ����: " + path, "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZY�_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������������� ������� F(x) = cos(x)/(x-0.4) + sin(x)*8x + 2\n" +
                          "�� ��������� �� -5 �� 5 � ����� 1.\n\n" +
                          "��������: ������ �.�. ����-24-1", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}