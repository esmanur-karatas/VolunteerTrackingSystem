using EntitiesLayer;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=VolunteerFollowDB")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
        
    }
}
