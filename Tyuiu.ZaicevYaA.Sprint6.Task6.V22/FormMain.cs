using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V22.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxOutput_ZYA.ScrollBars = ScrollBars.Vertical;
            textBoxInput_ZYA.ScrollBars = ScrollBars.Vertical;
        }

        string openFilePath;
        DataService dataService = new DataService();

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            textBoxOutput_ZYA.Text = dataService.CollectTextFromFile("", openFilePath);
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 6 �������� ������� ������ ����-24-1 ������ ������� �������������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_ZYA_Click(object sender, EventArgs e)
        {
            openFileDialog_ZYA.ShowDialog();
            openFilePath = openFileDialog_ZYA.FileName;
            try
            {
                textBoxInput_ZYA.Text = File.ReadAllText(openFilePath);
                groupBoxInput_ZYA.Text = "���� " + openFileDialog_ZYA.FileName;
                buttonDone_ZYA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("���� �� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}