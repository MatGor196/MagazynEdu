using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MagazynEduApp.DataAccess
{
    public class WarehouseStorageContextFactory : IDesignTimeDbContextFactory<WarehouseStorageContext>
    {
        public WarehouseStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WarehouseStorageContext>();

            var WarehouseStorageConntectionString = "Data Source=MOJ-LAPTOP;Initial Catalog=WarehouseStorage;Integrated Security=True;Encrypt=False";
            optionsBuilder.UseSqlServer(WarehouseStorageConntectionString);

            return new WarehouseStorageContext(optionsBuilder.Options);
        }
    }
}