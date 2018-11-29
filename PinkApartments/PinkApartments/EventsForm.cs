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
    public partial class EventsForm : Form
    {
        eventClass evc = new eventClass();
        public EventsForm()
        {
            InitializeComponent();
            DataTable dt1 = evc.SelectUpcoming();
            dgvUpcoming.DataSource = dt1;

            DataTable dt2 = evc.SelectPrevious();
            dgvPast.DataSource = dt2;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            evc.empid = int.Parse(empIDBox.Text);
            evc.resID = int.Parse(resIDBox.Text);
            evc.location = locationBox.Text;
            evc.date = dateBox.Text;
            evc.description = descBox.Text;

            bool success = evc.Insert(evc);

            if (success == true)
            {
                MessageBox.Show("Added Upcoming Event.");
                DataTable dt1 = evc.SelectUpcoming();
                dgvUpcoming.DataSource = dt1;

                DataTable dt2 = evc.SelectPrevious();
                dgvPast.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void dgvUpcoming_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            eventIDBox.Text = dgvUpcoming.Rows[rowIndex].Cells[0].Value.ToString();
            empIDBox.Text = dgvUpcoming.Rows[rowIndex].Cells[1].Value.ToString();
            resIDBox.Text = dgvUpcoming.Rows[rowIndex].Cells[2].Value.ToString();
            dateBox.Text = dgvUpcoming.Rows[rowIndex].Cells[3].Value.ToString();
            locationBox.Text = dgvUpcoming.Rows[rowIndex].Cells[4].Value.ToString();
            descBox.Text = dgvUpcoming.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            evc.eventid = int.Parse(eventIDBox.Text);
            evc.empid = int.Parse(empIDBox.Text);
            evc.resID = int.Parse(resIDBox.Text);
            evc.location = locationBox.Text;
            evc.date = dateBox.Text;
            evc.description = descBox.Text;

            bool success = evc.Update(evc);

            if (success == true)
            {
                MessageBox.Show("Updated Upcoming Event.");
                DataTable dt1 = evc.SelectUpcoming();
                dgvUpcoming.DataSource = dt1;

                DataTable dt2 = evc.SelectPrevious();
                dgvPast.DataSource = dt2;

            }
            else
            {
                MessageBox.Show("An error occurred.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
