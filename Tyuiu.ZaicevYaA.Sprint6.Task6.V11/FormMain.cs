using System;
using System.IO;
using System.Windows.Forms;
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
                MessageBox.Show("Файл не выбран или не существует!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExecute_ZYA_Click(object sender, EventArgs e)
        {
            try
            {
                string result = ds.CollectTextFromFile("test", openFilePath);
                textBoxOut_ZYA.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}