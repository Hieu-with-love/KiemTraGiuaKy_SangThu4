using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGTP_Bai3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Bai2_MyQueue
    {

        public class DangKyThayDoiPhanTu<T>
        {
            public void Subscriber(MyQueue<T> obj)
            {
                obj.OnThayDoiPhanTu += HandleThayDoiPhanTu_Queue;
            }

            public void HandleThayDoiPhanTu_Queue(object sender, ThayDoiPhanTu_Queue<T> e)
            {
                Console.WriteLine("Có một sự kiện thay đổi phần tử xảy ra. Đã xử lý với sự kiện: " + e.ThongBao);
            }
        }

        public class Employee
        {
            private int employee_id;
            public int EmployeeId { get { return employee_id; } set { employee_id = value; } }

            public Employee(int id)
            {
                this.employee_id = id;
            }
        }

        public delegate void UyThac_ThayDoiPhanTu<T>(object sender, ThayDoiPhanTu_Queue<T> e);

        public class MyQueue<T>
        {
            public event UyThac_ThayDoiPhanTu<T> OnThayDoiPhanTu;
            LinkedList<T> myqueue;

            public MyQueue()
            {
                myqueue = new LinkedList<T>();
            }

            public void Enqueue(T item)
            {
                if (myqueue.Any(e => e.Equals(item)))
                {
                    OnThayDoiPhanTu?.Invoke(this, new ThayDoiPhanTu_Queue<T>("Phần tử đã tồn tại trong danh sách. Không thêm vào"));
                    return;
                }
                myqueue.AddLast(item);
            }

            public void Dequeue()
            {
                if (myqueue.Count == 0)
                {
                    OnThayDoiPhanTu?.Invoke(this, new ThayDoiPhanTu_Queue<T>("Danh sách đang rỗng. Không loại bỏ"));
                    return;
                }
                else
                {
                    myqueue.RemoveFirst();
                }
            }

            public T Peek()
            {
                try
                {
                    if (myqueue.Count == 0)
                        throw new Exception("Danh sách đang rỗng !");
                    else
                        return myqueue.First.Value;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Ngoại lệ đang gặp là: " + ex.Message);
                }
                catch (Exception ex1)
                {
                    Console.WriteLine("Ngoại lệ chưa biết rõ: " + ex1.Message);
                }
                return default(T);
            }
        }

        public class ThayDoiPhanTu_Queue<T> : EventArgs
        {
            private string thongbao;
            public string ThongBao { get { return thongbao; } }

            public ThayDoiPhanTu_Queue(string thongbao)
            {
                this.thongbao = thongbao;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;

                MyQueue<string> myQueue = new MyQueue<string>();
                MyQueue<int> myQueue1 = new MyQueue<int>();
                MyQueue<Employee> myQueue2 = new MyQueue<Employee>();

                DangKyThayDoiPhanTu<string> substr = new DangKyThayDoiPhanTu<string>();
                substr.Subscriber(myQueue);

                myQueue.Enqueue("Hieu");
                myQueue.Enqueue("FA");
                myQueue.Enqueue("Hieu");
                myQueue.Enqueue("FA");

                myQueue.Dequeue();
                myQueue.Dequeue();
                myQueue.Dequeue();

                Console.ReadKey();
            }
        }
    }
}
