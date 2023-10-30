using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraGiuaKy_SangThu4
{
    public abstract class AbstractItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public AbstractItem(string name, double price)
        {
            Name=name;
            Price=price;
        }
    }
}
