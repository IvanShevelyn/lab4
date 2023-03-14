using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace lab4
{
    public class Company
    {
        private const string filePath = "Company.json";
        private List<Department> listOfDep = new List<Department>();
        public IEnumerable<Department> GetDepartments()
        {
            foreach (var item in listOfDep)
            {
                yield return item;
            }
        }
        public void AddDepartment(Department department)
        {
            if (listOfDep.Any(x => x.ID == department.ID))
            {
                MessageBox.Show("Вже існує відділ із таким самим ID!");
                return;
            }
            else if (listOfDep.Any(x => x.NameOfDep == department.NameOfDep))
            {
                MessageBox.Show("Вже існує відділ із такою назвою!");
                return;
            }
            listOfDep.Add(department);
        }
        public void RemoveDepartment(string id)
        {
            Department departmentToDelete = listOfDep.FirstOrDefault(x => x.ID == id);

            if (departmentToDelete == null)
            {
                MessageBox.Show($"Немає відділу із таким ID: {id}");
                return;
            }
            listOfDep.Remove(departmentToDelete);
        }
        public List<Worker> GetAllWorkers()
        {
            List<Worker> workers = new List<Worker>();  
            foreach (Department item in listOfDep)
            {
                List<Worker> depWorker = new List<Worker>();
                depWorker = item.GetWorkers().ToList();
                foreach (Worker worker in depWorker) 
                {
                    workers.Add(worker);
                }
            }
            return workers;
        }
        public bool ChangeDepartment(string name)
        {
            if(listOfDep.Any(x => x.NameOfDep == name))
            {
                MessageBox.Show("Вже існує відділ із такою назвою!");
                return false;
            }
            return true;
        }
        public void RemoveWorkerFromDepartment(string departmentId, Worker worker)
        {
            Department department = listOfDep.FirstOrDefault(x => x.ID == departmentId);
            if (department == null)
            {
                MessageBox.Show($"Немає відділу із таким ID: {departmentId}");
                return;
            }
            bool result = department.RemoveWorker(worker);
            if (result == false)
            {
                MessageBox.Show($"Не знайдено робітника із таким ID: {worker.ID}");
                return;
            }
        }
        public void LoadAll()
        {
            listOfDep.Clear();
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                try
                {
                    List<DepartmentDTO> departments = JsonSerializer.Deserialize<List<DepartmentDTO>>(stream);
                    foreach (DepartmentDTO departmentEntity in departments)
                        listOfDep.Add(departmentEntity.ToDepartment());
                }
                catch { MessageBox.Show("Файл містить некоректні дані!"); }
            }
        }
        public void SaveAll()
        {
            List<DepartmentDTO> departments = new List<DepartmentDTO>();
            foreach (Department item in listOfDep)
            {
                DepartmentDTO dep = item.ToDepartmnetEntity();
                departments.Add(dep);
            }
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                JsonSerializer.Serialize<List<DepartmentDTO>>(stream, departments);
            }
            MessageBox.Show("Збережено!");
        }
    }
}
