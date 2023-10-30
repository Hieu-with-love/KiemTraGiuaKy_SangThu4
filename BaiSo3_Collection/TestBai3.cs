using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiSo3_Collection
{
    internal class TestBai3
    {
        static void Main(string[] args)
        {
            Stack<Customer> st = new Stack<Customer>();
            st.push(new Customer("Nguyen Van A", 19));
            st.push(new Customer("Tran Thi B", 25));
            st.push(new Customer("Le Minh C", 30));
            Console.WriteLine("Element in stack: ");
            while (!st.isEmpty())
            {
                Console.WriteLine(st.peek());
                st.pop();
            }

            Queue<Customer> q = new Queue<Customer>();
            q.offer(new Customer("Nguyen Hoang T", 24));
            q.offer(new Customer("Pham Minh A", 23));
            q.offer(new Customer("Phan Minh T", 19));
            Console.WriteLine("Element in queue:");
            while (!q.isEmpty())
            {
                Console.WriteLine(q.peek());
                q.poll();
            }

            Console.ReadKey();
        }
    }
}
