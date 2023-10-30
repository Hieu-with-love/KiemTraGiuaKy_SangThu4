using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_MyQueue_Generic
{
    public class Employee
    {
        private int employee_id;
        public int EmployeeId { get { return employee_id; } set { employee_id = value; } }
        public Employee(int id)
        {
            this.employee_id = id;
        }
    }
}
