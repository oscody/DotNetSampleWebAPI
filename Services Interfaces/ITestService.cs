using DataAccess.Models;

namespace Services_Interfaces
{
    public interface ITestService
    {
        Task<Product> GetProduct(int? id);
    }
}