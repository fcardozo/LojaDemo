using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.Repository.Map
{
    public class CategoryMap : EntityTypeConfiguration<Domain.Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name).IsRequired().HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("LojaDemo_Category");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
