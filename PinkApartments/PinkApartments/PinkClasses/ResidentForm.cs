using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinkApartments.PinkClasses
{
    public partial class ResidentForm : Form
    {
        residentClass rc = new residentClass();

        public ResidentForm()
        {
            InitializeComponent();
            DataTable dt = rc.Select();
            dgvResident.DataSource = dt;
        }

        
        private void addResBtn_Click(object sender, EventArgs e)
        {
            //get the values
            if(empidBox.Text != "")
            {
                rc.empID = int.Parse(empidBox.Text);
                rc.fname = fnameBox.Text;
                rc.lname = lnameBox.Text;
                rc.email = emailBox.Text;
                rc.phone = phoneBox.Text;

                bool success = rc.Insert(rc);

                if (success == true)
                {
                    MessageBox.Show("Added");
                    DataTable dt = rc.Select();
                    dgvResident.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("An error occurred");
                }
            } else
            {
                rc.fname = fnameBox.Text;
                rc.lname = lnameBox.Text;
                rc.email = emailBox.Text;
                rc.phone = phoneBox.Text;

                bool success = rc.InsertNoEmp(rc);

                if (success == true)
                {
                    MessageBox.Show("Added");
                    DataTable dt = rc.Select();
                    dgvResident.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("An error occurred");
                }
            }
            
         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvResident_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //used to fill out text field for updating info
            int rowIndex = e.RowIndex;
            residBox.Text = dgvResident.Rows[rowIndex].Cells[0].Value.ToString();
            empidBox.Text = dgvResident.Rows[rowIndex].Cells[1].Value.ToString();
            fnameBox.Text = dgvResident.Rows[rowIndex].Cells[3].Value.ToString();
            lnameBox.Text = dgvResident.Rows[rowIndex].Cells[4].Value.ToString();
            emailBox.Text = dgvResident.Rows[rowIndex].Cells[2].Value.ToString();
            phoneBox.Text = dgvResident.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(empidBox.Text != "")
            {
                rc.residentID = int.Parse(residBox.Text);
                rc.empID = int.Parse(empidBox.Text);
                rc.fname = fnameBox.Text;
                rc.lname = lnameBox.Text;
                rc.email = emailBox.Text;
                rc.phone = phoneBox.Text;

                bool success = rc.Update(rc);

                if (success == true)
                {
                    MessageBox.Show("Resident Updated.");
                    DataTable dt = rc.Select();
                    dgvResident.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("An error occurred.");
                }
            } else
            {
                rc.residentID = int.Parse(residBox.Text);
                rc.fname = fnameBox.Text;
                rc.lname = lnameBox.Text;
                rc.email = emailBox.Text;
                rc.phone = phoneBox.Text;

                bool success = rc.UpdateNoEmp(rc);

                if (success == true)
                {
                    MessageBox.Show("Resident Updated.");
                    DataTable dt = rc.Select();
                    dgvResident.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("An error occurred.");
                }
            }
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            residBox.Text = "";
            fnameBox.Text = "";
            lnameBox.Text = "";
            empidBox.Text = "";
            emailBox.Text = "";
            phoneBox.Text = "";
        }
    }
}
