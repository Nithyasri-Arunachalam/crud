using Microsoft.EntityFrameworkCore;

namespace CRUD.Models.User
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {


        }
        public DbSet<Students> StudentDetails {get;set;}
    }
}
