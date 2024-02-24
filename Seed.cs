using expenseTracker.Data;
using expenseTracker.Model;
using System.Diagnostics.Metrics;

namespace expenseTracker
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext(){}
    }
}
