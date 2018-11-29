using PinkApartments.PinkClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinkApartments
{
    public partial class EmployeeForm : Form
    {
        employeeClass ec = new employeeClass();

        public EmployeeForm()
        {
            InitializeComponent();

            DataTable dt = ec.Select();
            dgvEmployee.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ec.fname = fnameBox.Text;
            ec.lname = lnameBox.Text;
            ec.email = emailBox.Text;
            ec.hireDate = hiredateBox.Text;
            ec.salary = salaryBox.Text;
            ec.jobtitle = jobBox.Text;

            bool success = ec.Insert(ec);

            if (success == true)
            {
                MessageBox.Show("Added");
                DataTable dt = ec.Select();
                dgvEmployee.DataSource = dt;
            }
            else
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void dgvEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //used to fill out text field for updating info
            int rowIndex = e.RowIndex;
            empidBox.Text = dgvEmployee.Rows[rowIndex].Cells[0].Value.ToString();
            emailBox.Text = dgvEmployee.Rows[rowIndex].Cells[1].Value.ToString();
            jobBox.Text = dgvEmployee.Rows[rowIndex].Cells[2].Value.ToString();
            fnameBox.Text = dgvEmployee.Rows[rowIndex].Cells[3].Value.ToString();
            lnameBox.Text = dgvEmployee.Rows[rowIndex].Cells[4].Value.ToString();
            hiredateBox.Text = dgvEmployee.Rows[rowIndex].Cells[5].Value.ToString();
            salaryBox.Text= dgvEmployee.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ec.empID = int.Parse(empidBox.Text);
            ec.email = emailBox.Text;
            ec.fname = fnameBox.Text;
            ec.lname = lnameBox.Text;
            ec.email = emailBox.Text;
            ec.hireDate = hiredateBox.Text;
            ec.jobtitle = jobBox.Text;
            ec.salary = salaryBox.Text;

            bool success = ec.Update(ec);

            if (success == true)
            {
                MessageBox.Show("Updated.");
                DataTable dt = ec.Select();
                dgvEmployee.DataSource = dt;
            }
            else
            {
                MessageBox.Show("An error occurred.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empidBox.Text = "";
            fnameBox.Text = "";
            lnameBox.Text = "";
            salaryBox.Text = "";
            jobBox.Text = "";
            emailBox.Text = "";
            hiredateBox.Text = "";
        }
    }
}
