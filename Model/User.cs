namespace expenseTracker.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Authentication> Tokens { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Settings> Settings { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}
