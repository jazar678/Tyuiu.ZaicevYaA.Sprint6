using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        private void buttonOpenFile_ZYA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZYA.ShowDialog();
            openFilePath = openFileDialogTask_ZYA.FileName;

            if (File.Exists(openFilePath))
            {
                textBoxIn_ZYA.Text = File.ReadAllText(openFilePath);
                buttonExecute_ZYA.Enabled = true;
            }
            else
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExecute_ZYA_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFilePath))
            {
                textBoxOut_ZYA.Text = ds.CollectTextFromFile("test", openFilePath);
            }
            else
            {
                MessageBox.Show("Файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}