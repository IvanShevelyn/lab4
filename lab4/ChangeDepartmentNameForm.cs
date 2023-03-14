using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4
{
    public partial class ChangeDepartmentNameForm : Form
    {
        private Company company = new Company();
        private Department dep = new Department();
        public ChangeDepartmentNameForm()
        {
            InitializeComponent();
        }
        public ChangeDepartmentNameForm(Company Company,Department department)
        {
            company = Company;  
            dep = department;
            InitializeComponent();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (company.ChangeDepartment(textBox1.Text))
            {
                dep.NameOfDep = textBox1.Text;
                foreach (var item in dep.GetWorkers())
                    item.DepartmentName = dep.NameOfDep;
            }
            Dispose();
        }
    }
}
