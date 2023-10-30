using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_MyQueue_Generic
{
    public class ThayDoiPhanTu_Queue : EventArgs
    {
        private string thongbao;
        public string ThongBao { get { return thongbao; } }
        public ThayDoiPhanTu_Queue(string thongbao)
        {
            this.thongbao=thongbao;
        }
    }
}
