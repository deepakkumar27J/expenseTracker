namespace expenseTracker.Model
{
    public class Expense
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
