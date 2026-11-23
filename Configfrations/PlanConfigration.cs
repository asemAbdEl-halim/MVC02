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
    public class PlanConfigration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(X => X.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.ToTable(T => {
                T.HasCheckConstraint("PlanDurationCheck","DurationDays Between 1 and 365");
            });
        }
    }
}
