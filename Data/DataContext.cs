using expenseTracker.Model;
using Microsoft.EntityFrameworkCore;

namespace expenseTracker.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AuditLogs> AuditLogs { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
