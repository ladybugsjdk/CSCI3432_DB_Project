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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        searchClass s = new searchClass();

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get value from textbox
            if(advancedQ.Text.ToLower().IndexOf("delete") != -1)
            {
                MessageBox.Show("Can not perform this function.");
            } else if(advancedQ.Text.ToLower().IndexOf("update") != -1)
            {
                MessageBox.Show("Can not perform this function.");
            } else if(advancedQ.Text.ToLower().IndexOf("drop") != -1)
            {
                MessageBox.Show("Can not perform this function.");
            }
            else if (advancedQ.Text.ToLower().IndexOf("create") != -1)
            {
                MessageBox.Show("Can not perform this function.");
            }
            else
            {
                s.search2 = advancedQ.Text;
                s.sql = s.search2;
                DataTable dt = s.Select();
                dgvSearch.DataSource = dt;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.combo = comboBox1.Text;
            s.sql = "SELECT * FROM " + s.combo + ";";
            DataTable dt = s.Select();
            dgvSearch.DataSource = dt;
        }
    }
}
