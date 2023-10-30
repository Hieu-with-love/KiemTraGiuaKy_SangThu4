using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_MyQueue_Generic
{
    public class DangKyThayDoiPhanTu<T> where T : Employee
    {
        public void Subscriber(MyQueue<T> obj)
        {
            obj.OnThayDoiPhanTu += HandleThayDoiPhanTu_Queue;
        }
        public void HandleThayDoiPhanTu_Queue(object sender, ThayDoiPhanTu_Queue e)
        {
            Console.WriteLine("Co mot su kien thay doi phan tu xay ra. Da xu ly voi su kien: " + e.ThongBao);
        }
    }
}
