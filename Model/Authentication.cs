namespace expenseTracker.Model
{
    public class Authentication
    {
        public int Id { get; set; }
        public string TokenValue { get; set; }
        public DateTime ExpirationDate { get; set; }
        public User User { get; set; }
    }
}
