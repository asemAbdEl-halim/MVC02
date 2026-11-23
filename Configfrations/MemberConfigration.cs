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
    public class MemberConfigration : GymUserConfigrations<Member> , IEntityTypeConfiguration<Member> 
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(X => X.CreatedDate)
                  .HasColumnName("JoinDate")
                  .HasDefaultValue("GETDATE()");

            base.Configure(builder);
        }
    }
}
