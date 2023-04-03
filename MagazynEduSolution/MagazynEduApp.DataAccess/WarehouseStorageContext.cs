using Microsoft.EntityFrameworkCore;
using MagazynEduApp.DataAccess.Entities;

namespace MagazynEduApp.DataAccess
{
    public class WarehouseStorageContext : DbContext
    {
        public WarehouseStorageContext(DbContextOptions<WarehouseStorageContext> options)
            : base(options)
        { }

        DbSet<Book> Books { get; set; }
        DbSet<BookCase> BookCases { get; set; }
        DbSet<Author> Authors { get; set; }
    }
}
