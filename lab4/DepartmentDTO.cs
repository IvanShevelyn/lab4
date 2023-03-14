using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace lab4
{
    public class DepartmentDTO //Допоміжний клас для коректного збереження даних
    {
        public string ID { get; set; } 
        public string Name { get; set; }
        public List<Worker> workers { get; set; }
        public DepartmentDTO()
        {
            workers = new List<Worker>();  
        }
        public Department ToDepartment()
        {
            return new Department(ID, Name, workers);
        }
    }
}
