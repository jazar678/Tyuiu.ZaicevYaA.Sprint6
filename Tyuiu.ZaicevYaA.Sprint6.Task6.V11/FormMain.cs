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

        private void buttonOpenFile_ZYA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZYA.ShowDialog();
            string filename = openFileDialogTask_ZYA.FileName;

            if (File.Exists(filename))
            {
                textBoxIn_ZYA.Text = File.ReadAllText(filename);
                buttonDone_ZYA.Enabled = true;
            }
            else
            {
                MessageBox.Show("Файл не выбран или не существует!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                string path = openFileDialogTask_ZYA.FileName;
                string result = ds.CollectTextFromFile("test", path);
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