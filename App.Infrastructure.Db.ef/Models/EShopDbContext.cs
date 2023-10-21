using App.Domain.Core.Shop.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Data.sql.ef.Models
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options): base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CustomAttributeTemplate> CustomAttributeTemplates { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderLine> OrderLines { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCustomAttribute> ProductCustomAttributes { get; set; }

        public DbSet<ProductInventory> ProductInventories { get; set; }

        public DbSet<ProductPrice> ProductPrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entites =>
            {
                entites.Property(x => x.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<CustomAttributeTemplate>(entites =>
            {
                entites.HasOne(x => x.Category)
                        .WithMany(x => x.CustomAttributeTemplates)
                        .HasForeignKey(x => x.CategoryId)
                        .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Order>(entites =>
            {
                entites.HasOne(x => x.OrderStatus).
                            WithMany(x => x.Orders).
                            HasForeignKey(x => x.OrderStatusId).
                            OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderLine>(entites =>
            {
                entites.HasOne(x => x.Order).
                        WithMany(x => x.OrderLines).
                        HasForeignKey(x => x.OrderId)
                        .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderStatus>(entites =>
            {
                entites.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Product>(entites =>
            {
                entites.HasOne(x => x.Category)
                        .WithMany(x => x.products)
                        .HasForeignKey(x => x.CategoryId)
                        .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductCustomAttribute>(entites =>
            {
                entites.Property(e => e.AttributeTitle).HasMaxLength(250);
                entites.Property(e => e.AttributeValue).HasMaxLength(250);

                entites.HasOne(d => d.CustomAttributeTemplate).WithMany(p => p.ProductCustomAttributes)
                    .HasForeignKey(d => d.CustomAttributeTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entites.HasOne(d => d.Product).WithMany(p => p.productCustomAttributes)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductInventory>(entites =>
            {
                entites.HasOne(x => x.Product)
                        .WithMany(x => x.ProductInventories)
                        .HasForeignKey(x => x.ProductId)
                        .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductPrice>(entites =>
            {
                entites.HasOne(x => x.Product)
                        .WithMany(x => x.ProductPrices)
                        .HasForeignKey(x => x.ProductId)
                        .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
