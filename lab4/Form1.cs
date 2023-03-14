using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        Company company = new Company();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void addDepartment_Click(object sender, EventArgs e)
        {
            Department dep = new Department(textBox1.Text);
            company.AddDepartment(dep);
            UpdateDepartmentDataSource(company.GetDepartments().ToList());
        }
        private void AddWorker_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = GetSelectedDepartment();
                if (department == null)
                    return;

                var WorkerForm = new AddWorkerForm(department);
                WorkerForm.ShowDialog();
                UpdateWorkerDataSource(department.GetWorkers().ToList());
                UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
            }
            catch { MessageBox.Show("Something was wrong"); }
        }
        private void departmentDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Department department = GetSelectedDepartment();
                if (department == null)
                    return;

                textBox1.Text = department.NameOfDep;
                UpdateWorkerDataSource(department.GetWorkers().ToList());
            }
            catch { MessageBox.Show("Something was wrong"); }
        }
        private void deleteDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = GetSelectedDepartment();
                if (department == null)
                    return;

                company.RemoveDepartment(department.ID); 
                UpdateDepartmentDataSource(company.GetDepartments().ToList());
                departmentDataGridView.CurrentCell = null;
                workerDataGridView.DataSource = null;
                UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
            }
            catch { MessageBox.Show("Something was wrong"); }
        }
        private void deleteWorker_Click(object sender, EventArgs e)
        {
            try
            {
                Worker worker = GetSelectedWorker();
                if (worker == null)
                    return;

                Department department = GetSelectedDepartment();
                if (department == null)
                    return;

                company.RemoveWorkerFromDepartment(department.ID, worker);
                UpdateWorkerDataSource(department.GetWorkers().ToList());
                UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
            }
            catch { MessageBox.Show("Something was wrong"); }
        }
        private void changeNameOfDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = GetSelectedDepartment();
                if (department == null)
                    return;

                ChangeDepartmentNameForm ChangeNameOfDepForm = new ChangeDepartmentNameForm(company,department); 
                ChangeNameOfDepForm.ShowDialog();
                UpdateDepartmentDataSource(company.GetDepartments().ToList());
                departmentDataGridView.CurrentCell = null;
                workerDataGridView.DataSource = null;
                UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
            }
            catch { MessageBox.Show("Something was wrong"); }
        }
        private void changeWorker_Click(object sender, EventArgs e)
        {
            try
            {
                Worker worker = GetSelectedWorker();
                if (worker == null)
                    return;

                Department department = GetSelectedDepartment();
                if (department == null)
                    return;
                ChangeWorkerForm changeWorkerInfo = new ChangeWorkerForm(company,worker);
                changeWorkerInfo.ShowDialog();
                UpdateWorkerDataSource(department.GetWorkers().ToList());
                UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
            }
            catch { MessageBox.Show("Something was wrong"); }
        }

        #region Sort LINQ
        private void SortWorkersByName_Click(object sender, EventArgs e)
        {
            try
            {
                List<Worker> workers = new List<Worker>();
                if (ascendingNameCheckBox.Checked)
                    workers = company.GetAllWorkers().OrderBy(x => x.FullName).ToList();
                else
                    workers = company.GetAllWorkers().OrderByDescending(x => x.FullName).ToList();
                
                UpdateAllWorkerDataSource(workers);
            }
            catch { MessageBox.Show("Something was wrong"); }
        }
        private void SortWorkersBySalary_Click(object sender, EventArgs e)
        {
            try
            {
                List<Worker> workers = new List<Worker>();

                if (AscendingSalaryCheckBox.Checked)
                    workers = company.GetAllWorkers().OrderBy(x => x.Salary).ToList();
                else
                    workers = company.GetAllWorkers().OrderByDescending(x => x.Salary).ToList();

                UpdateAllWorkerDataSource(workers);
            }
            catch { MessageBox.Show("Something was wrong"); }
        }
        private void SortWorkersByDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                List<Worker> workers = new List<Worker>();
                workers = company.GetAllWorkers().OrderBy(x => x.DepartmentName).ToList();
                UpdateAllWorkerDataSource(workers);
            }
            catch { MessageBox.Show("Something was wrong"); }
        }
        #endregion

        #region Get department or worker
        private Department GetSelectedDepartment()
        {
            if (departmentDataGridView.SelectedRows.Count == 0)
                return null;
            return (Department)departmentDataGridView.SelectedRows[0].DataBoundItem;
        }
        private Worker GetSelectedWorker()
        {
            if (workerDataGridView.SelectedRows.Count == 0)
                return null;
            return (Worker)workerDataGridView.SelectedRows[0].DataBoundItem;
        }
        #endregion

        #region Methods for update tables
        private void UpdateDepartmentDataSource(List<Department> departments)
        {
            departmentDataGridView.DataSource = departments;
            departmentDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            departmentDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void UpdateWorkerDataSource(List<Worker> workers)
        {
            workerDataGridView.DataSource = workers;
            workerDataGridView.Columns.Remove(workerDataGridView.Columns[2]);
            workerDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            workerDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            workerDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void UpdateAllWorkerDataSource(List<Worker> AllWorkers)
        {
            AllWorkersDataGridView.DataSource = AllWorkers;
            AllWorkersDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AllWorkersDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AllWorkersDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            AllWorkersDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AllWorkersDataGridView.CurrentCell = null;
        }
        #endregion

        #region Save and Load methods
        private void SaveData_Click(object sender, EventArgs e) 
        { 
            company.SaveAll(); 
        }
        private void LoadData_Click(object sender, EventArgs e)
        {
            company.LoadAll();
            UpdateDepartmentDataSource(company.GetDepartments().ToList());
            UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
            departmentDataGridView.CurrentCell = null;
        }
        #endregion
    }
}
