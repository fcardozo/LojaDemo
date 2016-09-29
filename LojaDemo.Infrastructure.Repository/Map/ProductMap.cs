using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.Repository.Map
{
    public class ProductMap : EntityTypeConfiguration<Domain.Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name).IsRequired().HasMaxLength(100);
            this.Property(t => t.FullPrice).IsRequired();
            this.Property(t => t.DiscountPrice).IsRequired();
            this.Property(t => t.IsPromotion).IsRequired();

            this.HasRequired(t => t.Category)
              .WithMany(t => t.Products)
              .HasForeignKey(f => f.IdCategory).WillCascadeOnDelete();

            // Table & Column Mappings
            this.ToTable("LojaDemo_Product");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.FullPrice).HasColumnName("FullPrice");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.IsPromotion).HasColumnName("IsPromotion");
        }
    }
}
