using Microsoft.EntityFrameworkCore;

namespace SaleWebMvc.Models
{
    public class SaleWebMvcContext : DbContext
    {
        public SaleWebMvcContext(DbContextOptions<SaleWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
    }
}
