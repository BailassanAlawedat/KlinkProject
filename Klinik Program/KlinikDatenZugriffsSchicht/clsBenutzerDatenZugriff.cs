using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http.Headers;


public class DatenZugriffException : Exception
{
    public DatenZugriffException(string message) : base(message) { }
    public DatenZugriffException(string message, Exception innerMessage) : base(message) { }
}
namespace KlinikDatenZugriffsSchicht
{

    public class clsBenutzerDatenZugriff
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            
        public static object ExecuteScaler(string abfrage, Action<SqlCommand> ParameterAnBefehlAnhängen)
        {
                object result;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(abfrage, connection))
                        {
                            ParameterAnBefehlAnhängen(command);
                            connection.Open();
                            result = command.ExecuteScalar();
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new DatenZugriffException("Fehler beim Abrufen des Werts aus der Datenbank: " + ex.Message, ex);
                }
                return result;
        }

        public static int ExecuteNoneQuery(string abfrage, Action<SqlCommand> ParameterAnBefehlAnhängen)
        {

            int BetroffeneZeile = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        ParameterAnBefehlAnhängen(command);
                        connection.Open();
                        BetroffeneZeile = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatenZugriffException("Fehler beim Abrufen des DataReaders: " + ex.Message, ex);
            }
            return BetroffeneZeile;
        }

        public static SqlDataReader ExecuteReader(string abfrage, Action<SqlCommand> ParameterAnBefehlAnhängen)
        {
            SqlDataReader reader = null;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand command = new SqlCommand(abfrage, connection);     
                ParameterAnBefehlAnhängen(command);
                connection.Open();
                // Gibt den SqlDataReader zurück und sorgt dafür, dass die Verbindung geschlossen wird, wenn der Reader geschlossen wird
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch(Exception ex)
            {
                connection.Dispose(); // Sicherstellen, dass die Verbindung im Fehlerfall freigegeben wird
                throw new DatenZugriffException("Fehler beim Abrufen des DateReaders: " + ex.Message, ex);
            }
        }

        public static bool ExecuteReaderWithBooleen(string abfrage, Action<SqlCommand> ParameterAnBefehlAnhängen)
        {
            SqlDataReader reader = null;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand command = new SqlCommand(abfrage, connection);
                ParameterAnBefehlAnhängen(command);
                connection.Open();
                //Gibt die SqlDataReader zurück und sorgt dafür,dass die Verbindung geschlossen wird.
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader.HasRows;

            }
           
            catch (Exception ex)
            {
                connection.Dispose(); //Sicherstellen, dass die Verbindung im Fehlerfall freigegeben wird.
                throw new DatenZugriffException("Fehler beim Abrufen des DateReaders: " + ex.Message, ex);
            }
        }
        public static bool FindUserByID(int BenutzerID, ref int PersonID, ref string Rollenname, ref string Passwort,
            ref DateTime? ErstelltAm, ref DateTime? AktualisiertAm, ref DateTime? LetzterLogin, ref bool IstAktive)
        {
            bool isFound = false;
            string abfrage = @"Select * from Benutzer  where BenutzerID = @BenutzerID";

            using (SqlDataReader reader = ExecuteReader(abfrage, command =>
            command.Parameters.AddWithValue("@BenutzerID", BenutzerID)))
            {
                if (reader.Read())
                {
                    isFound = true;  // Daten für Benutzer wurden gefunden.

                    PersonID = (int)reader["PersonID"];
                    Rollenname = (string)reader["Rollenname"];

                    string entSchlüsseltesPasswort = clsVerschlüsselungHelfer.Decrypt((string)reader["BenutzerPasswort"]);
                    Passwort = entSchlüsseltesPasswort;

                    ErstelltAm = (DateTime)reader["ErstelltAm"];
                    AktualisiertAm = (DateTime)reader["AktualisiertAm"];
                    LetzterLogin = (DateTime)reader["LetzterLogin"];
                    IstAktive = (bool)reader["IstAktive"];
                }

            }
            return isFound;
        }

        public static bool FindUserByPersonID(ref int BenutzerID, int PersonID, ref string Rollenname, ref string Passwort,
         ref DateTime? ErstelltAm, ref DateTime? AktualisiertAm, ref DateTime? LetzterLogin, ref bool IstAktive)
        {
            bool isFound = false;
            string abfrage = @"Select * from Benutzer  where PersonID = @PersonID";

            using (SqlDataReader reader = ExecuteReader(abfrage, command =>
            command.Parameters.AddWithValue("@PersonID", PersonID)))
            {

                if (reader.Read())
                {
                    isFound = true;  // Daten für Benutzer wurden gefunden.

                    BenutzerID = (int)reader["BenutzerID"];
                    Rollenname = (string)reader["Rollenname"];

                    string DBPasswort = (string)reader["BenutzerPasswort"];
                    string EntschlüsseltesPassword = clsVerschlüsselungHelfer.Decrypt(DBPasswort);
                    Passwort = EntschlüsseltesPassword;

                    ErstelltAm = (DateTime)reader["ErstelltAm"];
                    AktualisiertAm = (DateTime)reader["AktualisiertAm"];
                    LetzterLogin = (DateTime)reader["LetzterLogin"];
                    IstAktive = (bool)reader["IstAktive"];
                }

            }
            return isFound;


        }
        public static int AddNeuUser(int? PersonID, string Rollenname, string Passwort,
            DateTime? ErstelltAm, DateTime? AktualisiertAm, DateTime? LetzterLogin, bool IstAktive)
        {

            string VerschlüsseltesPasswort = clsVerschlüsselungHelfer.Encrypt(Passwort);

            string abfrage = @"INSERT INTO Benutzer (PersonID, Rollenname, BenutzerPasswort, ErstelltAm, AktualisiertAm,
                                                     LetzterLogin, IstAktive)
                                            VALUES  (@PersonID, @Rollenname, @Passwort, @ErstelltAm, @AktualisiertAm,
                                                      @LetzterLogin, @IstAktive)
                                           SELECT SCOPE_IDENTITY()";

            object result = ExecuteScaler(abfrage, command =>
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@Rollenname", Rollenname);
                command.Parameters.AddWithValue("@Passwort", VerschlüsseltesPasswort);
                command.Parameters.AddWithValue("@ErstelltAm", ErstelltAm);
                command.Parameters.AddWithValue("@AktualisiertAm", AktualisiertAm);
                command.Parameters.AddWithValue("@LetzterLogin", LetzterLogin);
                command.Parameters.AddWithValue("@IstAktive", IstAktive);
            });

            return (result != null && int.TryParse(result.ToString(), out int UserID)) ? UserID : -1;
        }

        public static bool UpdateUserByID(int? BenutzerID, int? PersonID, string Rollenname, string Passwort,
           DateTime? ErstelltAm, DateTime? AktualisiertAm, DateTime? LetzterLogin, bool IstAktive)
        {

            string VerschlüsseltesPasswort = clsVerschlüsselungHelfer.Encrypt(Passwort);

            string abfrage = @"Update Benutzer 
                                      Set  
                                           PersonID = @PersonID,
                                           Rollenname   = @Rollenname,
                                           BenutzerPasswort = @VerschlüsseltesPasswort,
                                           ErstelltAm = @ErstelltAm,
                                           AktualisiertAm = @AktualisiertAm,
                                          LetzterLogin   = @LetzterLogin,
                                          IstAktive     =  @IstAktive
                                   Where  BenutzerID = @BenutzerID";

            int BetroffeneZeile = ExecuteNoneQuery(abfrage, command =>
            {
                command.Parameters.AddWithValue("@BenutzerID", BenutzerID);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@Rollenname", Rollenname);
                command.Parameters.AddWithValue("@VerschlüsseltesPasswort", VerschlüsseltesPasswort);
                command.Parameters.AddWithValue("@ErstelltAm", ErstelltAm);
                command.Parameters.AddWithValue("@AktualisiertAm", AktualisiertAm);
                command.Parameters.AddWithValue("@LetzterLogin", LetzterLogin);
                command.Parameters.AddWithValue("@IstAktive", IstAktive);
            });

            return BetroffeneZeile > 0;
        }

        public static bool UpdatePasswortByRollenname(string Rollenname, string neuesPasswort)
        {
            string VerschlüsseltesPasswort = clsVerschlüsselungHelfer.Encrypt(neuesPasswort);

            string abfrage = @"Update Benutzer
                                    Set 
                                        BenutzerPasswort = @VerschlüsseltesPasswort
                                   Where  Rollenname = @Rollenname";

            int BetroffeneZeile = ExecuteNoneQuery(abfrage, command =>
            {
                command.Parameters.AddWithValue("@Rollenname", Rollenname);
                command.Parameters.AddWithValue("@VerschlüsseltesPasswort", VerschlüsseltesPasswort);
            });

            return BetroffeneZeile > 0;
        }

        public static bool UpdateLetzterLoginByRollenname(string Rollenname)
        {
            DateTime LetzterLogin = DateTime.Now;

            string abfrage = @"Update Benutzer
                                    Set 
                                        LetzterLogin = @LetzterLogin
                                   Where  Rollenname = @Rollenname";

            int BetroffeneZeile = ExecuteNoneQuery(abfrage, command =>
            {
                command.Parameters.AddWithValue("@Rollenname", Rollenname);
                command.Parameters.AddWithValue("@LetzterLogin", LetzterLogin);
            });

            return BetroffeneZeile > 0;
        }
        public static bool FindUserByUserRolleAndUserPassword(ref int BenutzerID, ref int PersonID, string Rollenname, string Passwort,
          ref DateTime? ErstelltAm, ref DateTime? AktualisiertAm, ref DateTime? LetzterLogin, ref bool IstAktive)
        {
            bool isFound = false;

            string abfrageGetPasswort = "Select BenutzerPasswort from Benutzer  where Rollenname = @Rollenname";

            object result = ExecuteScaler(abfrageGetPasswort, command =>
            {
                command.Parameters.AddWithValue("@Rollenname", Rollenname);
            });

            if(result == null)
            {
                isFound =false;
                return isFound;
            }
            string verschlüsseltesPasswortInDb = result.ToString();
       

            if (string.IsNullOrEmpty(verschlüsseltesPasswortInDb))
            {
                isFound = false;
            }

            string VerschlüsselteEingegebenesPasswort = clsVerschlüsselungHelfer.Encrypt(Passwort);
            if (VerschlüsselteEingegebenesPasswort != verschlüsseltesPasswortInDb)
            {
                isFound = false;
            }

            string abfrage = @"Select * From Benutzer
                                       Where      Rollenname   = @Rollenname
                                        And      BenutzerPasswort = @VerschlüsselteEingegebenesPasswort";


            using (SqlDataReader reader = ExecuteReader(abfrage, command =>
            {
                command.Parameters.Add("@Rollenname", SqlDbType.NVarChar).Value = Rollenname;
                command.Parameters.Add("@VerschlüsselteEingegebenesPasswort", SqlDbType.NVarChar).Value= VerschlüsselteEingegebenesPasswort;

            }))
            {
                if (reader.Read())
                {
                    isFound = true;  // Daten für Benutzer wurden gefunden.

                    BenutzerID = (int)reader["BenutzerID"];
                    PersonID = (int)reader["PersonID"];
                    Rollenname = (string)reader["Rollenname"];

                    string entSchlüsseltesPasswort = clsVerschlüsselungHelfer.Decrypt((string)reader["BenutzerPasswort"]);
                    Passwort = entSchlüsseltesPasswort;

                    ErstelltAm = (DateTime)reader["ErstelltAm"];
                    AktualisiertAm = (DateTime)reader["AktualisiertAm"];
                    LetzterLogin = (DateTime)reader["LetzterLogin"];
                    IstAktive = (bool)reader["IstAktive"];
                }
            }
            return isFound;
        }

        public static bool Delete(int BenutzerID)
        {

            string abfrage = @"Delete From Benutzer   Where BenutzerID = @BenutzerID";

            int BetroffeneZeile = ExecuteNoneQuery(abfrage, command =>
                command.Parameters.AddWithValue("@BenutzerID", BenutzerID)  
            );
            return BetroffeneZeile > 0;
        }

        public static bool DeactivateUser(int BenutzerID)
        {
           
            string abfrage = @"Update Benutzer  
                                        Set   
                                            IstAktive = 0 
                                       Where BenutzerID = @BenutzerID";

            int BetroffeneZeile = ExecuteNoneQuery(abfrage, command =>
                 command.Parameters.AddWithValue("@BenutzerID", BenutzerID)
             );
            return BetroffeneZeile > 0;
        }

        public static bool ActivateUser(int BenutzerID)
        {

            string abfrage = @"Update Benutzer  
                                        Set   
                                            IstAktive = 1
                                       Where BenutzerID = @BenutzerID";

            int BetroffeneZeile = ExecuteNoneQuery(abfrage, command =>
                 command.Parameters.AddWithValue("@BenutzerID", BenutzerID)
             );
            return BetroffeneZeile > 0;
        }

        public static bool DoesUserExistsForThisPerson(int PersonID)
        {
            string abfrage = @"Select Find=1 From Benutzer  
                                       Where Benutzer.PersonID = @PersonID";


            bool isFound = ExecuteReaderWithBooleen(abfrage, command =>
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
            });
            return isFound;
        }

        public static bool DoesRollenNameExistsInDB(string Rollenname)
        {
            string abfrage = @"Select Find = 1 From Benutzer
                                           Where Rollenname  = @Rollenname";

            bool isExists = ExecuteReaderWithBooleen(abfrage, command =>
            {
                command.Parameters.Add("@Rollenname", SqlDbType.NVarChar).Value = Rollenname;
            });
            return isExists;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            string abfrage = @"select BenutzerID , PersonID, Rollenname, ErstelltAm,
                                      AktualisiertAm, LetzterLogin,
                                          Case
                                          When IstAktive = 1 Then 'Aktive'
                                          Else 'Nicht Aktive' 
                                           End As Status
                                      from Benutzer
                                 Order by BenutzerID Desc";

            using (SqlDataReader reader = ExecuteReader(abfrage, command => {/* Kein Parameter erforderlich */ }))
            {
                if(reader.HasRows)
                     dt.Load(reader);
            }

            return dt;
        }
    }

}
