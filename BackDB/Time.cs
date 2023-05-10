
namespace TimerWinForms
{
    public class Time
    {
        public int Id { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public int MinutesTime { get; set; }
        public string? Description { get; set; }
        public string UserId { get; set; }

        public User User { get; set;  }
    }
}
