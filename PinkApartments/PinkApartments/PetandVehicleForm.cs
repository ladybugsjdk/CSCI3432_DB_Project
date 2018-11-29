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
    public partial class PetandVehicleForm : Form
    {
        petClass pc = new petClass();

        public PetandVehicleForm()
        {
            InitializeComponent();
        }

        private void addPetBtn_Click(object sender, EventArgs e)
        {
            pc.resID = int.Parse(resid1Box.Text);
            pc.species = speciesBox.Text;
            pc.breed = breedBox.Text;
            pc.regDate = regdateBox.Text;
            pc.paymentDate = paydateBox.Text;

            bool success = pc.InsertPet(pc);

            if (success == true)
            {
                MessageBox.Show("Added Pet");
                DataTable dt = pc.Select();
                dgvPetVeh.DataSource = dt;
            }
            else
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void showDGV_Click(object sender, EventArgs e)
        {
            pc.dgvChoice = selectViewBox.Text;
            pc.dgvsql = "SELECT * FROM " + pc.dgvChoice + ";";
            DataTable dt = pc.Select();
            dgvPetVeh.DataSource = dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPetVeh_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //used to fill out text field for updating info
            if(pc.dgvChoice.Equals("Pets"))
            {
                int rowIndex = e.RowIndex;
                resid1Box.Text = dgvPetVeh.Rows[rowIndex].Cells[0].Value.ToString();
                speciesBox.Text = dgvPetVeh.Rows[rowIndex].Cells[1].Value.ToString();
                breedBox.Text = dgvPetVeh.Rows[rowIndex].Cells[2].Value.ToString();
                regdateBox.Text = dgvPetVeh.Rows[rowIndex].Cells[3].Value.ToString();
                paydateBox.Text = dgvPetVeh.Rows[rowIndex].Cells[4].Value.ToString();
            } else if(pc.dgvChoice.Equals("ResidentVehicles"))
            {
                int rowIndex = e.RowIndex;
                lienseBox.Text = dgvPetVeh.Rows[rowIndex].Cells[0].Value.ToString();
                resid2Box.Text = dgvPetVeh.Rows[rowIndex].Cells[1].Value.ToString();
                makeBox.Text = dgvPetVeh.Rows[rowIndex].Cells[2].Value.ToString();
                modelBox.Text = dgvPetVeh.Rows[rowIndex].Cells[3].Value.ToString();
                colorBox.Text = dgvPetVeh.Rows[rowIndex].Cells[4].Value.ToString();
                regivehicleBox.Text = dgvPetVeh.Rows[rowIndex].Cells[5].Value.ToString();
                decalBox.Text = dgvPetVeh.Rows[rowIndex].Cells[6].Value.ToString();
            }
           
        }

        private void updatePetBtn_Click(object sender, EventArgs e)
        {
            pc.resID = int.Parse(resid1Box.Text);
            pc.breed = breedBox.Text;
            pc.species = speciesBox.Text;
            pc.paymentDate = paydateBox.Text;
            pc.regDate = regdateBox.Text;

            bool success = pc.Update(pc);

            if (success == true)
            {
                MessageBox.Show("Updated Pet.");
                DataTable dt = pc.Select();
                dgvPetVeh.DataSource = dt;
            }
            else
            {
                MessageBox.Show("An error occurred.");
            }
        }

        private void deletePetBtn_Click(object sender, EventArgs e)
        {
            pc.resID = int.Parse(resid1Box.Text);
            bool success = pc.DeletePet(pc);

            if(success == true)
            {
                MessageBox.Show("Deleted pet.");
                DataTable dt = pc.Select();
                dgvPetVeh.DataSource = dt;
            } else
            {
                MessageBox.Show("An error occurred.");
            }
        }

        private void addVehBtn_Click(object sender, EventArgs e)
        {
            pc.licensePlate = lienseBox.Text;
            pc.resID = int.Parse(resid2Box.Text);
            pc.make = makeBox.Text;
            pc.model = modelBox.Text;
            pc.color = colorBox.Text;
            pc.vehRegDate = regivehicleBox.Text;
            pc.decal = decalBox.Text;

            bool success = pc.InsertVehicle(pc);

            if (success == true)
            {
                MessageBox.Show("Added Vehicle");
                DataTable dt = pc.Select();
                dgvPetVeh.DataSource = dt;
            }
            else
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void updateVehBtn_Click(object sender, EventArgs e)
        {
            pc.licensePlate = lienseBox.Text;
            pc.resID = int.Parse(resid2Box.Text);
            pc.make = makeBox.Text;
            pc.model = modelBox.Text;
            pc.color = colorBox.Text;
            pc.vehRegDate = regivehicleBox.Text;
            pc.decal = decalBox.Text;

            bool success = pc.UpdateVehicle(pc);

            if (success == true)
            {
                MessageBox.Show("Updated Vehicle.");
                DataTable dt = pc.Select();
                dgvPetVeh.DataSource = dt;
            }
            else
            {
                MessageBox.Show("An error occurred.");
            }
        }

        private void delVehBtn_Click(object sender, EventArgs e)
        {
            pc.licensePlate = lienseBox.Text;
            bool success = pc.DeleteVehicle(pc);

            if (success == true)
            {
                MessageBox.Show("Deleted Vehicle.");
                DataTable dt = pc.Select();
                dgvPetVeh.DataSource = dt;
            }
            else
            {
                MessageBox.Show("An error occurred.");
            }
        }
    }
}
