using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectEF.Logic
{
    internal interface ILogic <T>
    {
        List<T> GetAll();
        void Add(T item);
        void Delete(int id);
        bool Exist(int id);
        void Update(T item);
    }
}
