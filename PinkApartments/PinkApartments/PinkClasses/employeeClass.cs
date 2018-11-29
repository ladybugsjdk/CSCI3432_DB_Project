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
    class employeeClass
    {
        //getter and setter properties
        //carries data from forms
        public int empID { get; set; }
        public string jobtitle { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string hireDate { get; set; }
        public string salary { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //establish connection with db
            SqlConnection conn = new SqlConnection(myconnstring);
            string sql = "SELECT * FROM Employees;";
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

        public bool Insert(employeeClass ec)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Employees (EmailAddress, JobTitle, FirstName, LastName, HireDate, Salary) VALUES (@EmailAddress, @JobTitle, @FirstName, @LastName, @HireDate, @Salary);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@EmailAddress", ec.email);
                cmd.Parameters.AddWithValue("@JobTitle", ec.jobtitle);
                cmd.Parameters.AddWithValue("@FirstName", ec.fname);
                cmd.Parameters.AddWithValue("@LastName", ec.lname);
                cmd.Parameters.AddWithValue("@HireDate", ec.hireDate);
                cmd.Parameters.AddWithValue("@Salary", ec.salary);

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

        public bool Update(employeeClass ec)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Employees SET EmailAddress=@EmailAddress, JobTitle=@JobTitle, FirstName=@FirstName, LastName=@LastName,  HireDate=@HireDate, Salary=@Salary WHERE EmployeeID=@EmployeeID;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", ec.fname);
                cmd.Parameters.AddWithValue("@LastName", ec.lname);
                cmd.Parameters.AddWithValue("@JobTitle", ec.jobtitle);
                cmd.Parameters.AddWithValue("@EmailAddress", ec.email);
                cmd.Parameters.AddWithValue("@HireDate", ec.hireDate);
                cmd.Parameters.AddWithValue("@Salary", ec.salary);
                cmd.Parameters.AddWithValue("EmployeeID", ec.empID);
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
