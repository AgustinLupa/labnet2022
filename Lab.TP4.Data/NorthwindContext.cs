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
       

        public virtual DbSet<Products> products { get; set; }

        public virtual DbSet<Products> GetProducts()
        {
            return products;    
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
        }
    }
}
