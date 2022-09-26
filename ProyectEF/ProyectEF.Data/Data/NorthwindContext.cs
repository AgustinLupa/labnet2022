using ProyectEF.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProyectEF.Data
{
    public partial class NorthwindContext : DbContext
    {

        public NorthwindContext()
            : base("name=NorthwindConnections")
        {
        }
        public virtual DbSet<Shippers> shippers { get; set; }               
        public virtual DbSet<Suppliers> suppliers { get; set; }        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
