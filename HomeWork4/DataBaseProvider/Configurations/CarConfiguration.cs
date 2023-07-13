using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseProvider.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car").HasKey(d => d.CarId);
            builder.Property(d => d.CarId)
                .HasColumnName("CarId")
                .IsRequired();
            builder.Property(d => d.CarName)
                .HasColumnName("CarName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(d => d.HorsePower)
                .HasColumnName("HorsePower")
                .IsRequired();
            builder.Property(d => d.TypeOfRepair)
                .HasColumnName("TypeOfRepair")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}