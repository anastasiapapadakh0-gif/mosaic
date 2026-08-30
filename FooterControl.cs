using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class FooterControl : UserControl
    {
        public FooterControl()
        {
            InitializeComponent();
        }

        private async void picExit_Click(object sender, EventArgs e)
        {
            // Εμφανίζει στιγμιαία το πατημένο κουμπί πριν κλείσει η εφαρμογή.
            picExit.Image = Properties.Resources.buttonPressed;

            await Task.Delay(300);

            Application.Exit();
        }
    }
}
