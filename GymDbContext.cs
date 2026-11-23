using Microsoft.EntityFrameworkCore;
using MVC02.Configfrations;
using MVC02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC02
{
    public class GymDbContext : DbContext
    {
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Session> Sessions { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.\\SQLEXPRESS;Database=GymSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TrainerConfigration());
            modelBuilder.ApplyConfiguration(new MemberConfigration());
            modelBuilder.ApplyConfiguration(new PlanConfigration());
            modelBuilder.ApplyConfiguration(new MembershipConfigration());
            modelBuilder.ApplyConfiguration(new SessionConfigration());
        }
    }
}
