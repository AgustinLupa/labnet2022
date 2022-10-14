using Lab.TP4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TP4.Logic
{
    public abstract class BaseLogic<T> : ILogic<T>
    {
        protected readonly IDataConnection _context;

        public BaseLogic(IDataConnection context)
        {
            _context = context;
        }

        public abstract void Add(T item);

        public abstract List<T> GetAll();

        public abstract T GetById(int id);

        public abstract void Remove(T id);

        public abstract void Update(T item);
    }
}
