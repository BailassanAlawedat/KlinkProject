using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Configuration;

namespace KlinikDatenZugriffsSchicht
{
    public class clsÄrzteDatenZugriff
    {
        public static bool GetDoctorDatenByID(int ArztID, ref int PersonID, ref int FachrichtungsID)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Ärzten   where ArztID =  @ArztID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@ArztID", ArztID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            PersonID = (int)reader["PersonID"];
                            FachrichtungsID = (int)reader["FachrichtungsID"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim GetPerosnDatenByID Methode "+ ex.Message);
                }
            }
            return isFound;
        }

        public static bool GetDoctorDatenByPersonID(ref int ArztID, int PersonID, ref int FachrichtungsID)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select *  From Ärzten  where PersonID =  @PersonID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            ArztID = (int)reader["ArztID"];
                            FachrichtungsID = (int)reader["FachrichtungsID"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim GetPerosnDatenByPersonID Methode "+ ex.Message);
                }
            }
            return isFound;
        }

        public static bool GetDoctorDataByPersonName(string PersonName, ref int arztID, ref int PersonID,
                  ref int FachrichtungsID)
        {
            bool isfound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"select *
                                  From   Ärzten
                                  INNER JOIN Personen ON Ärzten.PersonID = Personen.PersonID
                                 where Trim(Personen.Vorname) + ' ' + Trim(Personen.Nachname) = @PersonName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PersonName", PersonName);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isfound = true;

                            PersonID = (int)reader["PersonID"];
                            arztID = (int)reader["ArztID"];
                            FachrichtungsID = (int)reader["FachrichtungsID"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    isfound = false;
                    throw new Exception("Fehler beim GetPerosnDatenByPersonName Methode "+ ex.Message);
                }
            }
            return isfound;
        }

        public static DataTable GetAllDoctors()
        {
            DataTable dtArzt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"
                       select Ärzten.ArztID, Ärzten.PersonID, Personen.Vorname +  ' ' + Personen.Nachname as Vollname,
                     Personen.AusweisID, Personen.GeburtsTag,Personen.RegistrierungsDatum, Fachrichtungen.FachrichtungsName
     
                          From Ärzten Inner join Personen ON
	                   	Ärzten.PersonID = Personen.PersonID  
	                 	Inner Join Fachrichtungen ON
	                 	Ärzten.FachrichtungsID = Fachrichtungen.FachrichtungsID 
	                 	Order by ArztID Desc";
                              

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dtArzt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode GetAllPatients "+ ex.Message);
                }
            }

            return dtArzt;
        }

        public static int AddNeuDoctor(int PersonID, int FachrichtungsID)
        {
            int ArztID = -1;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Insert into Ärzten (PersonID, FachrichtungsID)
                                         Values  (@PersonID, @FachrichtungsID);
                              Select Scope_Identity()";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@FachrichtungsID", FachrichtungsID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        ArztID = InsertedID;
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode AddNeuArzt "+ ex.Message);
                }
            }
            return ArztID;
        }

        public static bool IsDoctorExistForPersonID(int PersonID)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @" Select Find=1 From Ärzten  Where PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        isFound = reader.HasRows;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode DeletePatient "+ ex.Message);
                }
            }
            return isFound;
        }

        public static bool DeleteDoctor(int ArztID)
        {
            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Delete from Ärzten 
                               Where ArztID = @ArztID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@ArztID", ArztID);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode DeleteArzt "+ ex.Message);
                }
            }
            return (BetroffeneZeile > 0);
        }

        public static bool UpdateDoctorByDoctorID(int ArztID, int FachrichtungsID)
        {

            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Update Ärzten 
                                      Set FachrichtungsID = @FachrichtungsID
                                      Where  ArztID = @ArztID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@ArztID", ArztID);
                command.Parameters.AddWithValue("@FachrichtungsID", FachrichtungsID);
                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode UpdateArzt "+ ex.Message);
                }
            }
            return (BetroffeneZeile > 0);
        }
        public static bool UpdateDoctorByPersonID(int PersonID, int FachrichtungsID)
        {

            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Update Ärzten 
                                      Set FachrichtungsID = @FachrichtungsID
                                      Where  PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@FachrichtungsID", FachrichtungsID);
                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode UpdateArzt "+ ex.Message);
                }
            }
            return (BetroffeneZeile > 0);
        }

    }
}
