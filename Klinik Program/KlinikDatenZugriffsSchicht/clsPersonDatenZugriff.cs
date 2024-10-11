using Microsoft.SqlServer.Server;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace KlinikDatenZugriffsSchicht
{        
    public class clsPersonDatenZugriff
    {
        public static bool GetPersonDataByPersonID(int PersonID, ref string AusweisID, ref string Vorname,
            ref string Nachname, ref DateTime GeburtsTag, ref DateTime RegistrierungsDatum, ref byte Geschlecht, ref int LandID,
          ref string Stadt, ref string Postleitzahl, ref string Straße,
          ref string Hausnummer, ref string Email, ref string TelefonNummer, ref string FotoPfad)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Personen     Where PersonID = @PersonID";

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
                            //wenn das object gefungen ist
                            isFound = true;

                            AusweisID = (string)reader["AusweisID"];
                            Vorname = (string)reader["Vorname"];
                            Nachname = (string)reader["Nachname"];
                            GeburtsTag = (DateTime)reader["GeburtsTag"];
                            RegistrierungsDatum = (DateTime)reader["RegistrierungsDatum"];
                            Geschlecht = (byte)reader["Geschlecht"];
                            LandID = (int)reader["LandID"];
                            Stadt = (string)reader["Stadt"];
                            Postleitzahl = (string)reader["Postleitzahl"];
                            Straße = (string)reader["Straße"];
                            Hausnummer = (string)reader["HausNummer"];

                            Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty;
                            TelefonNummer = reader["TelefonNummer"] != DBNull.Value ? (string)reader["TelefonNummer"] : string.Empty;
                            FotoPfad = reader["FotoPfad"] != DBNull.Value ? (string)reader["FotoPfad"] : string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim Aufrufen der PersonDaten\n"+ ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return isFound;

        }
   
            public static bool GetPersonDataByNationalID(ref int PersonID, string AusweisID, ref string Vorname,
                ref string Nachname, ref DateTime GeburtsTag, ref DateTime RegistrierungsDatum, ref byte Geschlecht, ref int LandID,
                ref string Stadt, ref string Postleitzahl, ref string Straße,
             ref string Hausnummer, ref string Email, ref string TelefonNummer, ref string FotoPfad)
            {
                bool isFound = false;

                string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
                string abfrage = @"Select * From Personen     Where AusweisID = @AusweisID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@AusweisID", AusweisID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //wenn das object gefungen ist..           
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                Vorname = (string)reader["Vorname"];
                                Nachname = (string)reader["Nachname"];
                                GeburtsTag = (DateTime)reader["GeburtsTag"];
                                RegistrierungsDatum = (DateTime)reader["RegistrierungsDatum"];
                                Geschlecht = (byte)reader["Geschlecht"];
                                LandID = (int)reader["LandID"];
                                Stadt = (string)reader["Stadt"];
                                Postleitzahl = (string)reader["Postleitzahl"];
                                Straße = (string)reader["Straße"];
                                Hausnummer = (string)reader["HausNummer"];

                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty;
                                TelefonNummer = reader["TelefonNummer"] != DBNull.Value ? (string)reader["TelefonNummer"] : string.Empty;
                                FotoPfad = reader["FotoPfad"] != DBNull.Value ? (string)reader["FotoPfad"] : string.Empty;

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler beim Aufrufen der PersonDaten\n"+ ex.Message);
                }
                return isFound;
            }        

           public static bool GetPersonDataByEmailAdresse(ref int PersonID, ref string AusweisID, ref string Vorname,
          ref string Nachname, ref DateTime GeburtsTag, ref DateTime RegistrierungsDatum, ref byte Geschlecht, ref int LandID,
          ref string Stadt, ref string Postleitzahl, ref string Straße,
         ref string Hausnummer, string Email, ref string TelefonNummer, ref string FotoPfad)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Personen     Where Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //wenn das object gefungen ist
                            isFound = true;

                            PersonID = (int)reader["PersonID"];
                            AusweisID = (string)reader["AusweisID"];
                            Vorname = (string)reader["Vorname"];
                            Nachname = (string)reader["Nachname"];
                            GeburtsTag = (DateTime)reader["GeburtsTag"];
                            RegistrierungsDatum = (DateTime)reader["RegistrierungsDatum"];
                            Geschlecht = (byte)reader["Geschlecht"];
                            LandID = (int)reader["LandID"];
                            Stadt = (string)reader["Stadt"];
                            Postleitzahl = (string)reader["Postleitzahl"];
                            Straße = (string)reader["Straße"];
                            Hausnummer = (string)reader["HausNummer"];

                            TelefonNummer = reader["TelefonNummer"] != DBNull.Value ? (string)reader["TelefonNummer"] : string.Empty;
                            FotoPfad = reader["FotoPfad"] != DBNull.Value ? (string)reader["FotoPfad"] : string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim Aufrufen der PersonDaten\n"+ ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return isFound;
        }

        public static bool GetPersonDataByPersonName(string PersonName, ref int PersonID, ref string AusweisID, ref string Vorname,
       ref string Nachname, ref DateTime GeburtsTag, ref DateTime RegistrierungsDatum, ref byte Geschlecht, ref int LandID,
       ref string Stadt, ref string Postleitzahl, ref string Straße,
    ref string Hausnummer, ref string Email, ref string TelefonNummer, ref string FotoPfad)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Personen  
                                 Where Trim(Personen.Vorname) + ' ' + Trim(Personen.Nachname) = @PersonName";

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
                            //wenn das object gefungen ist
                            isFound = true;

                            PersonID = (int)reader["PersonID"];
                            AusweisID = (string)reader["AusweisID"];
                            Vorname = (string)reader["Vorname"];
                            Nachname = (string)reader["Nachname"];
                            GeburtsTag = (DateTime)reader["GeburtsTag"];
                            RegistrierungsDatum = (DateTime)reader["RegistrierungsDatum"];
                            Geschlecht = (byte)reader["Geschlecht"];
                            LandID = (int)reader["LandID"];
                            Stadt = (string)reader["Stadt"];
                            Postleitzahl = (string)reader["Postleitzahl"];
                            Straße = (string)reader["Straße"];
                            Hausnummer = (string)reader["HausNummer"];
                            Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty;
                            TelefonNummer = reader["TelefonNummer"] != DBNull.Value ? (string)reader["TelefonNummer"] : string.Empty;
                            FotoPfad = reader["FotoPfad"] != DBNull.Value ? (string)reader["FotoPfad"] : string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim Aufrufen der PersonDaten\n"+ ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return isFound;
        }
        public static int GetPatientDataByPersonNamen(string PersonName)
        {
            int PersonID = -1;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"select Personen.PersonID
                                  From   Personen  
                                  INNER JOIN Patients ON Personen.PersonID = Patients.PersonID
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


                            PersonID = (int)reader["PersonID"];
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Fehler beim GetPerosnDatenByID Methode "+ ex.Message);
                }
            }
            return PersonID;
        }
        public static int AddNewPerson(string AusweisID,string Vorname, string Nachname,
         DateTime GeburtsTag, DateTime RegistrierungsDatum, byte Geschlecht,int LandID, string Stadt, string Postleitzahl, string Straße,
          string Hausnummer, string Email, string TelefonNummer, string FotoPfad)
        {
            int PersonID = -1;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"INSERT INTO Personen 
                                (AusweisID, Vorname, Nachname, GeburtsTag,RegistrierungsDatum,
                                  Geschlecht,LandID, Stadt, Postleitzahl, 
                                Straße,HausNummer, Email, TelefonNummer, FotoPfad)
                          VALUES 
                                (@AusweisID, @Vorname, @Nachname, @GeburtsTag, @RegistrierungsDatum,
                                @Geschlecht,@LandID, @Stadt, 
                                 @Postleitzahl, @Straße, @HausNummer, @Email,
                                 @TelefonNummer, @FotoPfad)
                         SELECT SCOPE_IDENTITY()";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@AusweisID", AusweisID);
                command.Parameters.AddWithValue("@Vorname", Vorname);
                command.Parameters.AddWithValue("@Nachname", Nachname);
                command.Parameters.AddWithValue("@GeburtsTag", GeburtsTag);
                command.Parameters.AddWithValue("@RegistrierungsDatum", RegistrierungsDatum);
                command.Parameters.AddWithValue("@Geschlecht", Geschlecht);
                command.Parameters.AddWithValue("@LandID", LandID);
                command.Parameters.AddWithValue("@Stadt", Stadt);
                command.Parameters.AddWithValue("@Postleitzahl", Postleitzahl);
                command.Parameters.AddWithValue("@Straße", Straße);
                command.Parameters.AddWithValue("@HausNummer", Hausnummer);

                if (string.IsNullOrEmpty(Email))
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Email", Email);

                if (string.IsNullOrEmpty(TelefonNummer))
                    command.Parameters.AddWithValue("@TelefonNummer", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@TelefonNummer", TelefonNummer);

                if (string.IsNullOrEmpty(FotoPfad))
                    command.Parameters.AddWithValue("@FotoPfad", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@FotoPfad", FotoPfad);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                    {
                        PersonID = InsertedID;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler beim Hinzufügen dieser Person.\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return PersonID;
            }
        }

        public static bool UpdatePerson(int PersonID,string AusweisID, string Vorname, string Nachname,
         DateTime GeburtsTag, DateTime RegistrierungsDatum,byte Geschlecht,int LandID, string Stadt, string Postleitzahl, string Straße,
          string Hausnummer, string Email, string TelefonNummer, string FotoPfad)
        {
            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Update Personen 
                                       SET
                                              AusweisID =  @AusweisID,
                                              Vorname = @Vorname,
                                              Nachname = @Nachname,
                                              GeburtsTag = @GeburtsTag,
                                              RegistrierungsDatum = @RegistrierungsDatum,
                                              Geschlecht = @Geschlecht,
                                              LandID     = @LandID,
                                              Stadt   = @Stadt,
                                              Postleitzahl = @Postleitzahl,
                                              Straße  = @Straße,
                                              HausNummer = @HausNummer,
                                              Email  = @Email,
                                              TelefonNummer = @TelefonNummer,
                                              FotoPfad  = @FotoPfad
                              Where PersonID  = @PersonID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@AusweisID", AusweisID);
                command.Parameters.AddWithValue("@Vorname", Vorname);
                command.Parameters.AddWithValue("@Nachname", Nachname);
                command.Parameters.AddWithValue("@GeburtsTag", GeburtsTag);
                command.Parameters.AddWithValue("@RegistrierungsDatum", RegistrierungsDatum);
                command.Parameters.AddWithValue("@Geschlecht", Geschlecht);
                command.Parameters.AddWithValue("@LandID", LandID);
                command.Parameters.AddWithValue("@Stadt", Stadt);
                command.Parameters.AddWithValue("@Postleitzahl", Postleitzahl);
                command.Parameters.AddWithValue("@Straße", Straße);
                command.Parameters.AddWithValue("@HausNummer", Hausnummer);

                if (string.IsNullOrEmpty(Email))
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Email", Email);

                if (string.IsNullOrEmpty(TelefonNummer))
                    command.Parameters.AddWithValue("@TelefonNummer", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@TelefonNummer", TelefonNummer);

                if (string.IsNullOrEmpty(FotoPfad))
                    command.Parameters.AddWithValue("@FotoPfad", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@FotoPfad", FotoPfad);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler beim Aktualisieren dieser Person.\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return (BetroffeneZeile > 0);
            }
        }

        public static bool DeletePerson(int PersonID)
        {
            int BetroffeneZeile = 0; 
            
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Delete From Personen   Where PersonID = @PersonID ";

            using(SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler beim Löschen dieser Person.\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return (BetroffeneZeile > 0);
            }
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select Find=1  From Personen   Where PersonID = @PersonID ";


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
                    isFound = false;
                    throw new Exception("Fehler beim Suchen.\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return isFound;
            }
        }

        public static bool IsPersonExist(string AusweisID)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select Find=1  From Personen   Where AusweisID = @AusweisID ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@AusweisID", AusweisID);

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
                    isFound = false;
                    throw new Exception("Fehler beim Suchen.\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return isFound;
            }
        }

        public static bool IsPersonExistByEmailAdresse(string Email)
        {
            bool isFound = false;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select Find=1  From Personen   Where Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

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
                    isFound = false;
                    throw new Exception("Fehler beim Suchen.\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return isFound;
            }
        }

        public static bool IsNationalIDFrei(string AusweisID)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            string abfrage = @"Select Find=1  From Personen   Where AusweisID = @AusweisID ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@AusweisID", AusweisID);

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
                    isFound = false;
                    throw new Exception("Fehler beim Suchen.\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return isFound;
            }
        }

        public static DataTable GetAllPersons()
        {
            DataTable dtPersonen = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"
                            Select Personen.PersonID,Personen.AusweisID, Personen.Vorname + ' ' + Personen.Nachname 
                                                                   As Vollname,
                             Personen.GeburtsTag, Personen.RegistrierungsDatum,

                                      Case 
                                      WHEN Personen.Geschlecht = 0   THEN  'Maenlich'
                                      Else  'Weiblich'
									  End as Geschlecht,
									   
                              CountryName ,Personen.Stadt, Personen.Postleitzahl,Personen.Straße, Personen.HausNummer,
                               Personen.Email, Personen.TelefonNummer, Personen.FotoPfad
                        
                        From Personen  INNER JOIN Countries ON
                        Personen.LandID = Countries.CountryID
				        Order by PersonID Desc";

            using(SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(abfrage,connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dtPersonen.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler beim Laden der PersonenDaten .\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dtPersonen;
            }

        }

        public static DataTable GetPersonenRecordsProSeite(int ZeileProSeite, int SeiteNummer)
        {
            DataTable dt = new DataTable();

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("Sp_GetRecordsProSeite", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ZeileProSeite",ZeileProSeite);
                        command.Parameters.AddWithValue("@SeiteNummer", SeiteNummer);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }

                    }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("Fehler beim Laden der PersonenDaten.\n" + ex.Message);
            }
            return dt;
        }

    }
    
}
