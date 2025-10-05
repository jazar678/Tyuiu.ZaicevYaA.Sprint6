using System;
using System.Drawing;
using System.IO;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib;
using System.Windows.Forms;

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
                buttonDone.Image = Properties.Resources.run_enabled;
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
                buttonDone.Image = Properties.Resources.run_completed;
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

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFile.Image = Properties.Resources.folder_hover;
        }

        private void buttonOpenFile_MouseLeave(object sender, EventArgs e)
        {
            buttonOpenFile.Image = Properties.Resources.folder_normal;
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            if (buttonDone.Enabled)
                buttonDone.Image = Properties.Resources.run_hover;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            if (buttonDone.Enabled)
                buttonDone.Image = Properties.Resources.run_enabled;
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp.Image = Properties.Resources.help_hover;
        }

        private void buttonHelp_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp.Image = Properties.Resources.help_normal;
        }
    }
}