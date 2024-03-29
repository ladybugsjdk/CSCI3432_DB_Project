﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinkApartments.PinkClasses
{
    class contractClass
    {
        //getter and setter properties
        //carries data from forms
        public int residentID { get; set; }
        public int apartmentNum { get; set; }
        public int empID { get; set; }
        public string price { get; set; }
        public int pets { get; set; }
        public int smoking { get; set; }
        public string specials { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //establish connection with db
            SqlConnection conn = new SqlConnection(myconnstring);
            string sql = "SELECT * FROM ReusableApartments;";
            DataTable dt = new DataTable();

            try
            {
                //sql = "SELECT * FROM tablename";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //selecting data from database
        public DataTable SelectResident()
        {
            //establish connection with db
            SqlConnection conn = new SqlConnection(myconnstring);
            string sql = "SELECT * FROM RESIDENTS;";
            DataTable dt = new DataTable();

            try
            {
                //sql = "SELECT * FROM tablename";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool InsertResident(contractClass cc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Residents (EmployeeID, FirstName, LastName, EmailAddress, PhoneNumber) VALUES (@EmployeeID, @FirstName, @LastName, @EmailAddress, @PhoneNumber);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", cc.empID);
                cmd.Parameters.AddWithValue("@FirstName", cc.fname);
                cmd.Parameters.AddWithValue("@LastName", cc.lname);
                cmd.Parameters.AddWithValue("@EmailAddress", cc.email);
                cmd.Parameters.AddWithValue("@PhoneNumber", cc.phone);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        public bool InsertNoEmp(contractClass cc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Residents (EmployeeID, FirstName, LastName, EmailAddress, PhoneNumber) VALUES (NULL, @FirstName, @LastName, @EmailAddress, @PhoneNumber);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", cc.fname);
                cmd.Parameters.AddWithValue("@LastName", cc.lname);
                cmd.Parameters.AddWithValue("@EmailAddress", cc.email);
                cmd.Parameters.AddWithValue("@PhoneNumber", cc.phone);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        public bool InsertContract(contractClass cc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Contracts (ResidentID, ApartmentNum, Price, StartDate, EndDate, PetsAllowed, SmokingAllowed, Specials) VALUES (@ResidentID, @ApartmentNum, @Price, @StartDate, @EndDate, @PetsAllowed, @SmokingAllowed, @Specials);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ResidentID", cc.residentID);
                cmd.Parameters.AddWithValue("@ApartmentNum", cc.apartmentNum);
                cmd.Parameters.AddWithValue("@Price", cc.price);
                cmd.Parameters.AddWithValue("@StartDate", cc.startdate);
                cmd.Parameters.AddWithValue("@EndDate", cc.enddate);
                cmd.Parameters.AddWithValue("@PetsAllowed", cc.pets);
                cmd.Parameters.AddWithValue("@SmokingAllowed", cc.smoking);
                cmd.Parameters.AddWithValue("@Specials", cc.specials);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return success;
        }
    }
}
