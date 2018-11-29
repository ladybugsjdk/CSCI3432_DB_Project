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
    class petClass
    {
        //getter and setter properties
        //carries data from forms
        public int resID { get; set; }
        public string breed { get; set; }
        public string species { get; set; }
        public string paymentDate { get; set; }
        public string regDate { get; set; }
        public string licensePlate { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string vehRegDate { get; set; }
        public string decal { get; set; }

        public string dgvChoice { get; set; }
        public string dgvsql = "";
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
                SqlCommand cmd = new SqlCommand(dgvsql, conn);
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

        public bool InsertPet(petClass pc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Pets (ResidentID, Species, Breed, RegistrationDate, PaymentDate) VALUES (@ResidentID, @Species, @Breed, @RegistrationDate, @PaymentDate);";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ResidentID", pc.resID);
                cmd.Parameters.AddWithValue("@Species", pc.species);
                cmd.Parameters.AddWithValue("@Breed", pc.breed);
                cmd.Parameters.AddWithValue("@RegistrationDate", pc.regDate);
                cmd.Parameters.AddWithValue("@PaymentDate", pc.paymentDate);

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

        public bool Update(petClass pc)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Pets SET ResidentID=@ResidentID, Species=@Species, Breed=@Breed, RegistrationDate=@RegistrationDate, PaymentDate=@PaymentDate WHERE ResidentID=@ResidentID;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ResidentID", pc.resID);
                cmd.Parameters.AddWithValue("@Species", pc.species);
                cmd.Parameters.AddWithValue("@Breed", pc.breed);
                cmd.Parameters.AddWithValue("@RegistrationDate", pc.regDate);
                cmd.Parameters.AddWithValue("@PaymentDate", pc.paymentDate);

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

        public bool DeletePet(petClass pc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM Pets WHERE ResidentID=@ResidentID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ResidentID", pc.resID);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    success = true;
                } else
                {
                    success = false;
                }
            } catch(Exception ex)
            {

            } finally
            {
                conn.Close();
            }

            return success;
        }

        public bool InsertVehicle(petClass pc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO ResidentVehicles (LicensePlate, ResidentID, Make, Model, Color, RegistrationDate, DecalSticker) VALUES (@LicensePlate, @ResidentID, @Make, @Model, @Color, @RegistrationDate, @DecalSticker);";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@LicensePlate", pc.licensePlate);
                cmd.Parameters.AddWithValue("@ResidentID", pc.resID);
                cmd.Parameters.AddWithValue("@Make", pc.make);
                cmd.Parameters.AddWithValue("@Model", pc.model);
                cmd.Parameters.AddWithValue("@Color", pc.color);
                cmd.Parameters.AddWithValue("@RegistrationDate", pc.vehRegDate);
                cmd.Parameters.AddWithValue("@DecalSticker", pc.decal);

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

        public bool UpdateVehicle(petClass pc)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE ResidentVehicles SET LicensePlate=@LicensePlate, ResidentID=@ResidentID, Make=@Make, Model=@Model, Color=@Color, RegistrationDate=@RegistrationDate, DecalSticker=@DecalSticker WHERE LicensePlate=@LicensePlate;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LicensePlate", pc.licensePlate);
                cmd.Parameters.AddWithValue("@ResidentID", pc.resID);
                cmd.Parameters.AddWithValue("@Make", pc.make);
                cmd.Parameters.AddWithValue("@Model", pc.model);
                cmd.Parameters.AddWithValue("@Color", pc.color);
                cmd.Parameters.AddWithValue("@RegistrationDate", pc.vehRegDate);
                cmd.Parameters.AddWithValue("@DecalSticker", pc.decal);


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

        public bool DeleteVehicle(petClass pc)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM ResidentVehicles WHERE LicensePlate=@LicensePlate";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@LicensePlate", pc.licensePlate);
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
