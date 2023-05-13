using DataAccess_Interfaces.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ProductRepository : GenericRepository<Product>
    {
        TestContext Context { get; set; }

        public ProductRepository(TestContext context) : base(context)
        {
            this.Context = context;
        }

        public void GetData()
        {
            Context.Database.FromSqlRaw($"EXEC dbo.OBTestHello").ToList();
        }


    }
}
