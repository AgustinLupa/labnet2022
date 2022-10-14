using Lab.TP4.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TP4.Data
{
    public interface IDataConnection
    {
        DbSet<Order_Details> GetOrder_Details();

        DbSet<Orders> GetOrders();

        DbSet<Products> GetProducts();

        int SaveChanges();
    }
}
