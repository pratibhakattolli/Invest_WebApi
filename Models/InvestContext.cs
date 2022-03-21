using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Invest_WebApi.Models
{
    public partial class InvestContext : DbContext
    {
        public InvestContext()
        {
        }

        public InvestContext(DbContextOptions<InvestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Invest> Invest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=HP-SP\\SQLEXPRESS;Database=InvestApi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactNo).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(20);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.ProfilePic).HasMaxLength(50);

                entity.Property(e => e.TotalInvestment)
                    .HasColumnName("Total_Investment")
                    .HasColumnType("numeric(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
