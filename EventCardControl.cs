using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class EventCardControl : UserControl
    {
        // Η εκδήλωση που εμφανίζεται στην συγκεκριμένη κάρτα.
        private EventItem currentEvent;

        public EventCardControl()
        {
            InitializeComponent();

            lblTitle.MaximumSize = new Size(200, 0);
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
            {
                Session.Favorites.Remove(currentEvent);

                // Στη σελίδα Αγαπημένων αφαιρεί και την κάρτα από την οθόνη.
                if (this.FindForm() is FavoritesForm)
                {
                    this.Parent.Controls.Remove(this);
                    return;
                }
            }
            else
            {
                Session.Favorites.Add(currentEvent);
            }

            UpdateFavoriteButton();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            EventDetailsForm detailsForm = new EventDetailsForm(currentEvent);

            parentForm.Hide();
            detailsForm.ShowDialog();
            parentForm.Show();

            // Αν αφαιρέθηκε από τα αγαπημένα μέσα στα Details,
            // αφαιρείται και από την FavoritesForm.
            if (parentForm is FavoritesForm &&
                !Session.Favorites.Contains(currentEvent))
            {
                this.Parent.Controls.Remove(this);
                return;
            }

            UpdateFavoriteButton();
        }

        public void SetEvent(EventItem eventData)
        {
            currentEvent = eventData;

            lblTitle.Text = eventData.Title;
            lblCategory.Text = eventData.Category;
            lblDate.Text = eventData.Date.ToString("dd/MM/yyyy");

            lblPrice.Text = eventData.Price == 0
                ? "Δωρεάν"
                : eventData.Price.ToString("0.##") + " €";

            // TODO: Προσθήκη εικόνας ανά κατηγορία εκδήλωσης.
            UpdateFavoriteButton();
        }

        // Ενημερώνει την καρδιά ανάλογα με το αν η εκδήλωση είναι αγαπημένη.
        private void UpdateFavoriteButton()
        {
            btnFavorite.Text =
                Session.Favorites.Contains(currentEvent) ? "♥" : "♡";
        }
    }
}
