using System;
using System.Windows.Forms;


namespace Mosaic
{
    public partial class HeaderControl : UserControl
    {

        public HeaderControl()
        {
            InitializeComponent();
        }

        private void HeaderControl_Load(object sender, EventArgs e)
        {
            UpdateUserStatus();
        }

        // Εμφανίζει το username όταν υπάρχει συνδεδεμένος χρήστης.
        public void UpdateUserStatus()
        {
            if (Session.IsLoggedIn)
            {
                lblUser.Text = Session.Username;
            }
            else
            {
                lblUser.Text = "Σύνδεση";
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
                return;

            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
                UpdateUserStatus();
        }

        // Ανοίγει μια σελίδα του menu και επιστρέφει στην προηγούμενη όταν κλείσει.
        private void OpenForm(Form newForm)
        {
            Form currentForm = this.FindForm();

            if (currentForm == null || currentForm.GetType() == newForm.GetType())
                return;

            currentForm.Hide();
            newForm.ShowDialog();
            currentForm.Show();
            // καλύπτουμε case όποου ο χρήστης κάνει login μέσα σε άλλη σελίδα και μετά επιστρέψει,
            // ώστε το Header να ανανεώσει το username
            UpdateUserStatus();
        }
        private void lblEvent_Click(object sender, EventArgs e)
        {
            OpenForm(new EventsForm());
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            OpenForm(new AboutForm());
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            OpenForm(new HelpForm());
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            OpenForm(new MainForm());
        }
    }
}