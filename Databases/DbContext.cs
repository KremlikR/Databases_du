
public class DbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    private String a = "Server=193.85.203.188;Database=kremlik;User=kremlik;Password=pzoMWfFn_22;";


	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(this.a);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // konfigurace vazeb a dalších vlastností
    }
}