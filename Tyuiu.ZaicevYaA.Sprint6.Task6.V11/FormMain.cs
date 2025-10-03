using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11
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
            string path = openFileDialogTask.FileName;

            if (File.Exists(path))
            {
                textBoxIn.Text = File.ReadAllText(path);

                DataService ds = new DataService();
                textBoxOut.Text = ds.CollectTextFromFile(path);
            }
            else
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы ПКТб-24-1 Зайцев Ярослав Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}