using System;
using System.Drawing;
using Tyuiu.ZaicevYaA.Sprint6.Task7.V28.Lib; 
using System.Windows.Forms;

namespace Tyuiu.ZaicevYaA.Sprint6.Task7.V28
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}