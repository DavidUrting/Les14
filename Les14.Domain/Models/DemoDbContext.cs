using Microsoft.EntityFrameworkCore;

namespace Les14.Domain.Models
{
    public partial class DemoDbContext : DbContext
    {
        public const string DEV_CONN_STRING = "Data Source=mobyus-c0110129.database.windows.net;Initial Catalog=Demo;User ID=c0110129;Password=3435tXm7QSnx;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string _connString = null;

        public DemoDbContext()
        {
        }

        public DemoDbContext(string connString)
        {
            _connString = connString;
        }

        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Parent> ParentSet { get; set; }
        public virtual DbSet<Child> ChildSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (string.IsNullOrWhiteSpace(_connString))
                {
                    _connString = DEV_CONN_STRING;
                }
                optionsBuilder.UseSqlServer(_connString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("Parent", "Relations");
            });

            modelBuilder.Entity<Child>(entity =>
            {
                entity.ToTable("Child", "Relations");

                entity.HasOne(d => d.Parent)
                .WithMany(p => p.Children)
                .HasForeignKey(d => d.ParentID)
                .HasConstraintName("FK_B_A");
            });
        }
    }
}
