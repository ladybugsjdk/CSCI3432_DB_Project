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
    class eventClass
    {

        //getter and setter properties
        //carries data from forms
        public int resID { get; set; }
        public int empid { get; set; }
        public int eventid { get; set; }
        public string location { get; set; }
        public string date { get; set; }
        public string description { get; set; }

       
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting data from database
        public DataTable SelectUpcoming()
        {
            //establish connection with db
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                //sql = "SELECT * FROM tablename";
                string sql = "SELECT * FROM UpcomingEvents;";
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
        public DataTable SelectPrevious()
        {
            //establish connection with db
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                //sql = "SELECT * FROM tablename";
                string sql = "SELECT * FROM PreviousEvents;";
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

        public bool Insert(eventClass evc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO EventsLog (EmployeeID, ResidentID, EDate, ELocation, EDesc) VALUES (@EmployeeID, @ResidentID, @EDate, @ELocation, @EDesc);";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@EmployeeID", evc.empid);
                cmd.Parameters.AddWithValue("@ResidentID", evc.resID);
                cmd.Parameters.AddWithValue("@EDate", evc.date);
                cmd.Parameters.AddWithValue("@ELocation", evc.location);
                cmd.Parameters.AddWithValue("@EDesc", evc.description);

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

        public bool Update(eventClass evc)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE EventsLog SET EmployeeID=@EmployeeID, ResidentID=@ResidentID, EDate=@EDate, ELocation=@ELocation, EDesc=@EDesc WHERE EventID=@EventID;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EventID", evc.eventid);
                cmd.Parameters.AddWithValue("@EmployeeID", evc.empid);
                cmd.Parameters.AddWithValue("@ResidentID", evc.resID);
                cmd.Parameters.AddWithValue("@EDate", evc.date);
                cmd.Parameters.AddWithValue("@ELocation", evc.location);
                cmd.Parameters.AddWithValue("@EDesc", evc.description);

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
