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
    public partial class ChangeWorkerForm : Form
    {
        private Company company = new Company();
        private Worker worker = new Worker();
        public ChangeWorkerForm()
        {
            InitializeComponent();
        }
        public ChangeWorkerForm(Company Company, Worker wrk)
        {
            company = Company; 
            worker = wrk;
            InitializeComponent();
        }

        private void saveWorker_Click(object sender, EventArgs e)
        {
            try
            {
                worker.Salary = int.Parse(textBox2.Text);
                worker.FullName = textBox1.Text;
                Dispose();
            }
            catch { MessageBox.Show("Помилка! Будь-ласка перевірте правильність введених даних"); }
        }
        private void ChangeWorkerForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = worker.FullName;
            textBox2.Text = worker.Salary.ToString();
        }
    }
}
