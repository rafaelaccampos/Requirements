using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Requirements.Models;

namespace Requirements.Data
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .ToTable("address")
                .HasKey(a => a.Id);
             
            builder.Property(a => a.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(a => a.AddressLineTwo)
                .HasColumnName("address_line_two")
                .IsRequired();

            builder.Property(a => a.AddressType)
                .HasColumnName("type")
                .IsRequired();
  
            builder.Property(a => a.State)
                .HasColumnName("state")
                .IsRequired();
            
            builder.Property(a => a.City)
                .HasColumnName("city")
                .IsRequired();
            
            builder.Property(a => a.Neighborhood)
                .HasColumnName("neighborhood")
                .IsRequired();
            
            builder.Property(a => a.ZipCode)
                .HasColumnName("zip_code")
                .IsRequired();
        }
    }
}
