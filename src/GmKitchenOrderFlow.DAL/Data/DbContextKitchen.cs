using GmKitchenOrderFlow.Domain;
using GmKitchenOrderFlow.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace GmKitchenOrderFlow.DAL;

public class DbContextKitchen: DbContext
{
    public DbContextKitchen(DbContextOptions<DbContextKitchen> options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<ItemOrder> ItemOrders { get; set; }
    public DbSet<MenuItemMeal> MenuItems { get; set; }
    public DbSet<MenuItemKitchenRoutingMap> MenuItemKitchenRoutingMaps { get; set; }
    public DbSet<KitchenArea> KitchenAreas { get; set; }
    public DbSet<Queue> Queues { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<MenuItemKitchenRoutingMap>()
            .HasOne(m => m.MenuItem)
            .WithMany(m => m.KitchenRoutingMaps)
            .HasForeignKey(m => m.MenuItemMealId);

        modelBuilder.Entity<MenuItemKitchenRoutingMap>()
            .HasOne(m => m.Queue)
            .WithMany(m => m.MenuItemRouted)
            .HasForeignKey(m => m.QueueId);

        modelBuilder.Entity<MenuItemKitchenRoutingMap>()
            .HasKey(m => new { m.MenuItemMealId, m.QueueId });

        modelBuilder.Entity<MenuItemKitchenRoutingMap>()
            .Property(m => m.Priority)
            .IsRequired(true);
        
        modelBuilder.Entity<Order>()
            .HasKey(m => m.Id);

        modelBuilder.Entity<Order>()
            .HasMany(m => m.Items)
            .WithOne(m => m.Order)
            .HasForeignKey(m => m.OrderId);

        modelBuilder.Entity<Order>()
            .Property(m => m.OrderNumber)
            .HasMaxLength(6)
            .IsRequired(true);

        modelBuilder.Entity<Order>()
            .Property(m => m.CreatedAt);

        modelBuilder.Entity<Queue>()
            .HasKey(m => new { m.Id,});

        modelBuilder.Entity<Queue>()
            .Property(m => m.Name)
            .HasMaxLength(255)
            .IsRequired(true);

        modelBuilder.Entity<Queue>()
            .Property(m => m.CreatedAt);

        modelBuilder.Entity<Queue>()
            .HasMany(m => m.MenuItemRouted)
            .WithOne(m => m.Queue)
            .HasForeignKey(m => m.QueueId);

        modelBuilder.Entity<Queue>()
            .HasMany(m => m.ItemOrders)
            .WithOne(m => m.QueueCurrent)
            .HasForeignKey(m => m.QueueCurrentId);

        modelBuilder.Entity<ItemOrder>()
            .HasKey(m => new { m.OrderId, m.MenuItemId });

        modelBuilder.Entity<ItemOrder>()
            .HasMany<Queue>(m => m.Queues)
            .WithOne();

        modelBuilder.Entity<ItemOrder>()
            .HasOne(m => m.QueueCurrent)
            .WithMany(m => m.ItemOrders)
            .HasForeignKey(m => m.QueueCurrentId);

        modelBuilder.Entity<ItemOrder>()
            .HasOne(m => m.MenuItem)
            .WithMany()
            .HasForeignKey(m => m.MenuItemId);

        modelBuilder.Entity<ItemOrder>()
            .HasOne(m => m.Order)
            .WithMany(m => m.Items)
            .HasForeignKey(m => m.OrderId);

        modelBuilder.Entity<ItemOrder>()
            .Property(m => m.Status)
            .IsRequired(true);

        modelBuilder.Entity<ItemOrder>()
            .Property(m => m.Quantity)
            .IsRequired(true);

        modelBuilder.Entity<MenuItemMeal>()
            .HasKey(m => m.Id);

        modelBuilder.Entity<MenuItemMeal>()
            .Property(m => m.Name)
            .HasMaxLength(255)
            .IsRequired(true);

        modelBuilder.Entity<MenuItemMeal>()
            .Property(m => m.Description)
            .HasMaxLength(255)
            .IsRequired(true);

        modelBuilder.Entity<MenuItemMeal>()
            .Property(m => m.Price)
            .IsRequired(true);

        modelBuilder.Entity<MenuItemMeal>()
            .HasMany(m => m.Composition)
            .WithMany()
            .UsingEntity<Dictionary<string, object>>("MenuItemComposition",
                j => j.HasOne<MenuItemMeal>().WithMany().HasForeignKey("MenuItemId"),
                j => j.HasOne<MenuItemMeal>().WithMany().HasForeignKey("CompositionId"));;

        modelBuilder.Entity<MenuItemMeal>()
            .HasMany(m => m.KitchenRoutingMaps)
            .WithOne(m => m.MenuItem)
            .HasForeignKey(m => m.MenuItemMealId);

        modelBuilder.Entity<KitchenArea>()
            .HasKey(m => m.Id);

        modelBuilder.Entity<KitchenArea>()
            .Property(m => m.Name)
            .HasMaxLength(80)
            .IsRequired(true);

        modelBuilder.Entity<KitchenArea>()
            .Property(m => m.Status)
            .IsRequired(true);

        modelBuilder.Entity<KitchenArea>()
            .Property(m => m.CreatedAt);

        modelBuilder.Entity<KitchenArea>()
            .Property(m => m.Description)
            .HasMaxLength(155)
            .IsRequired(true);

        modelBuilder.Entity<KitchenArea>()
            .HasOne(m => m.Queue)
            .WithOne()
            .HasForeignKey<Queue>(m => m.KitchenAreaId);

        modelBuilder.Entity<KitchenArea>()
            .Property(m => m.QueueId)
            .IsRequired(true);

    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateAuditableEntities();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void UpdateAuditableEntities()
    {
        var entries = ChangeTracker.Entries<EntityBaseRoot<long>>();
        var now = DateTime.UtcNow;

        foreach (var entry in entries)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedAt = now;
                    entry.Entity.UpdatedAt = now;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedAt = now;
                    break;
            }
        }
    }
}
