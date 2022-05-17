using Microsoft.EntityFrameworkCore;

namespace DhartiMaaProject.Models
{
    public class DhartiMaaDbContext : DbContext
    {

        public DhartiMaaDbContext(DbContextOptions<DhartiMaaDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

    }
}
