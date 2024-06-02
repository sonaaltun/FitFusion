using FitFusion.DAL.Configurations;
using FitFusion.Entity.Base;

using FitFusion.Entity.NewEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Context;

public class FitFusionDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<UserDetail> UserDetails { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryFood> FoodCategories { get; set; }
    public DbSet<Portion> Portions { get; set; }
    public DbSet<UserMeal> UserMeals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=BURAK\\SQLEXPRESS;Database=FitFusion;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
        }
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryFoodConfiguration());
        modelBuilder.ApplyConfiguration(new FoodConfiguration());
        modelBuilder.ApplyConfiguration(new PortionConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserDetailConfiguration());
        modelBuilder.ApplyConfiguration(new UserMealConfiguration());


        base.OnModelCreating(modelBuilder);
    }


    public override int SaveChanges()
    {
        SetBaseProp();
        return base.SaveChanges();
    }

    private void SetBaseProp()
    {
        var entries = ChangeTracker.Entries<BaseEntity>();
        foreach (var entry in entries)
        {
            SetIfAdded(entry);
            SetIfUpdated(entry);
            SetIfDeleted(entry);

        }

    
    }

    private void SetIfDeleted(EntityEntry<BaseEntity> entry)
    {
        if (entry.State == EntityState.Deleted)
        {
            entry.State = EntityState.Modified;
            entry.Entity.Statu = Entity.Enums.Statu.Deleted;
            entry.Entity.DeleteDate = DateTime.Now;
        }
    }

    private void SetIfUpdated(EntityEntry<BaseEntity> entry)
    {
        if (entry.State == EntityState.Modified)
        {
            entry.Entity.Statu = Entity.Enums.Statu.Updated;
            entry.Entity.UpdateDate = DateTime.Now;
        }
    }

    private void SetIfAdded(EntityEntry<BaseEntity> entry)
    {
        if(entry.State == EntityState.Added)
        {
            entry.Entity.Statu = Entity.Enums.Statu.Added;
            entry.Entity.CreateDate = DateTime.Now;
        }
    }
}
