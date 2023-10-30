using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiSo3_Collection
{
    public class Stack<V>
    {
        private LinkedList<V> stack;
        public Stack()
        {
            stack = new LinkedList<V>();
        }
        public void push(V item)
        {
            stack.AddFirst(item);
        }
        public void pop()
        {
            try
            {
                if (stack.Count == 0)
                {
                    throw new Exception("Stack dang rong !");
                }
                stack.RemoveFirst();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ngoai le dang gap la: " + ex.Message);
            }
        }
        public V peek()
        {
            try
            {
                if (stack.Count == 0)
                    throw new Exception("Stack dang rong !");
                return stack.First();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ngoai le dang gap la: " + ex.Message);
                return default(V);
            }
        }
        public bool isEmpty()
        {
            return stack.Count == 0;
        }
    }
}
