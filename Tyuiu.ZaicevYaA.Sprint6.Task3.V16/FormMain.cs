using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.ZaicevYaA.Sprint6.Task3.V16.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
        {
            { 14, 1, -3, 1, 10 },
            { 7, -3, 5, -4, 0 },
            { -10, -19, -18, -9, 19 },
            { -2, -2, -16, 2, -17 },
            { -16, 9, 5, -10, 16 }
        };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewInput_ZYA.ColumnCount = columns;
            dataGridViewInput_ZYA.RowCount = rows;
            dataGridViewOutput_ZYA.ColumnCount = columns;
            dataGridViewOutput_ZYA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_ZYA.Columns[i].Width = 50;
                dataGridViewOutput_ZYA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_ZYA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            int[,] resultMatrix = ds.Calculate(matrix);
            int rows = resultMatrix.GetLength(0);
            int columns = resultMatrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput_ZYA.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-24-1 Зайцев Ярослав Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}