using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            lblDescription.MaximumSize = new Size(900, 0);
        }

        // Ανοίγει το LinkedIn προφίλ του αντίστοιχου δημιουργού.
        private void lblDevURL2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/dafni-kontela-b3979a330/");

        }

        private void lblDevURL1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/anastasiapapadaki/");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
