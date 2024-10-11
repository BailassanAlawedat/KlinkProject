using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace KlinikDatenZugriffsSchicht
{
    public class clsDatumDatenZugriff
    {
        public static bool GetDatumByDatumID(int DatumID, ref DateTime Datum,
            ref string Zeit, ref string Status)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Daten     Where DatumID = @DatumID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@DatumID", DatumID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            Datum = (DateTime)reader["Datum"];
                            Zeit = (string)reader["Zeiten"];
                            Status = (string)reader["Status"];
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return isFound;
        }

        public static bool Update(int DatumID ,DateTime datum, string zeit, string status)
        {
            int betroffeneZeile = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            string abfrage = @"Update Daten 
                                        SET 
                                          Datum = @datum,
                                          Zeiten = @zeit,
                                          Status  = @status
                                 Where DatumID = @datumID";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                   using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@datumID", DatumID);
                        command.Parameters.AddWithValue("@datum", datum);
                        command.Parameters.AddWithValue("@zeit", zeit);
                        command.Parameters.AddWithValue("@status", status);

                        connection.Open();

                        betroffeneZeile = command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return betroffeneZeile > 0;                               
        }
        public static int AddNew(DateTime datum, string zeiten, string status)
        {
            int DatumID = -1;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            string abfrage = @"Insert into Daten (Datum, Zeiten, Status)
                                             Values (@Datum, @Zeiten, @Status);
                               Select Scope_Identity()";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                       
                        command.Parameters.AddWithValue("@Datum", datum);
                        command.Parameters.AddWithValue("@Zeiten", zeiten);
                        command.Parameters.AddWithValue("@Status", status);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                            DatumID = InsertedID;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return DatumID;
        }
        public static bool Delete(int DatumID)
        {
            int GetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Delete From Daten      Where DatumID =  @DatumID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@DatumID", DatumID);

                try
                {
                    connection.Open();
                    GetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
            }
            return GetroffeneZeile > 0;
        }

        public static bool isThisAppointmentOverlaop(DateTime TerminDatumToCheck,
            TimeSpan StartZeitToCheck, TimeSpan EndZeitToCheck)
        {
            bool istÜberlappt = true;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select count(*) From Terminen  
                                      Where    @TerminDatumToCheck = TerminDatum
                                           AND ((StartZeit < @EndZeitToCheck) AND (EndZeit > @StartZeitToCheck))";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@TerminDatumToCheck", TerminDatumToCheck);
                command.Parameters.AddWithValue("@StartZeitToCheck", StartZeitToCheck);
                command.Parameters.AddWithValue("@EndZeitToCheck", EndZeitToCheck);

                try
                {
                    connection.Open();
                    int zähler = (int)command.ExecuteScalar();

                    istÜberlappt = (zähler > 0);


                }

                catch (Exception ex)
                {
                    istÜberlappt = false;
                }
            }
            return istÜberlappt;
        }

        public static bool IsDoctorFreeOnThisTime(int arztID, DateTime DatumToCheck,
              string ZeitToCheck)
        {
            bool istFrei = true;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            // SQL Query to find overlapping appointments
            string abfrage = @"
             SELECT find = 1
                        FROM Daten  Inner Join Terminen ON Daten.TerminID = Terminen.TerminID
                      Inner Join Ärzten ON Terminen.ArztID =  Ärzten.ArztID
                      WHERE Ärzten.ArztID = @ArztID
                     And Daten.Datum = @DatumToCheck
                     AND Daten.Zeit = @ZeitToCheck";


            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@ArztID", arztID);
                command.Parameters.AddWithValue("@DatumToCheck", DatumToCheck);
                command.Parameters.AddWithValue("ZeitToCheck", ZeitToCheck);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        istFrei = !reader.HasRows;  // If reader has rows, there is an overlap
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei der Überprüfung der Verfügbarkeit des Arztes: " + ex.Message);
                }
            }
            return istFrei;
        }

        public static bool DoesHavePatientAnAppointmentOnThisDate(int patientID, DateTime DatumToCheck)
        {
            bool JaErHat = true;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            // SQL Query to find overlapping appointments
            string abfrage = @"
             SELECT find = 1
                        FROM Daten  Inner Join Terminen ON Daten.TerminID = Terminen.TerminID
                      Inner Join Patients ON Terminen.PatientID = Patients.PatientID
                      WHERE PatientID = @PatientID
                     And Daten.Datum = @DatumToCheck";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PatientID", patientID);
                command.Parameters.AddWithValue("DatumToCheck", DatumToCheck);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        JaErHat = reader.HasRows;  // If reader has rows, there is an overlap
                    }
                }
                catch (Exception ex)
                {
                    JaErHat = false;
                    throw new Exception("Fehler bei der Überprüfung der Verfügbarkeit des Arztes: " + ex.Message);
                }
            }
            return JaErHat;
        }

        public static DataTable GetAllDatumDaten()
        {
            //ich will  hier überprüfen,Welche Ärzt zu welchem datum sind reserviert. 
            DataTable dt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"select Datum, Zeiten, Status
                                        From Daten ";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                       
                            connection.Open();
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
                throw new Exception("Fehler bei GetAllAppointment Methode : " + ex.Message);
            }

            return dt;
        }
        public static DataTable GetArztDatumDaten(int ArztID)
        {
            //ich will  hier überprüfen,Welche Ärzt zu welchem datum sind reserviert. 
            DataTable dt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"select Datum, Zeiten, Status
                                        From Daten INNER JOIN Terminen ON
                                          Daten.DatumID = Terminen.DatumID
                                     Where Terminen.ArztID = @ArztID";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@ArztID", ArztID);
                        connection.Open();
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
                throw new Exception("Fehler bei GetAllAppointment Methode : " + ex.Message);
            }

            return dt;
        }


    }
}

