namespace expenseTracker.Model
{
    public class AuditLogs
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime Timestamps { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }
}
