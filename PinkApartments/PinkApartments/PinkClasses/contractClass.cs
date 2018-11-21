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
    class contractClass
    {
        //getter and setter properties
        //carries data from forms
        public int aptnum { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string cardtype { get; set; }
        public string cardnum { get; set; }
        public int baserent { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int leaselen { get; set; }
        public int empid { get; set; }

        public string sql = "SELECT * FROM ReusableApartments;";

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //establish connection with db
            SqlConnection conn = new SqlConnection(myconnstring);
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

        public bool Insert(contractClass cc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            string query = "SELECT COUNT(*) FROM Residents;";
            SqlCommand com = new SqlCommand(query, conn);
            conn.Open();
            int index = com.ExecuteNonQuery() + 1;
            conn.Close();
            try
            {
                string sql = "SET IDENTITY_INSERT Residents ON; INSERT INTO Residents(ResidentID, EmployeeID, EmailAddress, FirstName, LastName, PhoneNumber) VALUES (@ResidentID, @EmployeeID, @EmailAddress, @FirstName, @LastName, @PhoneNumber); SET IDENTITY_INSERT Residents OFF;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ResidentID", index++);
                cmd.Parameters.AddWithValue("@EmployeeID", 1);
                cmd.Parameters.AddWithValue("@EmailAddress", cc.email);
                cmd.Parameters.AddWithValue("@FirstName", cc.fname);
                cmd.Parameters.AddWithValue("@LastName", cc.lname);   
                cmd.Parameters.AddWithValue("@PhoneNumber", cc.phone);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                } else
                {
                    isSuccess = false;
                }
            } catch(Exception ex)
            {

            } finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
