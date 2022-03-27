using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GeeksBankAPI.DAL
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Request> Request { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=sql5107.site4now.net;User ID=db_a427b7_prestti_admin;Password=l4gun4w1ls0n777;Initial Catalog=db_a427b7_prestti;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.IdRequest);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IpOrigen).HasMaxLength(50);

                entity.Property(e => e.Numero1).HasColumnType("decimal(25, 0)");

                entity.Property(e => e.Numero2).HasColumnType("decimal(25, 0)");

                entity.Property(e => e.Resultado).HasColumnType("decimal(25, 0)");

                entity.Property(e => e.Usuario).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
