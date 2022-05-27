using DhartiMaaProject.Models;
using log4net;

namespace DhartiMaaProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        private static readonly ILog Logger = LogManager.GetLogger("ProductRepository");

        private DMDBContext dMDB;

        public ProductRepository(DMDBContext dMDBContext)
        {
            this.dMDB = dMDBContext;
        }

        public async Task<string> AddProduct(Product product)
        {
            try
            {
                product.CreatedAt = DateTime.Now;
                await dMDB.Products.AddAsync(product);
                var dbResult = await dMDB.SaveChangesAsync();
                return dbResult.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw new Exception(ex.Message);
            }
        }

    }
}
