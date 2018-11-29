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
    public partial class CreateContract : Form
    {
        contractClass cc = new contractClass();

        public CreateContract()
        {
            InitializeComponent();
            DataTable dt = cc.Select();
            dgvContract.DataSource = dt;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addResidentBtn_Click(object sender, EventArgs e)
        {
            //get the values
            if (empidBox.Text != "")
            {
                cc.empID = int.Parse(empidBox.Text);
                cc.fname = firstBox.Text;
                cc.lname = lastBox.Text;
                cc.email = emailAdBox.Text;
                cc.phone = phoneNumBox.Text;
                

                bool success = cc.InsertResident(cc);

                if (success == true)
                {
                    MessageBox.Show("Added");
                    DataTable dt = cc.SelectResident();
                    dgvNewRes.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("An error occurred");
                }
            }
            else
            {
                cc.fname = firstBox.Text;
                cc.lname = lastBox.Text;
                cc.email = emailAdBox.Text;
                cc.phone = phoneNumBox.Text;

                bool success = cc.InsertNoEmp(cc);

                if (success == true)
                {
                    MessageBox.Show("Added");
                    DataTable dt = cc.SelectResident();
                    dgvNewRes.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("An error occurred");
                }
            }
        }

        private void dgvNewRes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            resIDBox.Text = dgvNewRes.Rows[rowIndex].Cells[0].Value.ToString();
            cc.residentID = int.Parse(resIDBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            cc.apartmentNum = int.Parse(aptNumBox.Text);
            cc.startdate = startBox.Text;
            cc.enddate = endBox.Text;
            cc.price = rentBox.Text;
            cc.specials = specialsBox.Text;

            if(petsBox.Text.Equals("Yes"))
            {
                cc.pets = 1;
            } else
            {
                cc.pets = 0;
            }
            if (smokingBox.Text.Equals("Yes"))
            {
                cc.smoking = 1;
            }
            else
            {
                cc.smoking = 0;
            }


            bool success = cc.InsertContract(cc);

            if (success == true)
            {
                MessageBox.Show("Contract Created.");
                DataTable dt = cc.Select();
                dgvContract.DataSource = dt;
            }
            else
            {
                MessageBox.Show("An error occurred.");
            }
        }

        private void dgvContract_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            aptNumBox.Text = dgvNewRes.Rows[rowIndex].Cells[0].Value.ToString();
        }
    }
}
