using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TP4.Utils.ExtensionMethods
{
    public static class DecimalExtensions
    {
        public static decimal Round(this decimal number)
        {
            return Math.Round(number, 2);
        }
    }
}
