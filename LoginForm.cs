using System;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnUserlogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Έλεγχος των διαθέσιμων λογαριασμών της εφαρμογής
            if ((username == "admin" && password == "1234") ||
                (username == "user" && password == "5678"))
            {

                // Αποθηκεύει τα στοιχεία σύνδεσης για εμφάνιση του username
                // και έλεγχο των δικαιωμάτων στις υπόλοιπες φόρμες.
                Session.IsLoggedIn = true;
                Session.Username = username;

                MessageBox.Show("Επιτυχής σύνδεση!");

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Ελέγξτε τα στοιχεία σας και δοκιμάστε ξανά.", "Λάθος στοιχεία" );
            }
        }
    }
}
