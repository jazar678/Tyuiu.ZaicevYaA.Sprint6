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
            textBoxIn_ZYA.Text = File.ReadAllText(openFilePath);
            buttonDone_ZYA.Enabled = true;
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            textBoxOut_ZYA.Text = ds.CollectTextFromFile("", openFilePath);
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы ПКТб-24-1 Зайцев Ярослав Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}