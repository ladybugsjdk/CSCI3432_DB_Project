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
    class pinkClass
    {

        //getter and setter properties
        //carries data from forms

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //establish connection with db
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            
            try
            {
                string sql = "SELECT * FROM tablename";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            } catch(Exception e)
            {

            } finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
