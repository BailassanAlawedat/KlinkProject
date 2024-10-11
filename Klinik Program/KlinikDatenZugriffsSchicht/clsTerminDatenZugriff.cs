using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.InteropServices;

namespace KlinikDatenZugriffsSchicht
{
    public class clsTerminDatenZugriff
    {
        
        public static string GetDBConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            return connectionString;
        }
        public static bool GetAppoitmentByID(int TerminID, ref int datumID, ref int ArztID, ref int PatientID,
             ref int VersicherungsID, ref bool TerminStatus)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Terminen     Where TerminID = @TerminID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@TerminID", TerminID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            datumID = (int)reader["DatumID"];
                            ArztID = (int)reader["ArztID"];
                            PatientID = (int)reader["PatientID"];
                            VersicherungsID = (int)reader["VersicherungsID"];
                            TerminStatus = (bool)reader["TerminStatus"];
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

        public static bool GetAppoitmentByPatientID(ref int TerminID, ref int datumID, ref int ArztID, int PatientID,
          ref int VersicherungsID, ref bool TerminStatus)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Terminen     Where PatientID = @PatientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PatientID", PatientID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            datumID = (int)reader["DatumID"];
                            TerminID = (int)reader["TerminID"];
                            ArztID = (int)reader["ArztID"];
                            VersicherungsID = (int)reader["VersicherungsID"];
                            TerminStatus = (bool)reader["TerminStatus"];
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

        public static int AddNewAppoitment(int datumID, int ArztID,  int PatientID,
              int VersicherungsID,  bool TerminStatus)
        {
            int TerminID = -1;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Insert into Terminen  (DatumID, ArztID, PatientID,VersicherungsID,TerminStatus)
                                         Values (@DatumID, @ArztID, @PatientID, @VersicherungsID,@TerminStatus)
                            Select Scope_Identity()";

            using(SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@DatumID", datumID);
                command.Parameters.AddWithValue("@ArztID",ArztID);
                command.Parameters.AddWithValue("@PatientID",PatientID);
                command.Parameters.AddWithValue("@VersicherungsID",VersicherungsID);
                command.Parameters.AddWithValue("@TerminStatus",TerminStatus);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        TerminID = InsertedID;
                }
                catch(Exception ex)
                {
                    
                }
            }
            return TerminID;
        }

        public static bool UpdateAppoitment(int TerminID,int DatumID,  int ArztID, int PatientID,
         int VersicherungsID, bool TerminStatus)
        {
            int GetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Update Terminen 
                                       Set 
                                              DatumID = @DatumID,
                                              ArztID  = @ArztID,
                                             PatientID = @PatientID,                                          
                                             VersicherungsID = @VersicherungsID,
                                             TerminStatus  = @TerminStatus
                                  Where  TerminID = @TerminID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@TerminID", TerminID);
                command.Parameters.AddWithValue("@DatumID", DatumID);
                command.Parameters.AddWithValue("@ArztID", ArztID);
                command.Parameters.AddWithValue("@PatientID", PatientID);
                command.Parameters.AddWithValue("@VersicherungsID", VersicherungsID);
                command.Parameters.AddWithValue("@TerminStatus", TerminStatus);

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

        public static bool DeleteTermin(int TerminID)
        {
            int GetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Delete From Terminen
                                       Where TerminID = @TerminID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@TerminID", TerminID);

                try
                {
                    connection.Open();
                    GetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
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

        public static bool IsDoctorFreeForThisAppointment(int arztID, DateTime TerminDatumToCheck,
              string ZeitToCheck)
        {
            bool istFrei = true;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            // SQL Query to find overlapping appointments
            string abfrage = @"
            SELECT find = 1
               FROM Terminen 
               INNER JOIN Daten ON Terminen.DatumID = Daten.DatumID
               WHERE ArztID = @ArztID 
                And @TerminDatumToCheck = Daten.Datum
                And @ZeitToCheck = Daten.Zeiten";


            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@ArztID", arztID);
                command.Parameters.AddWithValue("@TerminDatumToCheck", TerminDatumToCheck);
                command.Parameters.AddWithValue("@ZeitToCheck", ZeitToCheck);

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

        public static bool DoesHavePatientAppointmentOnthisTime(int patientID, DateTime TerminDatumToCheck)
        {
            bool JaErHat = true;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            // SQL Query to find overlapping appointments
            string abfrage = @"
             SELECT finde = 1
              FROM Terminen 
                      INNER JOIN Daten ON Terminen.DatumID = Daten.DatumID
                WHERE PatientID = @PatientID 
			    And @TerminDatumToCheck = Daten.Datum"; 
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PatientID", patientID);
                command.Parameters.AddWithValue("@TerminDatumToCheck", TerminDatumToCheck);
     
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
                    throw new Exception("Fehler ist aufgetreten " + ex.Message);
                }
            }
            return JaErHat;
        }

        public static DataTable GetAllAppoitments()
        {
            DataTable dt = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * from Terminen_View
                                Order by TerminID Desc";
                                     

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(abfrage, connection))
                {
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
                        throw new Exception("Fehler bei GetAllAppointment Methode : " + ex.Message);
                    }
                }
            }
            
            return dt;
        }

        public static bool DoesHavePatientAnAppointment(int PatientID)
        {
            object result;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            string abfrage = @"select Case
                                 When Exists(select 1 from Terminen  
	                                 Inner Join Patients On Terminen.PatientID = Patients.PatientID
				                Where Patients.PatientID =  @PatientID)
	                            Then 1
	                            Else 0
	                           End as Find";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);

                        connection.Open();
                         result = command.ExecuteScalar();
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Fehler bei DoesHavePatientAnAppointment Methode. : " + ex.Message);
            }
            return result != null && Convert.ToInt32(result) == 1;
        }

        public static bool IsAppointmentDone(int TerminID)
        {
            bool isDone = false;
            string abfrage = @"Select Find = 1 From Terminen
                                        Where TerminID = @TerminID 
                                        And   TerminStatus = 1";

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@TerminID", TerminID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isDone = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler bei IsAppointmentDone Methode. : " + ex.Message);
            }
            return isDone;
        }
    }
}
