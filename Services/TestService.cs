using DataAccess_Interfaces;
using Services_Interfaces;
using Services_Interfaces.Models;

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
            var svcProduct = new Services_Interfaces.Models.Product()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description, 
                Price = product.Price  
            };
            return svcProduct;
        }


    }
}