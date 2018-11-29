using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinkApartments.PinkClasses
{
    class residentClass
    {
        //getter and setter properties
        //carries data from forms
        public int residentID { get; set; }
        public int empID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //establish connection with db
            SqlConnection conn = new SqlConnection(myconnstring);
            string sql = "SELECT * FROM Residents;";
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

        public bool Insert(residentClass rc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Residents (EmployeeID, FirstName, LastName, EmailAddress, PhoneNumber) VALUES (@EmployeeID, @FirstName, @LastName, @EmailAddress, @PhoneNumber);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", rc.empID);
                cmd.Parameters.AddWithValue("@FirstName", rc.fname);
                cmd.Parameters.AddWithValue("@LastName", rc.lname);
                cmd.Parameters.AddWithValue("@EmailAddress", rc.email);
                cmd.Parameters.AddWithValue("@PhoneNumber", rc.phone);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    success = true;
                } else
                {
                    success = false;
                }
            } catch (Exception ex)
            {

            } finally
            {
                conn.Close();
            }
            return success;
        }

        public bool InsertNoEmp(residentClass rc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Residents (EmployeeID, FirstName, LastName, EmailAddress, PhoneNumber) VALUES (NULL, @FirstName, @LastName, @EmailAddress, @PhoneNumber);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", rc.fname);
                cmd.Parameters.AddWithValue("@LastName", rc.lname);
                cmd.Parameters.AddWithValue("@EmailAddress", rc.email);
                cmd.Parameters.AddWithValue("@PhoneNumber", rc.phone);

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

        public bool Update(residentClass rc)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Residents SET EmployeeID=@EmployeeID, FirstName=@FirstName, LastName=@LastName, EmailAddress=@EmailAddress, PhoneNumber=@PhoneNumber WHERE ResidentID=@ResidentID;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", rc.empID);
                cmd.Parameters.AddWithValue("@FirstName", rc.fname);
                cmd.Parameters.AddWithValue("@LastName", rc.lname);
                cmd.Parameters.AddWithValue("@EmailAddress", rc.email);
                cmd.Parameters.AddWithValue("@PhoneNumber", rc.phone);
                cmd.Parameters.AddWithValue("ResidentID", rc.residentID);
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

            } catch(Exception ex) {

            } finally
            {
                conn.Close();
            }
            return success;
        }

        public bool UpdateNoEmp(residentClass rc)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Residents SET EmployeeID=NULL, FirstName=@FirstName, LastName=@LastName, EmailAddress=@EmailAddress, PhoneNumber=@PhoneNumber WHERE ResidentID=@ResidentID;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", rc.fname);
                cmd.Parameters.AddWithValue("@LastName", rc.lname);
                cmd.Parameters.AddWithValue("@EmailAddress", rc.email);
                cmd.Parameters.AddWithValue("@PhoneNumber", rc.phone);
                cmd.Parameters.AddWithValue("ResidentID", rc.residentID);
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
