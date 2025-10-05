using System;
using System.Windows.Forms;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib;
using System.IO;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonDone_ZYA.Enabled = false;
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
                buttonDone_ZYA.Enabled = true;
            }
            else
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFilePath))
            {
                textBoxOut_ZYA.Text = ds.CollectTextFromFile(openFilePath);
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