using System.Globalization;

namespace expenseTracker.Model
{
    public class Settings
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public string Language { get; set; }
        public string CurrencyFormat { get; set; }
        public string NotificationPreference { get; set; }
        public User User { get; set; }
    }
}
