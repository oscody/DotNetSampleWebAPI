using DataAccess.Models;
using DataAccess_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ProductRepository : GenericRepository<Product>
    {
        TestContext Context { get; set; }

        Func<TestContext> NewReadContext { get; set; }

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

        //    //using (TestContext context = NewReadContext())
        //    //{
        //    //    return context.Ge.Set<T>().FromSqlRaw($"EXEC dbo.OBTestHello").ToList();
        //    //}

        //    throw new NotImplementedException();
        //}

    }
}
