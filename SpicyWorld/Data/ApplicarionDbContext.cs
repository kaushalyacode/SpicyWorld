using Microsoft.EntityFrameworkCore;

namespace SpicyWorld.Data
{
    public class ApplicarionDbContext : DbContext
    {
        public ApplicarionDbContext(DbContextOptions<ApplicarionDbContext> options):base(options) { }
       
    }
}
