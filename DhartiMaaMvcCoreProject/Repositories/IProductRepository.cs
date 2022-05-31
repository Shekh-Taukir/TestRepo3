using DhartiMaaMvcCoreProject.Models;

namespace DhartiMaaMvcCoreProject.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// This method will Add Product into Database using WebAPI
        /// </summary>
        /// <param name="product">product model for insert</param>
        /// <returns>Returns Boolean Value</returns>
        Task<bool> AddProduct(Product product);
    }
}
