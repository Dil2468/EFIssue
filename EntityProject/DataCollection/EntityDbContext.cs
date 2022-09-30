using EntityProject.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityProject.DataCollection
{
    public class EntityDbContext:DbContext
    {

        public EntityDbContext(DbContextOptions<EntityDbContext> options):base(options)
        {

        }

        public DbSet<Model.Customer> Customers { get; set; }
    }
}
