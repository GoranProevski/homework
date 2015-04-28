using Register.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.DataLayer.models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            //primary key
            this.HasKey(u => u.UserID);

            //properties
            this.Property(u => u.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(u => u.CityAddress)
                .HasMaxLength(40);

            this.Property(u => u.ContactNumber)
                .HasMaxLength(15);

            //Table and column mappings
            this.ToTable("Users");
            this.Property(u => u.UserID).HasColumnName("UserId");
            this.Property(u => u.UserName).HasColumnName("UserName");
            this.Property(u => u.FirstName).HasColumnName("FirstName");
            this.Property(u => u.LastName).HasColumnName("LastName");
            this.Property(u => u.CityAddress).HasColumnName("CityAddress");
            this.Property(u => u.ContactNumber).HasColumnName("ContactNumber");

        }
    }
}
