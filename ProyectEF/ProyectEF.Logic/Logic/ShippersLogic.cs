using ProyectEF.Data;
using ProyectEF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace ProyectEF.Logic
{
    public class ShippersLogic : BaseLogic ,ILogic <Shippers>
    {
        public void Add(Shippers item)
        {
            _context.shippers.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shipperToDelete = _context.shippers.Find(id);
            _context.shippers.Remove(shipperToDelete);
            _context.SaveChanges();
        }

        public List <Shippers> GetAll()
        {
            return _context.shippers.ToList();
        }
        
        public bool Exist(int id)
        {
            var shipperExist = _context.shippers.Find(id);
            if (shipperExist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Shippers GetShipper(int id)
        {
            List<Shippers> shippers = GetAll();
            foreach (var item in shippers)
            {
                if(item.ShipperID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Update(Shippers shippers)
        {
            var auxShipper = _context.shippers.Find(shippers.ShipperID);
            auxShipper.CompanyName = shippers.CompanyName;
            _context.SaveChanges();
        }
        
        public int GetIdLastShipper()
        {
            var query = _context.shippers.OrderByDescending(s=>s.ShipperID).Take(1);
            return query.First().ShipperID;                                    
        }
    }
}
