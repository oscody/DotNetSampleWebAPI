using DataAccess_Interfaces;
using DataAccess.Models;
using Services_Interfaces;

namespace Services
{
    public class TestService : ITestService
    {
        private readonly IProductsRepository productsRepository;

        public TestService(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public async Task<Product> GetProduct(int? id)
        { 
            var product = await productsRepository.GetAsync(id);
            return product;
        }


    }
}