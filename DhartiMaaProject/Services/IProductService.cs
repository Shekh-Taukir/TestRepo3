using DhartiMaaProject.Models;

namespace DhartiMaaProject.Services
{
    public interface IProductService
    {
        Task<string> InsertProduct(Product product);
    }
}
