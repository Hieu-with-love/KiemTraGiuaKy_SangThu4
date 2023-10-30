using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiSo3_Collection
{
    public class Customer
    {
        private string name;
        private int age;
        public Customer(string name, int age)
        {
            this.name=name;
            this.age=age;
        }
        public override string ToString()
        {
            return $"[Name: {name}, Age: {age}]";
        }
    }
}
