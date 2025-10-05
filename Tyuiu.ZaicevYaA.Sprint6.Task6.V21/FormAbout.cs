using System;
using System.Drawing;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib;
using System.Windows.Forms;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V21
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

        private void buttonOK_MouseEnter(object sender, EventArgs e)
        {
            buttonOK.BackColor = Color.LightBlue;
        }

        private void buttonOK_MouseLeave(object sender, EventArgs e)
        {
            buttonOK.BackColor = SystemColors.Control;
        }
    }
}