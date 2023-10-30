using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraGiuaKy_SangThu4
{
    public class Order<T> : IOrder<T> where T : AbstractItem
    {
        private List<T> items;
        public Order()
        {
            items = new List<T>();
        }
        public void AddItem(T item)
        {
            items.Add(item);
        }

        public double getTotal()
        {
            double total = 0;
            foreach(var item in items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
