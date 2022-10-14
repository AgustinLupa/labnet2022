using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TP4.Logic
{
    public interface ILogic<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Add(T item);
        void Remove(T item);
        void Update(T item);
    }
}
