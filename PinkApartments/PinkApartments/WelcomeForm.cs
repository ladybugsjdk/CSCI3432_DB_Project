﻿using PinkApartments.PinkClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinkApartments
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            
            
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            //this.Visible = false;
            //SplashScreen sc = new SplashScreen();
            //sc.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateContract cc = new CreateContract();
            cc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResidentForm rf = new ResidentForm();
            rf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm();
            ef.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PetandVehicleForm pvf = new PetandVehicleForm();
            pvf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EventsForm evf = new EventsForm();
            evf.Show();
        }
    }
}
