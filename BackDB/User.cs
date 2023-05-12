using System.ComponentModel.DataAnnotations;

namespace TimerWinForms
{
    public class User
    {
        [Key]
        public int Id {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Time> Times { get; set; }
    }
}
