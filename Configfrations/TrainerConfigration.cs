using Microsoft.EntityFrameworkCore;
using MVC02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC02.Configfrations
{
    public class TrainerConfigration : GymUserConfigrations<Trainer> , IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(X => X.CreatedDate)
                  .HasColumnName("JoinDate")
                  .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
