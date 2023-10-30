using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiSo3_Collection
{
    public class Queue<V>
    {
        private LinkedList<V> queue;
        public Queue()
        {
            queue = new LinkedList<V>();
        }
        public void offer(V item)
        {
            queue.AddLast(item);
        }
        public void poll()
        {
            try
            {
                if (queue.Count == 0)
                    throw new Exception("Hang doi dang rong !");
                queue.RemoveFirst();
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
                if (queue.Count == 0)
                    throw new Exception("Hang doi dang rong !");
                return queue.First();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ngoai le dang gap: " + ex.Message);
                return default(V);
            }
        } 
        public bool isEmpty()
        {
            return queue.Count == 0;
        }
    }
}
