using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResidentsForm
{
    public partial class Residents : Form
    {
        public Residents()
        {
            InitializeComponent();
        }

        FormClasses.formClass c = new FormClasses.formClass();

        /*private void Residents_Load(object sender, EventArgs e)
        {
            txtResidentID.Text = LookUpForm.id;
            txtEmailAddress.Text = LookUpForm.email;
            txtFirstName.Text = LookUpForm.fname;
            txtLastName.Text = LookUpForm.lname;
            txtAptNumber.Text = LookUpForm.num;
        }*/

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //method to clear out the fields
        private void clear()
        {
            txtResidentID.Text = "";
            txtEmailAddress.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAptNumber.Text = "";

        }
        

        public void setEmail(string s)
        {
            txtEmailAddress.Text = s;
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        //this method closes the residents form and reopens a new instance of the
        //admin welcome portal
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.Welcome w = new WindowsFormsApp1.Welcome();
            this.Close();
            w.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //get value from input fields
            c.EmailAddress = txtEmailAddress.Text;
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.AptNumber = txtAptNumber.Text;

            //insert data into database use add method from formClass.cs
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Resident Added Successfully.");
            }
            else
            {
                MessageBox.Show("Resident Not Added. ERROR.");
            }
           clear(); 
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            c.ResidentID = int.Parse(txtResidentID.Text);
            c.EmailAddress = txtEmailAddress.Text;
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.AptNumber = txtAptNumber.Text;

            //update data in db
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Updated Successfully.");
            }
            else
            {
                MessageBox.Show("ERROR. DID NOT UPDATE.");
            }
            clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //get data from data fields
            c.ResidentID = int.Parse(txtResidentID.Text);

            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Deleted Successfully.");
            }
            else
            {
                MessageBox.Show("Error. Could Not Delete.");
            }
            clear();
        }

        private void LookUp_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.LookUp look = new WindowsFormsApp1.LookUp();
            look.Show();
        }
    }
}
