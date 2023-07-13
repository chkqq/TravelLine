using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseProvider.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(p => p.ClientId);
            builder.Property(p => p.ClientId)
                .HasColumnName("ClientId")
                .IsRequired();
            builder.Property(p => p.ClientFirstName)
                .HasColumnName("ClientFirstName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(p => p.ClientLastName)
                .HasColumnName("ClientLastName")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}