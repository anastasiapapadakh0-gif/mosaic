using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class MainForm : Form
    {
        private Image[] slideshowImages;
        private int currentImage = 0;
        public MainForm()
        {
            InitializeComponent();

            slideshowImages = new Image[]
            {
                Properties.Resources.slideshow1,
                Properties.Resources.slideshow2,
                Properties.Resources.slideshow3,
                Properties.Resources.slideshow4,
            };

            pictureSlideshow.Image = slideshowImages[0];
            UpdateDots();
        }

        // Ενημερώνει την ένδειξη της ενεργής εικόνας του slideshow.
        private void UpdateDots()
        {
            dot1.ForeColor = Color.LightGray;
            dot2.ForeColor = Color.LightGray;
            dot3.ForeColor = Color.LightGray;
            dot4.ForeColor = Color.LightGray;

            if (currentImage == 0)
                dot1.ForeColor = Color.FromArgb(47, 111, 143);
            else if (currentImage == 1)
                dot2.ForeColor = Color.FromArgb(47, 111, 143);
            else if (currentImage == 2)
                dot3.ForeColor = Color.FromArgb(47, 111, 143);
            else if (currentImage == 3)
                dot4.ForeColor = Color.FromArgb(47, 111, 143);
        }

        private void slideshowTimer_Tick(object sender, EventArgs e)
        {
            // Μετακινείται στην επόμενη εικόνα και επιστρέφει στην πρώτη όταν φτάσει στο τέλος.
            currentImage = (currentImage + 1) % slideshowImages.Length;

            pictureSlideshow.Image = slideshowImages[currentImage];
            UpdateDots();
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        { 
                if (!Session.IsLoggedIn)
                {
                    MessageBox.Show(
                        "Πρέπει να συνδεθείτε για να δείτε τα αγαπημένα σας.",
                        "Απαιτείται σύνδεση",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                OpenForm(new FavoritesForm());
        }
        private void lblHistory_Click(object sender, EventArgs e)
        {
            OpenForm(new HistoryForm());
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            EventItem randomEvent = EventsForm.GetRandomEvent();
            OpenForm(new EventDetailsForm(randomEvent));
        }

        // Ανοίγει μια νέα φόρμα και επιστρέφει στη MainForm όταν αυτή κλείσει.
        private void OpenForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void pnlUsername_Paint(object sender, PaintEventArgs e)
        { }
    }
}
