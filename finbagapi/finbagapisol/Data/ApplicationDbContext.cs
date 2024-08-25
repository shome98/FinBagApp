using Microsoft.EntityFrameworkCore;

namespace finbagapisol.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }
    }
}
