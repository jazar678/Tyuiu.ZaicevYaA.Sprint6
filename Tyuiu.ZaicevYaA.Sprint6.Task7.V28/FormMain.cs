using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ZaicevYaA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent(); // Исправлено: InitializeComponent
            openFileDialogTask.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialogMatrix.Filter = "CSV files (*.csv)|*.csv";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            if (File.Exists(openFilePath))
            {
                int[,] arrayValues = LoadFromFileData(openFilePath);

                dataGridViewIn.ColumnCount = columns;
                dataGridViewIn.RowCount = rows;
                dataGridViewOut.ColumnCount = columns;
                dataGridViewOut.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn.Columns[i].Width = 50;
                    dataGridViewOut.Columns[i].Width = 50;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                arrayValues = ds.GetMatrix(openFilePath);
                buttonDone.Enabled = true;
            }
            else
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            if (saveFileDialogMatrix.FileName != "")
            {
                FileInfo fileInfo = new FileInfo(saveFileDialogMatrix.FileName);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(saveFileDialogMatrix.FileName);
                }

                int rows = dataGridViewOut.RowCount;
                int columns = dataGridViewOut.ColumnCount;

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(saveFileDialogMatrix.FileName, str + Environment.NewLine);
                    str = "";
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}