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
    internal class SessionConfigration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(X => X.CreatedDate)
                 .HasDefaultValue("GETDATE()");

            builder.HasOne(X => X.Trainer)
                .WithMany(X => X.Sessions)
                .HasForeignKey(X => X.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(T => {
                T.HasCheckConstraint("SessionCapacityCheck", "Capacity Between 1 and 25");
                T.HasCheckConstraint("SessionEndDateAferStartDate","EndDate > StartDate");
            });
        }
    }
}
