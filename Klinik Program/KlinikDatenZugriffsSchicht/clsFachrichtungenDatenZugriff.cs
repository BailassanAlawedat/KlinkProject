using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace KlinikDatenZugriffsSchicht
{
    public class clsFachrichtungenDatenZugriff
    {
        public static bool GetProfessionByID(int FachrichtungsID, ref string FachrichtungsName)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * from Fachrichtungen   Where FachrichtungsID = @FachrichtungsID";

            using(SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@FachrichtungsID", FachrichtungsID);

                try
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            isFound = true;
                            FachrichtungsName = (string)reader["FachrichtungsName"];
                        }
                    }
                }
                catch(Exception ex)
                {
                    isFound = false;
                }
            }
            return isFound;
        }

        public static bool GetProfessionNameByDoctorID(int ArztID, ref int FachrichtungsID, ref string FachrichtungsName)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"select * from Fachrichtungen
                                                Inner Join Ärzten On
			                                    Fachrichtungen.FachrichtungsID = Ärzten.FachrichtungsID
			                                  Where ArztID = @ArztID";

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
                            FachrichtungsID = (int)reader["FachrichtungsID"];
                            FachrichtungsName = (string)reader["FachrichtungsName"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                }
            }
            return isFound;
        }

        public static bool GetProfessionByName(ref int FachrichtungsID, string FachrichtungsName)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * from Fachrichtungen   Where FachrichtungsName = @FachrichtungsName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@FachrichtungsName", FachrichtungsName);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            FachrichtungsID = (int)reader["FachrichtungsID"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                }
            }
            return isFound;

        }

        public static int AddNeuProfission(string FachrichtungsName)
        {
            int FachrichtungsID = -1;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Insert into Fachrichtungen   (FachrichtungsName)
                                                     Values (@FachrichtungsName)
                                 Select Scope_Identity()";
                               

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@FachrichtungsName", FachrichtungsName);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        FachrichtungsID = InsertedID;
                }
                catch (Exception ex)
                {
                   
                }
            }
            return FachrichtungsID;
        }

        public static bool UpdateProfission(int FachrichtungsID, string FachrichtungsName)
        {
            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Update Fachrichtungen    Set FachrichtungsName =  @FachrichtungsName 
                                                     Where FachrichtungsID = @FachrichtungsID";                       

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@FachrichtungsID", FachrichtungsID);
                command.Parameters.AddWithValue("@FachrichtungsName", FachrichtungsName);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                     
                }
                catch (Exception ex)
                {

                }
            }
            return (BetroffeneZeile > 0);
        }


        public static bool DeleteProfission(int FachrichtungsID)
        {
            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Delete from  Fachrichtungen  Where FachrichtungsID = @FachrichtungsID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@FachrichtungsID", FachrichtungsID);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                }
            }
            return (BetroffeneZeile > 0);
        }

        public static DataTable GetAllProfissions()
        {
            DataTable dt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * from  Fachrichtungen";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {

                try
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }

                }
                catch (Exception ex)
                {

                }
            }
            return dt;
        }


        public static bool DoesProfissionExist(string FachrichtungsName)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select Find = 1  from  Fachrichtungen  Where FachrichtungsName = @FachrichtungsName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@FachrichtungsName", FachrichtungsName);

                try
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        isFound = reader.HasRows;
                    }

                }
                catch (Exception ex)
                {

                }
            }
            return isFound;
        }

        public static DataTable GetDoctorWithProfission(int FachrichtungsID)
        {
            DataTable dt = new DataTable();


            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select Ärzten.ArztID, Personen.PersonID, Personen.Vorname + ' ' + Personen.Nachname, Personen.GeburtsTag,
                                Fachrichtungen.FachrichtungsName
                                From  Ärzten Inner Join Personen ON
                                       Ärzten.PersonID = Personen.PersonID 
                                          Inner Join Fachrichtungen ON
                                       Ärzten.FachrichtungsID = Fachrichtungen.FachrichtungsID
                      Where Ärzten.FachrichtungsID = @FachrichtungsID
                      Order by ArztID Desc";
                      

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@FachrichtungsID", FachrichtungsID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }

                }
                catch (Exception ex)
                {

                }
            }
            return dt;
        }
    }
}
