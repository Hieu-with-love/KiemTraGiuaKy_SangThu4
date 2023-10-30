using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// He thong quan ly nha hang.

namespace KiemTraGiuaKy_SangThu4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkItem dr1 = new DrinkItem("Coca-Cola", 12000);
            DrinkItem dr2 = new DrinkItem("Tra sua", 25000);
            DrinkItem dr3 = new DrinkItem("Ca phe", 15000);

            FoodItem fi1 = new FoodItem("Pizza", 100000);
            FoodItem fi2 = new FoodItem("Ga chien", 30000);
            FoodItem fi3 = new FoodItem("Khoai tay chien", 35000);
            FoodItem fi4 = new FoodItem("Lau thai", 150000);

            OnlineOrder<DrinkItem> order = new OnlineOrder<DrinkItem>();
            order.AddItem(dr1);
            order.AddItem(dr2);
            Console.WriteLine("Total order1 = " + order.getTotal());

            OnlineOrder<FoodItem> order2 = new OnlineOrder<FoodItem>();
            order2.AddItem(fi1);
            order2.AddItem(fi2);
            order2.getTotal();
            Console.WriteLine("Total order2 = " + order2.getTotal());

            DinelnOrder<DrinkItem> order3 = new DinelnOrder<DrinkItem>();
            order3.AddItem(dr3);
            order3.AddItem(dr2);
            order3.getTotal();
            Console.WriteLine("Total order3 = " + order3.getTotal());

            DinelnOrder<FoodItem> order4 = new DinelnOrder<FoodItem>();

            order4.AddItem(fi3);
            order4.AddItem(fi4);
            order4.getTotal();
            Console.WriteLine("Total order4 = " + order4.getTotal());

            Console.ReadKey();
        }
    }
}
