using System.Data.Entity;

namespace TimerWinForms
{
    public class TimerDbContext : DbContext
    {
        public TimerDbContext() : base("DbConnectionString")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Time> Times { get; set; }

    }
}
