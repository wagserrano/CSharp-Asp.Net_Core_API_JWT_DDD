using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class APIContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
//              Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
        }

    }
}
