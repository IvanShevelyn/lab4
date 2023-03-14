using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class AddWorkerForm : Form
    {
        private Department dep = new Department();
        public AddWorkerForm()
        {
            InitializeComponent();
        }
        public AddWorkerForm(Department department)
        {
            dep = department;
            InitializeComponent();
        }

        private void Add_Worker_Click(object sender, EventArgs e)
        {
            try
            {
                int salary = int.Parse(textBox2.Text);
                Worker worker = new Worker(textBox1.Text, salary, dep.NameOfDep);
                dep.AddWorker(worker);
                Dispose();
            }
            catch { MessageBox.Show("Помилка! Будь-ласка перевірте правильність введених даних"); }
        }
    }
}
