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
        contractClass c = new contractClass();

        public CreateContract()
        {
            InitializeComponent();
            DataTable dt = c.Select();
            dgvContract.DataSource = dt;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //c.aptnum = Convert.ToInt32(aptNumBox.Text);
            c.fname = fnameBox.Text;
            c.lname = lnameBox.Text;
            //c.cardtype = cardtypeBox.Text;
            //c.cardnum = cardnumBox.Text;
            //c.baserent = Convert.ToInt32(rentBox.Text);
            c.email = emailBox.Text;
            c.phone = phoneBox.Text;
            //c.leaselen = Convert.ToInt32(leaselenBox.Text);
           // c.empid = Convert.ToInt32(empBox.Text);
            bool success = c.Insert(c);
            if(success == true)
            {
                MessageBox.Show("yes");
            } else
            {
                MessageBox.Show("no");
            }
        }
    }
}
