using System;
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
    }
}