using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_MyQueue
{
    public delegate void UyThac_ThayDoiPhanTu(object sender, ThayDoiPhanTu_Queue e);
    public class MyQueue
    {
        public event UyThac_ThayDoiPhanTu OnThayDoiPhanTu;
        LinkedList<Employee> myqueue;
        public MyQueue()
        {
            myqueue = new LinkedList<Employee>();
        }
        public void enqueue(Employee employee)
        {
            if (myqueue.Any(e => e.EmployeeId == employee.EmployeeId))
            {
                OnThayDoiPhanTu?.Invoke(this, new ThayDoiPhanTu_Queue("Phan tu da ton tai trong danh sach. Khong them vao"));
                return;
            }
            myqueue.AddLast(employee);
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
