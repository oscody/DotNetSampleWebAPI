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

        //internal ProductRepository(TestContext context, Func<TestContext> newReadContext)
        //{
        //    this.Context = context;
        //    this.NewReadContext = newReadContext;
        //}

        //public IEnumerable<T> GetData<T>() where T : class
        //{
        //    //return this.Context.GenericModel.FromSqlRaw($"EXEC dbo.OBTestHello").ToList();

        //        //return Context.GenericModel.FromSqlRaw($"EXEC dbo.OBTestHello").ToList();

        //}

    }
}
