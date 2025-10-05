using System;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Tyuiu.ZaicevYaA.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | Зайцев Я.А.";
            buttonOpenFile.Click += ButtonOpenFile_Click;
            buttonDone.Click += ButtonDone_Click;
            buttonSaveFile.Click += ButtonSaveFile_Click;
            buttonHelp.Click += ButtonHelp_Click;
        }

        private string filePath;
        private int[,] matrix;

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Выберите файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                LoadMatrixToDataGridView(filePath, dataGridViewIn);
                buttonDone.Enabled = true;
            }
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            if (filePath == null) return;

            DataService ds = new DataService();
            matrix = ds.GetMatrix(filePath);

            DisplayMatrixInDataGridView(matrix, dataGridViewOut);
            buttonSaveFile.Enabled = true;
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Сохранить результат"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveMatrixToFile(matrix, saveFileDialog.FileName);
                MessageBox.Show("Файл сохранен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void LoadMatrixToDataGridView(string path, DataGridView dgv)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            DataTable dt = new DataTable();

            for (int i = 0; i < columns; i++)
                dt.Columns.Add($"Column{i}");

            foreach (string line in lines)
            {
                string[] cells = line.Split(';');
                dt.Rows.Add(cells);
            }

            dgv.DataSource = dt;
        }

        private void DisplayMatrixInDataGridView(int[,] matrix, DataGridView dgv)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            DataTable dt = new DataTable();

            for (int i = 0; i < columns; i++)
                dt.Columns.Add($"Column{i}");

            for (int i = 0; i < rows; i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 0; j < columns; j++)
                    row[j] = matrix[i, j];
                dt.Rows.Add(row);
            }

            dgv.DataSource = dt;
        }

        private void SaveMatrixToFile(int[,] matrix, string path)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    string[] line = new string[columns];
                    for (int j = 0; j < columns; j++)
                        line[j] = matrix[i, j].ToString();
                    sw.WriteLine(string.Join(";", line));
                }
            }
        }
    }
}