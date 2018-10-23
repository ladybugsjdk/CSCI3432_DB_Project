using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LookUp : Form
    {
        public LookUp()
        {
            InitializeComponent();
        }

        private void LookUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pinkDataSet.Residents' table. You can move, or remove it, as needed.
            this.residentsTableAdapter.Fill(this.pinkDataSet.Residents);

        }
        public static string id = "";
        public static string email = "";
        public static string fname = "";
        public static string lname = "";
        public static string num = "";
        
        ResidentsForm.FormClasses.formClass c = new ResidentsForm.FormClasses.formClass();


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dgvResidentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data from row
            int rowIndex = e.RowIndex;

            id = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            email = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            fname = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            lname = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            num = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

            ResidentsForm.Residents r = new ResidentsForm.Residents();
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
