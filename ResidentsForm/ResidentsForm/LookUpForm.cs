using ResidentsForm.FormClasses;
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
    public partial class LookUpForm : Form
    {
        public static string id = "";
        public static string email = "";
        public static string fname = "";
        public static string lname = "";
        public static string num = "";
        public LookUpForm()
        {
            InitializeComponent();
            showDGV();
        }
        FormClasses.formClass c = new FormClasses.formClass();
        

        private void showDGV()
        {
            DataTable dt = c.Select();
            dgvResidentList.DataSource = dt;
        }
            
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dgvResidentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data from row
            int rowIndex = e.RowIndex;
            
            id = dgvResidentList.Rows[rowIndex].Cells[0].Value.ToString();
            email = dgvResidentList.Rows[rowIndex].Cells[1].Value.ToString();
            fname = dgvResidentList.Rows[rowIndex].Cells[2].Value.ToString();
            lname = dgvResidentList.Rows[rowIndex].Cells[3].Value.ToString();
            num = dgvResidentList.Rows[rowIndex].Cells[4].Value.ToString();

            Residents r = new Residents();
            r.txtResidentID.Text = id;
            r.txtEmailAddress.Text = email;
            r.txtFirstName.Text = fname;
            r.txtLastName.Text = lname;
            r.txtAptNumber.Text = num;

            r.Show();

            this.Close();
           
        }
        
    }
}
