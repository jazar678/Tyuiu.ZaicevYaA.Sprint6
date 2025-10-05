using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            string filePath = openFileDialogTask.FileName;

            if (File.Exists(filePath))
            {
                textBoxIn.Text = File.ReadAllText(filePath);
                buttonDone.Enabled = true;
            }
            else
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string path = openFileDialogTask.FileName;

            if (File.Exists(path))
            {
                DataService ds = new DataService();
                textBoxOut.Text = ds.CollectTextFromFile("g", path);
            }
            else
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}