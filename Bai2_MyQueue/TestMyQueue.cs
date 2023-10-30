using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_MyQueue
{
    internal class TestMyQueue
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();
            DangKyThayDoiPhanTu sub = new DangKyThayDoiPhanTu();
            sub.Subscriber(myQueue);

            myQueue.enqueue(new Employee(123));
            myQueue.enqueue(new Employee(345));
            myQueue.enqueue(new Employee(123));

            myQueue.dequeue();
            myQueue.dequeue();
            myQueue.dequeue();

            Console.ReadKey();
        }
    }
}
