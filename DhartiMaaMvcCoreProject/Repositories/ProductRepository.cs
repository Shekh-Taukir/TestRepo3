using DhartiMaaMvcCoreProject.Helper;
using DhartiMaaMvcCoreProject.Models;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace DhartiMaaMvcCoreProject.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DhartiMaaAPI _api = new();

        private readonly HttpClient httpClient;
        public ProductRepository()
        {
            httpClient = _api.Initial();
        }

        public async Task<bool> AddProduct(Product product)
        {
            using (var content = new ObjectContent<Product>(product, new JsonMediaTypeFormatter()))
            {
                var response = await this.httpClient.PostAsync(CommonConstant.AddProductRoute, content);
                if (response == null || !response.IsSuccessStatusCode)
                {
                    return false;
                }
                return response.IsSuccessStatusCode;
            }
        }
    }
}
