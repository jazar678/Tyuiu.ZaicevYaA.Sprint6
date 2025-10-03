using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        private string filePath;
        private DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonOpenFile_ZYA_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_ZYA.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialogTask_ZYA.FileName;
                textBoxIn_ZYA.Text = File.ReadAllText(filePath);
                buttonDone_ZYA.Enabled = true;
            }
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                textBoxOut_ZYA.Text = ds.CollectTextFromFile("", filePath);
            }
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}