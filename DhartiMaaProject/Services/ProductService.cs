using DhartiMaaProject.Models;
using DhartiMaaProject.Repository;

namespace DhartiMaaProject.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<string> InsertProduct(Product product)
        {
            return await productRepository.AddProduct(product);
        }
    }
}
