using System;
using System.Windows.Forms;
using Tyuiu.ZaicevYA.Sprint6.Task0.V6.Lib;

namespace Tyuiu.ZaicevYA.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_ZYA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int x = Convert.ToInt32(textBoxVarX_ZYA.Text);
                double result = ds.Calculate(x);
                textBoxResult_ZYA.Text = result.ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ����-24-1 ������ ������� �������������",
                "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}