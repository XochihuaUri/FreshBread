using Microsoft.EntityFrameworkCore;


namespace DB
{
    public class BakeryFreshBreadContext : DbContext
    {
        public BakeryFreshBreadContext(DbContextOptions<BakeryFreshBreadContext> options)
            : base(options)
        {

        }

        public DbSet<Office> Offices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<BreadOrder> BreadOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Office>().ToTable("Office");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<BreadOrder>().ToTable("BreadOrder");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BakeryFreshBreadDB");
        }
    }
}