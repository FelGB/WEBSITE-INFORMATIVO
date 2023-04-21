using BackEnd_Portafolio.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Portafolio.Persistence.Context
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {
            
        }
    }
}
