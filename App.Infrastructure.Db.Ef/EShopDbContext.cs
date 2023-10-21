using App.Domain.Core.Shop.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Db.Ef
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<CustomAttributeTemplate> CustomAttributeTemplates { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderLine> OrderLines { get; set; }

        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<ProductCustomAttribute> ProductCustomAttributes { get; set; }

        public virtual DbSet<ProductInventory> ProductInventories { get; set; }

        public virtual DbSet<ProductPrice> ProductPrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<CustomAttributeTemplate>(entity =>
            {
                entity.Property(e => e.AttributeTitle).HasMaxLength(250);

                entity.HasOne(d => d.Category).WithMany(p => p.CustomAttributeTemplates)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderAt).HasColumnType("datetime");

                entity.HasOne(d => d.OrderStatus).WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderLine>(entity =>
            {
                entity.HasOne(d => d.Order).WithMany(p => p.OrderLines)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product).WithMany(p => p.orderLines)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Title).HasMaxLength(250);

                entity.HasOne(d => d.Category).WithMany(p => p.products)
                    .HasForeignKey(d => d.CategoryId);
            });

            modelBuilder.Entity<ProductCustomAttribute>(entity =>
            {
                entity.Property(e => e.AttributeTitle).HasMaxLength(250);
                entity.Property(e => e.AttributeValue).HasMaxLength(250);

                entity.HasOne(d => d.CustomAttributeTemplate).WithMany(p => p.ProductCustomAttributes)
                    .HasForeignKey(d => d.CustomAttributeTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product).WithMany(p => p.productCustomAttributes)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductInventory>(entity =>
            {
                entity.ToTable("ProductInventory");

                entity.Property(e => e.ActionAt).HasColumnType("datetime");

                entity.HasOne(d => d.Product).WithMany(p => p.ProductInventories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductPrice>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("datetime");
                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Product).WithMany(p => p.ProductPrices)
                    .HasForeignKey(d => d.ProductId);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
