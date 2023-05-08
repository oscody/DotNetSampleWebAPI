using DataAccess_Interfaces.Models;

namespace DataAccess_Interfaces
{
    public interface  IProductsRepository : IGenericRepository<Product>
    {

        //IEnumerable<T> GetData<T>() where T : class;
    }
}
