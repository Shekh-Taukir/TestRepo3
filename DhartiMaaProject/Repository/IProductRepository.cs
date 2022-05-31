using DhartiMaaProject.Models;
using System.Threading.Tasks;

namespace DhartiMaaProject.Repository
{
    public interface IProductRepository
    {
        Task<string> AddProduct(Product product);
    }
}
