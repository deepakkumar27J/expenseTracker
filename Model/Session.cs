namespace expenseTracker.Model
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LastActivityTime { get; set; }
        public User User { get; set; }
    }
}
