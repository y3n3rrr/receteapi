using System;
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

        public virtual DbSet<HekimIlac> HekimIlac { get; set; }
        public virtual DbSet<Il> Il { get; set; }
        public virtual DbSet<Ilac> Ilac { get; set; }
        public virtual DbSet<IlacKullanimSekli> IlacKullanimSekli { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<Rapor> Rapor { get; set; }
        public virtual DbSet<RaporTuru> RaporTuru { get; set; }
        public virtual DbSet<Recete> Recete { get; set; }
        public virtual DbSet<ReceteLog> ReceteLog { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleGroup> RoleGroup { get; set; }
        public virtual DbSet<UserInRole> UserInRole { get; set; }
        public virtual DbSet<Users> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=172.18.223.12,1434;Database=HSYSTEST;user id=HSYSTESTUser;password=Z1234xcv1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");
            
        }
    }
}
