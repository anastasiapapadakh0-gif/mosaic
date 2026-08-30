using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class EventsForm : Form
    {
        // Κοινή λίστα εκδηλώσεων που χρησιμοποιείται σε όλη την εφαρμογή.
        private static List<EventItem> allEvents = new List<EventItem>
        {
            new EventItem
        {
            Title = "Φεστιβάλ Κρητικής Μουσικής",
            Date = new DateTime(2026, 7, 12),
            Category = "Μουσική",
            Description = "Μια βραδιά αφιερωμένη στην παραδοσιακή κρητική μουσική με λύρα, λαούτο και ζωντανές εμφανίσεις από τοπικά μουσικά συγκροτήματα. Το κοινό θα έχει την ευκαιρία να γνωρίσει χαρακτηριστικούς ήχους της Κρήτης και να συμμετάσχει σε παραδοσιακούς χορούς.",
            Price = 12
        },

        new EventItem
        {
            Title = "Βραδιά Παραδοσιακών Χορών",
            Date = new DateTime(2026, 7, 20),
            Category = "Παράδοση & Πολιτισμός",
            Description = "Πολιτιστικοί σύλλογοι από διαφορετικές περιοχές της Κρήτης παρουσιάζουν πεντοζάλη, συρτό, μαλεβιζιώτη και άλλους παραδοσιακούς χορούς, με συνοδεία ζωντανής μουσικής.",
            Price = 8
        },

        new EventItem
        {
            Title = "Θερινός Κινηματογράφος στο Παλιό Λιμάνι",
            Date = new DateTime(2026, 7, 28),
            Category = "Τέχνες & Θέαμα",
            Description = "Υπαίθρια προβολή ελληνικής κινηματογραφικής ταινίας σε ειδικά διαμορφωμένο χώρο κοντά στη θάλασσα. Πριν από την προβολή θα πραγματοποιηθεί σύντομη παρουσίαση της ταινίας.",
            Price = 7
        },

        new EventItem
        {
            Title = "Χρώματα της Κρήτης",
            Date = new DateTime(2026, 8, 5),
            Category = "Τέχνες & Θέαμα",
            Description = "Ομαδική έκθεση ζωγραφικής με έργα εμπνευσμένα από τα τοπία, τη θάλασσα, τα χωριά και την καθημερινή ζωή της Κρήτης.",
            Price = 5
        },

        new EventItem
        {
            Title = "Γιορτή Κρητικών Γεύσεων",
            Date = new DateTime(2026, 8, 18),
            Category = "Γαστρονομία",
            Description = "Παραγωγοί και σεφ παρουσιάζουν χαρακτηριστικά προϊόντα της Κρήτης, όπως ελαιόλαδο, μέλι, τυριά, βότανα και παραδοσιακά πιάτα.",
            Price = 0
        },

        new EventItem
        {
            Title = "Ο Καπετάν Μιχάλης",
            Date = new DateTime(2026, 8, 30),
            Category = "Τέχνες & Θέαμα",
            Description = "Θεατρική παράσταση εμπνευσμένη από το γνωστό έργο του Νίκου Καζαντζάκη. Η παράσταση επικεντρώνεται στην ιστορία, την ελευθερία και την ταυτότητα της Κρήτης.",
            Price = 15
        },

        new EventItem
        {
            Title = "Ιστορικός Περίπατος στην Παλιά Πόλη",
            Date = new DateTime(2026, 9, 10),
            Category = "Παράδοση & Πολιτισμός",
            Description = "Οργανωμένη περιήγηση με ξεναγό σε ιστορικά κτίρια, μνημεία και χαρακτηριστικά σημεία της παλιάς πόλης, με πληροφορίες για την ιστορία της Κρήτης.",
            Price = 6
        },

        new EventItem
        {
            Title = "Νύχτα Αστεριών στον Ψηλορείτη",
            Date = new DateTime(2026, 9, 22),
            Category = "Φύση & Δραστηριότητες",
            Description = "Βραδινή δράση παρατήρησης του ουρανού στον Ψηλορείτη. Οι συμμετέχοντες θα γνωρίσουν βασικούς αστερισμούς και θα παρατηρήσουν τον ουρανό με τηλεσκόπια.",
            Price = 6
        },

        new EventItem
        {
            Title = "Jazz στο Ενετικό Λιμάνι",
            Date = new DateTime(2026, 10, 3),
            Category = "Μουσική",
            Description = "Μια βραδιά jazz μουσικής με συμμετοχή μουσικών από την Κρήτη και την υπόλοιπη Ελλάδα, με γνωστές συνθέσεις και αυτοσχεδιασμούς.",
            Price = 10
        },

        new EventItem
        {
            Title = "Φεστιβάλ Νέων Καλλιτεχνών",
            Date = new DateTime(2026, 10, 11),
            Category = "Φεστιβάλ & Γιορτές",
            Description = "Φεστιβάλ αφιερωμένο σε νέους δημιουργούς από την Κρήτη με μουσική, θέατρο, φωτογραφία, ζωγραφική και μικρές καλλιτεχνικές παρουσιάσεις.",
            Price = 9
        },

        new EventItem
        {
            Title = "Η Κρήτη μέσα από τον Φακό",
            Date = new DateTime(2026, 10, 24),
            Category = "Τέχνες & Θέαμα",
            Description = "Έκθεση φωτογραφίας με θέμα τα φυσικά τοπία, τους ανθρώπους και τις παραδόσεις της Κρήτης, από τα ορεινά χωριά μέχρι τις παραθαλάσσιες περιοχές.",
            Price = 4
        },

        new EventItem
        {
            Title = "Μινωικός Πολιτισμός: Παρελθόν και Παρόν",
            Date = new DateTime(2026, 11, 8),
            Category = "Παράδοση & Πολιτισμός",
            Description = "Εκπαιδευτική πολιτιστική εκδήλωση αφιερωμένη στον Μινωικό πολιτισμό, με παρουσίαση αρχαιολογικών ευρημάτων και οπτικοακουστικό υλικό.",
            Price = 5
        },

        new EventItem
        {
            Title = "Παραδοσιακό Πανηγύρι στη Σητεία",
            Date = new DateTime(2026, 11, 16),
            Category = "Φεστιβάλ & Γιορτές",
            Description = "Παραδοσιακή γιορτή με κρητική μουσική, τοπικά εδέσματα και χορούς. Πολιτιστικοί σύλλογοι παρουσιάζουν έθιμα της Ανατολικής Κρήτης.",
            Price = 0
        },

        new EventItem
        {
            Title = "Χριστουγεννιάτικη Αγορά Ρεθύμνου",
            Date = new DateTime(2026, 12, 15),
            Category = "Φεστιβάλ & Γιορτές",
            Description = "Χριστουγεννιάτικη αγορά με μικρούς παραγωγούς, χειροποίητες δημιουργίες, παραδοσιακά προϊόντα και εορταστικές δραστηριότητες.",
            Price = 0
        },

        new EventItem
        {
            Title = "Συναυλία στο Φρούριο Καζάρμας",
            Date = new DateTime(2026, 12, 20),
            Category = "Μουσική",
            Description = "Μουσική συναυλία που συνδυάζει σύγχρονη ελληνική μουσική με στοιχεία παραδοσιακής κρητικής μουσικής και συμμετοχές τοπικών καλλιτεχνών.",
            Price = 14
        }

        };
        public EventsForm()
        {
            InitializeComponent();
        }

        private void ResetFilters()
        {
            txtSearch.Clear();
            cmbCategory.SelectedIndex = 0;
            cmbPrice.SelectedIndex = 0;
            dtpDate.Checked = false;
        }


        private void EventsForm_Load(object sender, EventArgs e)
        {
            ResetFilters();
            DisplayEvents(allEvents);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFilters();
            DisplayEvents(allEvents);
        }
        // Επιστρέφει μία τυχαία εκδήλωση για τη λειτουργία "Ανακάλυψε".
        public static EventItem GetRandomEvent()
        {
            Random random = new Random();
            return allEvents[random.Next(allEvents.Count)];
        }

        private void DisplayEvents(List<EventItem> events)
        {
            flpEvents.Controls.Clear();

            foreach (EventItem eventItem in events)
            {
                EventCardControl card = new EventCardControl();

                card.SetEvent(eventItem);

                flpEvents.Controls.Add(card);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<EventItem> results = allEvents.ToList();

            // Αναζήτηση τίτλου
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string searchText = txtSearch.Text.Trim();

                results = results
                    .Where(x => x.Title.IndexOf(
                        searchText,
                        StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }

            // Κατηγορία
            if (cmbCategory.SelectedItem != null &&
                cmbCategory.SelectedItem.ToString() != "Όλες")
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();

                results = results
                    .Where(x => x.Category == selectedCategory)
                    .ToList();
            }

            // Ημερομηνία
            if (dtpDate.Checked)
            {
                results = results
                    .Where(x => x.Date.Date == dtpDate.Value.Date)
                    .ToList();
            }

            // Τιμή
            if (cmbPrice.SelectedItem != null)
            {
                string selectedPrice = cmbPrice.SelectedItem.ToString();

                if (selectedPrice == "Δωρεάν")
                    results = results.Where(x => x.Price == 0).ToList();

                else if (selectedPrice == "Έως 5€")
                    results = results.Where(x => x.Price <= 5).ToList();

                else if (selectedPrice == "Έως 10€")
                    results = results.Where(x => x.Price <= 10).ToList();

                else if (selectedPrice == "Έως 15€")
                    results = results.Where(x => x.Price <= 15).ToList();

                else if (selectedPrice == "Πάνω από 15€")
                    results = results.Where(x => x.Price > 15).ToList();
            }

            if (results.Count == 0)
            {
                flpEvents.Controls.Clear();

                MessageBox.Show(
                    "Δεν βρέθηκαν εκδηλώσεις που να ταιριάζουν στα κριτήρια αναζήτησης.",
                    "Δεν βρέθηκαν αποτελέσματα",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            DisplayEvents(results);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Προσαρμόζει τα χρώματα των επιλογών στα ComboBox.

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox combo = (ComboBox)sender;

            Color bg = (e.State & DrawItemState.Selected) != 0
                ? Color.FromArgb(210, 230, 235)
                : Color.White;

            using (Brush brush = new SolidBrush(bg))
                e.Graphics.FillRectangle(brush, e.Bounds);

            TextRenderer.DrawText(
                e.Graphics,
                combo.Items[e.Index].ToString(),
                combo.Font,
                e.Bounds,
                Color.FromArgb(35, 56, 67),
                TextFormatFlags.VerticalCenter
            );
        }
    }
}
