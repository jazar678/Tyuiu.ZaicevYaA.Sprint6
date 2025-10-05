using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.ZaicevYaA.Sprint6.Task7.V28
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            this.Text = "О программе";
            labelDescription.Text = "Разработчик: Зайцев Я.А.\nГруппа: ПКТб-24-1\n\nПрограмма разработана в рамках изучения C#\n\nТюменский индустриальный университет (с) 2023\nВысшая школа цифровых технологий (c) 2023\n\nВнутреннее имя: Tyuiu.ZaicevYaA.Sprint6.Task7.V28";

            // Добавьте фото создателя (замените путь на актуальный)
            // pictureBoxPhoto.Image = Image.FromFile("path_to_photo.jpg");
        }
    }
}