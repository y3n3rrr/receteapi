using System;
using EReceteAPI.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EReceteAPI.Database
{
    public partial class EReceteDBContext : DbContext
    {
        public EReceteDBContext()
        {
        }

        public EReceteDBContext(DbContextOptions<EReceteDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Recete> Recete { get; set; }
        public virtual DbSet<Ilac> Ilac { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Data Source=.;Database=ERecete;Persist Security Info=True;User ID=sa;Password=!123qwer;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Ilac>(entity =>
            {
                entity.ToTable("Ilac", "Skrs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(255);

                entity.Property(e => e.AdArama).HasMaxLength(500);

                entity.Property(e => e.AtcAd).HasMaxLength(255);

                entity.Property(e => e.AtcKod).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(255);

                entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RowGuid).HasMaxLength(36);

                entity.Property(e => e.SessionId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedSessionId).HasMaxLength(36);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "Yetkilendirme");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(255);

                entity.Property(e => e.CepTelefonu).HasMaxLength(255);

                entity.Property(e => e.DiplomaNo).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EsaglikPassword)
                    .HasColumnName("ESaglikPassword")
                    .HasMaxLength(255);

                entity.Property(e => e.MernisSifresi).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.Sgksifresi)
                    .HasColumnName("SGKSifresi")
                    .HasMaxLength(255);

                entity.Property(e => e.Soyad).HasMaxLength(255);

                entity.Property(e => e.TckimlikNo).HasColumnName("TCKimlikNo");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });
        }
    }
}
