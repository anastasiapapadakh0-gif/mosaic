using System;

namespace Mosaic
{
    // Περιέχει τα βασικά στοιχεία μιας εκδήλωσης.
    public class EventItem
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}