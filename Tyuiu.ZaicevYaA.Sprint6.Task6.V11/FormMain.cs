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

        private string filePath;
        DataService ds = new DataService();

        private void buttonOpenFile_ZYA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZYA.ShowDialog();
            filePath = openFileDialogTask_ZYA.FileName;
            textBoxIn_ZYA.Text = File.ReadAllText(filePath);
            buttonDone_ZYA.Enabled = true;
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            textBoxOut_ZYA.Text = ds.CollectTextFromFile("", filePath);
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
}