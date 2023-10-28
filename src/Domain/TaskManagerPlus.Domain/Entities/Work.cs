namespace TaskManagerPlus.Domain.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan Endtime { get; set; }
        public User AssignedUser { get; set; }
    }
}