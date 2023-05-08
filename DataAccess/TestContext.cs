using DataAccess_Interfaces.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public partial class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }

        public virtual DbSet<GenericModel> GenericModel { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<User> Users { get; set; }

    }
}