using System.Collections.Generic;

namespace Mosaic
{
    // Κρατά προσωρινά τα στοιχεία του συνδεδεμένου χρήστη κατά τη λειτουργία της εφαρμογής.
    public static class Session
    {
        public static bool IsLoggedIn = false;
        public static string Username = "";
        public static List<EventItem> Favorites = new List<EventItem>();
    }
}
