using System;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                OpenMainForm();
            }
        }
        private void btnGuest_Click(object sender, EventArgs e)
        {
            OpenMainForm();
        }

        // Ανοίγει την κύρια φόρμα και κλείνει τη WelcomeForm όταν η MainForm τερματιστεί.
        private void OpenMainForm()
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            this.Close();
        }
    }

}
