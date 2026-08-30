using System;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class FavoritesForm : Form
    {
        public FavoritesForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FavoritesForm_Load(object sender, EventArgs e)

        {
            // Δημιουργεί μία κάρτα για κάθε αγαπημένη εκδήλωση του χρήστη.
            foreach (EventItem eventItem in Session.Favorites)
            {
                EventCardControl card = new EventCardControl();

                card.SetEvent(eventItem);

                flpFavourites.Controls.Add(card);
            }
        }
    }
}
