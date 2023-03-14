using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace lab4
{
    public class Department
    {
        private List<Worker> workers = new List<Worker>();
        public string NameOfDep { get; set; }
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public Department() { }
        public Department(string name) { NameOfDep = name; }
        public Department(string id, string Name, List<Worker> list) //ctor with params
        {
            ID = id;
            NameOfDep = Name;
            foreach (Worker worker in list)
            {
                workers.Add(worker);
            }
        }
        public IEnumerable<Worker> GetWorkers()
        {
            foreach (var item in workers)
            {
                yield return item;
            }
        }
        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }
        public bool RemoveWorker(Worker worker)
        {
            return workers.Remove(worker);
        }
        public DepartmentDTO ToDepartmnetEntity()
        {
            return new DepartmentDTO()
            {
                Name = NameOfDep,
                ID = this.ID,
                workers = GetWorkers().ToList()
            };
        }
    }
}
