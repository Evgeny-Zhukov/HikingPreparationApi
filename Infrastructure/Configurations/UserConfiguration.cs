using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id); 
            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(u => u.PasswordHash)
                .IsRequired();
            builder.Property(u => u.BirthDay)
                .IsRequired();
            builder.Property(u => u.CreatedAt)
                .IsRequired();
            builder.Property(u => u.UpdatedAt)
                .IsRequired();
            builder.Property(u => u.IsActive)
                .IsRequired();
        }
    }
}
