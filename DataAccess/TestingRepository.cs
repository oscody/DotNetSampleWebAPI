using DataAccess_Interfaces;
using Microsoft.EntityFrameworkCore;


namespace DataAccess
{
    public class TestingRepository 
    {
        TestContext Context { get; set; }

        Func<TestContext> NewReadContext { get; set; }

        internal TestingRepository(TestContext context, Func<TestContext> newReadContext)
        {
            this.Context = context;
            this.NewReadContext = newReadContext;
        }

        //private IEnumerable<T> GetData<T>() where T : class {

        //    using (TestContext context = NewReadContext())
        //    {
        //        return context.GenericModel.GenericModel.FromSqlRaw($"EXEC dbo.OBTestHello").ToList();
        //    }
        //}


    }
}
