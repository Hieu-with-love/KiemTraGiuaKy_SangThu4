using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_MyQueue_Generic
{
    public delegate void UyThac_ThayDoiPhanTu(object sender, ThayDoiPhanTu_Queue e);
    public class MyQueue<T> where T : Employee
    {
        public event UyThac_ThayDoiPhanTu OnThayDoiPhanTu;
        LinkedList<T> myqueue;
        public MyQueue()
        {
            myqueue = new LinkedList<T>();
        }
        public void enqueue(T item)
        {
            if (myqueue.Any(e => e.EmployeeId == item.EmployeeId) || myqueue.Any(e => e == item))
            {
                OnThayDoiPhanTu?.Invoke(this, new ThayDoiPhanTu_Queue("Phan tu da ton tai trong danh sach. Khong them vao"));
                return;
            }
            myqueue.AddLast(item);
        }
        public void dequeue()
        {
            if (myqueue.Count == 0)
            {
                OnThayDoiPhanTu?.Invoke(this, new ThayDoiPhanTu_Queue("Danh sach dang rong. Khong loai bo"));
                return;
            }
            else
            {
                myqueue.RemoveFirst();
            }
        }
        public int peek()
        {
            try
            {
                if (myqueue.Count == 0)
                    throw new Exception("Danh sach dang rong !");
                else
                    return myqueue.First.Value.EmployeeId;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Ngoai le dang gap la: " + ex.Message);
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Ngoai le chua biet ro: " + ex1.Message);
            }
            return default(int);
        }
    }
}
