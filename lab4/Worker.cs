using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Worker
    {
        public string FullName { get; set; }
        private int _salary;
        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                    _salary = 0;
                else
                    _salary = value;
            }
        }
        public string DepartmentName { get; set; }
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public Worker() { } //default ctor
        public Worker(string fullName, int salary, string DepName) //ctor with params
        {
            FullName = fullName;
            Salary = salary;
            DepartmentName = DepName;
        }
    }
}
