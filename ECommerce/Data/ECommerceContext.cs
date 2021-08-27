using Microsoft.EntityFrameworkCore;
using ECommerce.Models;

namespace ECommerce.Data
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext()
        {
        }

        public ECommerceContext(DbContextOptions<ECommerceContext> options)
            : base(options)
        {



        }
        public DbSet<ECommerce.Models.Departments> Departments { get; set; }
        public DbSet<ECommerce.Models.City> City { get; set; }
    }
}
