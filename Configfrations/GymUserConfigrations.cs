using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC02.Configfrations
{
    public class GymUserConfigrations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(g => g.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(g => g.Email)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(g => g.Phone)
                   .HasColumnType("varchar")
                   .HasMaxLength(11);

            builder.ComplexProperty(g => g.Address);

            builder.HasIndex(g => g.Email).IsUnique();
            builder.HasIndex(g => g.Phone).IsUnique();

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_EmailCheck", "Email Like'%@%.com'");
                T.HasCheckConstraint("GymUser_PhoneCheck" , "LEN(Phone) = 11 AND (Phone Like'010%' OR Phone Like'011%' OR Phone Like'012%' OR Phone Like'015%')"); 

            });
        }
    }
}
