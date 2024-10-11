using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace KlinikDatenZugriffsSchicht
{
    public class clsMitarbeiterDatenZugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool GetMitarbeiterbyID(int mitarbeiterID, ref int personID, ref int versicherungsID,
            ref string steuerID, ref string beruftsBezeichnung, ref string Abteilung, 
            ref string qualifikationen, ref  DateTime eingestelltAm, ref string GefeuertAm,
            ref int EingestelltBeiUser, ref bool IstAktive)
        {

            bool isfound = false;
            string abfrage = @"Select * From GetMitarbeiterByID(@MitarbeiterID)";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        command.Parameters.AddWithValue("@MitarbeiterID", mitarbeiterID);

                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isfound = true;

                                personID = (int)reader["PersonID"];
                                versicherungsID = (int)reader["VersicherungsID"];
                                steuerID = (string)reader["SteuerID"];
                                beruftsBezeichnung = (string)reader["BerufsBezeichnung"].ToString();
                                Abteilung = (string)reader["Abteilung"];
                                qualifikationen = (string)reader["Qualifikationen"].ToString();
                                eingestelltAm = (DateTime)reader["EingestelltAm"];
                                GefeuertAm = (string)reader["GefeuertAm"];
                                EingestelltBeiUser = (int)reader["EingestelltBeiUser"];
                                IstAktive = (bool)reader["IstAktive"];

                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                isfound = false;
                throw;
            }

            return isfound;
        }

        public static bool GetMitarbeiterbyPersonID(ref int mitarbeiterID, int personID, ref int versicherungsID,
     ref string steuerID, ref string beruftsBezeichnung, ref string Abteilung,
     ref string qualifikationen, ref DateTime eingestelltAm, ref string GefeuertAm,
      ref int EingestelltBeiUser, ref bool IstAktive)
        {

            bool isfound = false;

            string abfrage = @"Select * From Mitarbeiter where PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                mitarbeiterID = (int)reader["MitarbeiterID"];
                                versicherungsID = (int)reader["VersicherungsID"];
                                steuerID = (string)reader["SteuerID"];
                                beruftsBezeichnung = (string)reader["BerufsBezeichnung"].ToString();
                                Abteilung = (string)reader["Abteilung"];
                                qualifikationen =(string)reader["Qualifikationen"].ToString();
                                eingestelltAm = (DateTime)reader["EingestelltAm"];
                                GefeuertAm = (string)reader["GefeuertAm"].ToString();
                                EingestelltBeiUser = (int)reader["EingestelltBeiUser"];
                                IstAktive = (bool)reader["IstAktive"];

                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                isfound = false;
                throw;
            }

            return isfound;
        }



        public static DataTable GetAllMitarbeiter()
        {
            DataTable dt = new DataTable();

            string abfrage = @"Select * From  dbo.GetAllMitarbeiter()
                                                  Order by MitarbeiterID Desc";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
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
            catch (SqlException ex)
            {
                throw;
            }
            return dt;
        }

        public static bool DoesMitarbeiterExistForThisPerson(int PersonID)
        {
            bool isFound = false;
           string abfrage = "Select 1 From Mitarbeiter Where PersonID = @PersonID";
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();

                        object result = command.ExecuteScalar();
                        isFound = (result != null && (int)result == 1);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return isFound;
        }

        public static bool isMitarbeiterActiveForThisPersonID(int PersonID)
        {
            bool isActive = false;
            string abfrage = "Select 1 From Mitarbeiter Where PersonID = @PersonID And IstAktive = 1";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        isActive = (result != null && (int)result == 1);
                     
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return isActive;
        }
        public static int AddNewMitarbeiter(int personID, int versicherungsID,
           string steuerID, string beruftsBezeichnung,  string Abteilung,
           string qualifikationen, DateTime eingestelltAm, string GefeuertAm, 
           int EingestelltBeiUser, bool IstAktive)
        {
            int MitarbeiterID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Sp_AddNewMitarbeiter", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Über Parameter hinzufügen
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@VersicherungsID", versicherungsID);
                        command.Parameters.AddWithValue("@SteuerID", steuerID);
                        command.Parameters.AddWithValue("@Berufsbezeichnung", beruftsBezeichnung);
                        command.Parameters.AddWithValue("@Abteilung", Abteilung);
                        command.Parameters.AddWithValue("@Qualifikationen", qualifikationen);
                        command.Parameters.AddWithValue("@EingestelltAm", eingestelltAm); 
                        command.Parameters.AddWithValue("@GefeuertAm", GefeuertAm);
                        command.Parameters.AddWithValue("@EingestelltBeiUser", EingestelltBeiUser);
                        command.Parameters.AddWithValue("@IstAktive", IstAktive);

                        // Output-Parameter für die neue MitarbeiterID hinzufügen
                        SqlParameter outputparam = new SqlParameter("@NewMitarbeiterID", SqlDbType.Int)
                        {
                            // Diraction wird auf Output gesetzt.
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputparam);

                        connection.Open();
                        command.ExecuteNonQuery();


                        // Die neue MitarbeiterID aus dem Output-Parameter erhalten
                        MitarbeiterID = (int)outputparam.Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return MitarbeiterID;
        }

        public static bool UpdateMitarbeiter(int MitarbeiterID,int personID, int versicherungsID,
           string steuerID, string beruftsBezeichnung, string Abteilung,
           string qualifikationen, DateTime eingestelltAm, string GefeuertAm,
           int EingestelltBeiUser, bool IstAktive)
        {
            int RowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Sp_UpdateMitarbeiter", connection))
                    {
                        // Über Stored Procedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@MitarbeiterID", MitarbeiterID);
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@VersicherungsID", versicherungsID);
                        command.Parameters.AddWithValue("@SteuerID", steuerID);
                        command.Parameters.AddWithValue("@Berufsbezeichnung", beruftsBezeichnung);
                        command.Parameters.AddWithValue("@Abteilung", Abteilung);
                        command.Parameters.AddWithValue("@Qualifikationen", qualifikationen);
                        command.Parameters.AddWithValue("@EingestelltAm", eingestelltAm);
                        command.Parameters.AddWithValue("@GefeuertAm", GefeuertAm);
                        command.Parameters.AddWithValue("@EingestelltBeiUser", EingestelltBeiUser) ;
                        command.Parameters.AddWithValue("@IstAktive", IstAktive);
 
                        connection.Open();
                       RowAffected =  command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }

        public static bool DeleteMitarbeiter(int MitarbeiterID)
        {
            int RowAffected = 0;

            try
            {
                using(SqlConnection  connection =new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("Sp_DeleteMitarbeiter", connection))
                    {
                        // Stored Procedure
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MitarbeiterID", MitarbeiterID);

                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }

    }
}
