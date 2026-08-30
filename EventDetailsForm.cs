using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class EventDetailsForm : Form
    {
        // Η εκδήλωση της οποίας εμφανίζονται οι λεπτομέρειες.
        private EventItem currentEvent;

        public EventDetailsForm()
        {
            InitializeComponent();
        }

        public EventDetailsForm(EventItem eventData)
        {
            InitializeComponent();

            currentEvent = eventData;

            lblTitle.MaximumSize = new Size(500, 0);
            lblDescription.MaximumSize = new Size(500, 0);

            lblTitle.Text = eventData.Title;
            lblCategory.Text = "Κατηγορία: " + eventData.Category;
            lblDate.Text = "Ημερομηνία: " + eventData.Date.ToString("dd/MM/yyyy");
            lblDescription.Text = eventData.Description;

            lblPrice.Text = eventData.Price == 0
                ? "Τιμή: Δωρεάν"
                : "Τιμή: " + eventData.Price.ToString("0.##") + " €";

            // TODO: Προσθήκη εικόνας ανά κατηγορία εκδήλωσης.

            UpdateFavoriteButton();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                MessageBox.Show(
                    "Πρέπει να συνδεθείτε για να προσθέσετε αγαπημένα.",
                    "Απαιτείται σύνδεση",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            if (Session.Favorites.Contains(currentEvent))
                Session.Favorites.Remove(currentEvent);
            else
                Session.Favorites.Add(currentEvent);

            UpdateFavoriteButton();
        }

        // Ενημερώνει την καρδιά ανάλογα με το αν η εκδήλωση είναι αγαπημένη.
        private void UpdateFavoriteButton()
        {
            btnFavorite.Text =
                Session.Favorites.Contains(currentEvent) ? "♥" : "♡";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}