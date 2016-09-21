using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.Repository.Map
{
    public class UserMap : EntityTypeConfiguration<Domain.User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Loign);

            // Properties
            this.Property(t => t.Name).IsRequired().HasMaxLength(100);
            this.Property(t => t.Password).IsRequired().HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("LojaDemo_User");
            this.Property(t => t.Loign).HasColumnName("Login");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Password).HasColumnName("Password");
        }
    }
}
