using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidentsForm.FormClasses
{
    class formClass
    {

        //getter and setter for application
        //acts as data carrier
        public int ResidentID { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String EmailAddress { get; set; }

        public String AptNumber { get; set; }

        //getting connection to database
        static string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //write sql query
                string sql = "SELECT * FROM Residents";
                //cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //inserting data into databse
        public bool Insert(formClass c)
        {
            //default return type
            bool isSuccessful = false;

            //connect db
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //create sql query to insert data
                string sql = "INSERT INTO Residents (EmailAddress, FirstName, LastName, AptNumber) VALUES (@EmailAddress, @FirstName, @LastName, @AptNumber)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmailAddress", c.EmailAddress);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@AptNumber", c.AptNumber);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if query is succesfful rows will be greater than 0
                if (rows > 0)
                {
                    isSuccessful = true;
                }
                else
                {
                    isSuccessful = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccessful;
        }

        //update data in table from application
        public bool Update(formClass c)
        {
            //create default bool return value
            bool isSuccesful = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in database
                string sql = "UPDATE Residents SET EmailAddress = @EmailAddress, FirstName = @FirstName, LastName = @LastName, AptNumber = @AptNumber WHERE ResidentID = @ResidentID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add
                cmd.Parameters.AddWithValue("@EmailAddress", c.EmailAddress);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@AptNumber", c.AptNumber);
                cmd.Parameters.AddWithValue("ResidentID", c.ResidentID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccesful = true;
                }
                else
                {
                    isSuccesful = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccesful;
        }

        //method to delete from db
        public bool Delete(formClass c)
        {
            //default return value
            bool isSuccessful = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM Residents WHERE ResidentID = @ResidentID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ResidentID", c.ResidentID);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccessful = true;
                }
                else
                {
                    isSuccessful = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccessful;
        }
    }
}
