
using System.ComponentModel.DataAnnotations;

namespace TimerWinForms
{
    public class Time
    {
        [Key]
        public int Id { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public int MinutesTime { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }

        public User User { get; set;  }
    }
}
