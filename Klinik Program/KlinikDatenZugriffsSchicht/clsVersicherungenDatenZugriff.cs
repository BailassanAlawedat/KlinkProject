using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace KlinikDatenZugriffsSchicht
{
    public class clsVersicherungenDatenZugriff
    {
        public static bool GetVersicherungsDatenByID(int VersicherungID,  ref string VersicherungsName)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Versicherungen   where VersicherungID =  @VersicherungID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@VersicherungID", VersicherungID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            VersicherungsName = (string)reader["VersicherungsName"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim GetPerosnDatenByID Methode " + ex.Message);
                }
            }
            return isFound;
        }

        public static bool GetVersicherungsDatenByName(ref int VersicherungID, string VersicherungsName)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Versicherungen   where VersicherungsName =  @VersicherungsName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@VersicherungsName", VersicherungsName);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            VersicherungID = (int)reader["VersicherungID"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim GetPerosnDatenByName Methode " + ex.Message);
                }
            }
            return isFound;
        }

        public static int AddNewVersicherung( string VersicherungsName)
        {
            int VersicherungsID = -1;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Insert into Versicherungen (VersicherungsName)
                                         Values  (@VersicherungsName);
                              Select Scope_Identity()";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@VersicherungsName", VersicherungsName);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        VersicherungsID = InsertedID;
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode AddNeuVersicherung " + ex.Message);
                }
            }
            return VersicherungsID;
        }

        public static bool DeleteVersicherung(int VersicherungID)
        {
            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Delete from Versicherungen 
                               Where VersicherungID = @VersicherungID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@VersicherungID", VersicherungID);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode DeleteVersicherung " + ex.Message);
                }
            }
            return (BetroffeneZeile > 0);
        }

        public static bool UpdateVersicherung(int VersicherungID, string VersicherungsName)
        {

            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Update Versicherungen 
                                      Set VersicherungsName = @VersicherungsName,
                                      Where  VersicherungID = @VersicherungID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@VersicherungID", VersicherungID);
                command.Parameters.AddWithValue("@VersicherungsName", VersicherungsName);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode UpdateVersicherung " + ex.Message);
                }
            }
            return (BetroffeneZeile > 0);
        }
       
        public static DataTable GetAllVersicherungen()
        {
            DataTable dt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = "Select * from Versicherungen";
           
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler bei Methode GetAllVersicherungen " + ex.Message);
            }

            return dt;
        }
    }
}
