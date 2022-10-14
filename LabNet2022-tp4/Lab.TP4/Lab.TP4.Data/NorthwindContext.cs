using Lab.TP4.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab.TP4.Data
{
    public partial class NorthwindContext : DbContext, IDataConnection
    {
        public NorthwindContext()
            : base("name=NorthwindConnection")
        {
        }

        public virtual DbSet<Order_Details> order_Details { get; set; } //Mmmm raaaaro

        public virtual DbSet<Order_Details> GetOrder_Details()
        {
            return order_Details;
        }

        public virtual void SetOrder_Details(DbSet<Order_Details> value)
        {
            order_Details = value;
        }

        public virtual DbSet<Orders> orders { get; set; }

        public virtual DbSet<Orders> GetOrders()
        {
            return orders;
        }

        public virtual void SetOrders(DbSet<Orders> value)
        {
            orders = value;
        }

        public virtual DbSet<Products> products { get; set; }

        public virtual DbSet<Products> GetProducts()
        {
            return products;    
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Orders>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);
        }
    }
}
