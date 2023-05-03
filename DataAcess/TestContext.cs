using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAcess
{
    public partial class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }

        public virtual DbSet<String> GenericModel { get; set; }

    }
}