using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseProvider.Configurations
{
    public class CarMechanicConfiguration : IEntityTypeConfiguration<CarMechanic>
    {
        public void Configure(EntityTypeBuilder<CarMechanic> builder)
        {
            builder.ToTable("CarMechanic").HasKey(r => r.CarMechanicId);
            builder.Property(r => r.CarMechanicId)
                .HasColumnName("CarMechanicId")
                .IsRequired();
            builder.Property(r => r.RepairCost)
                .HasColumnName("RepairCost")
                .IsRequired();
            builder.HasOne(r => r.Car).WithMany(d => d.CarMechanics).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(r => r.Client).WithMany(p => p.CarMechanics).OnDelete(DeleteBehavior.Cascade);
        }
    }
}