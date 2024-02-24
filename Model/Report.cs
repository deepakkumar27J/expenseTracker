namespace expenseTracker.Model
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateRangeStart { get; set; }
        public DateTime DateRangeEnd { get; set; }
        public string Summary { get; set; }
        public string VisualizationData { get; set; }
        public User User { get; set; }
    }
}
