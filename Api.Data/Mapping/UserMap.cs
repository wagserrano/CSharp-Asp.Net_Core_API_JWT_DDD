using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            // Table name
            builder.ToTable("User");

            // Defining PK
            builder.HasKey(x => x.Id);

            // Defining an Index with exclusivity
            builder.HasIndex(x => x.Email).IsUnique();

            // Defining Name properties in DB
            builder.Property(u => u.Name).IsRequired().HasMaxLength(60);

            // Defining Name properties in DB
            builder.Property(u => u.Email).HasMaxLength(100);
        }
    }
}
