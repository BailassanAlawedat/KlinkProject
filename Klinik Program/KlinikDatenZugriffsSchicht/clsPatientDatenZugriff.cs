using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace KlinikDatenZugriffsSchicht
{
    public class clsPatientDatenZugriff
    {
        public static bool GetPatientDatenByID(int PatientID, ref int PersonID)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Patients   where PatientID =  @PatientID";

            using(SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PatientID", PatientID);

                try
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            isFound = true;

                            PersonID = (int)reader["PersonID"];
                        }
                    }
                }
                catch(Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim GetPerosnDatenByID Methode "+ ex.Message);
                }
            }
            return isFound;
        }

        public static bool GetPatientDatenByTerminID(int TerminID, ref int PatientID, ref int PersonID)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Patients Inner Join Terminen ON
                                          Patients.PatientID = Terminen.PatientID
                                  Where  Terminen.TerminID = @TerminID";

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

                            PersonID = (int)reader["PersonID"];
                            PatientID = (int)reader["PatientID"];
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
        public static bool GetPatientDatenByPersonID(ref int PatientID, int PersonID)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select *  From Patients   where PersonID =  @PersonID";

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

                            PatientID = (int)reader["PatientID"];
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

        public static DataTable GetAllPatients()
        {
            DataTable dtPatient = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"
                select PatientID, Patients.PersonID, Personen.vorname + ' ' + Personen.Nachname AS Vollname ,
                        Personen.AusweisID, Personen.Geburtstag, Personen.RegistrierungsDatum, Personen.Email, Personen.TelefonNummer
                from    Patients Inner join Personen  On
                         Patients.PersonID = Personen.PersonID
                Order by PatientID Desc";
            
            using(SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(abfrage, connection))
            {
                try
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dtPatient.Load(reader);
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Fehler bei Methode GetAllPatients "+ ex.Message);
                }
            }

            return dtPatient;
        }

        public static int AddNeuPatient(int PersonID)
        {
            int PatientID = -1;
            DataTable dtPatient = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Insert into Patients (PersonID)
                                         Values  (@PersonID);
                              Select Scope_Identity()";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        PatientID = InsertedID;
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode AddNeuPatient "+ ex.Message);
                }
            }
            return PatientID;
        }

        public static bool IsPatientExistForPersonID(int PersonID)
        {
            bool isFound = false;

           string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @" Select Find=1 From Patients  Where PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);

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
                    throw new Exception("Fehler bei Methode DeletePatient "+ ex.Message);
                }
            }
            return isFound;
        }

        public static bool DeletePatient(int PatientID)
        {
            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString; 
            string abfrage = @"Delete from Patients 
                               Where PatientID = @PatientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PatientID", PatientID);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode DeletePatient "+ ex.Message);
                }
            }
            return (BetroffeneZeile > 0);
        }

    }
}
