using com.prueba.jair.DAL.entities;
using Microsoft.EntityFrameworkCore;

namespace com.prueba.jair.DAL.context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) {}

        public DbSet<Enterprise> Enterprises {get; set;}
        public DbSet<Code> Code { get; set;}
    }
}
