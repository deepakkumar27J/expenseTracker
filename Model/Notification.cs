namespace expenseTracker.Model
{
    public class Notification
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime Timestamp { get; set; }
        public User User { get; set; }
    }
}
