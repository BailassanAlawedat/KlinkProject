using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace KlinikDatenZugriffsSchicht
{
    public class DatenZugriffException : Exception
    {
        public DatenZugriffException(string message) : base(message) { }
        public DatenZugriffException(string message, Exception innerMessage) : base(message) { }
    }
    public class clsRezepteDatenZugriff
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;


        private static object ExecuteScaler(string abfrage, Action<SqlCommand> ParameterAnBefehlAnhägen)
        {
            object result;
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        ParameterAnBefehlAnhägen(command);
                        connection.Open();
                        result = command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DatenZugriffException("Fehler beim Abrufen des Werts aus der Datenbank: " + ex.Message, ex);
            }
            return result;
        }

        private static SqlDataReader ExecuteReader(string abfrage, Action<SqlCommand> ParameterAnBefehlAnhägen)
        {
            // Notizen mit sqlReader verwenden wir keine Using-statment wegen einem Problem mit der Verbindung.
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand command = new SqlCommand(abfrage, connection);
                   
                 ParameterAnBefehlAnhägen(command);
                  connection.Open();
                  // zurckgibt die sqldataread und sorgt dafür , dass die verbindung geschlossen wird.
                 SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                 return reader;
                           
            }
            catch (Exception ex)
            {
                connection.Dispose(); //Stellsicher, dass die Verbindung im Fehlerfall freigegeben wird.
                throw new DatenZugriffException("Fehler beim Abrufen des DataReaders: " + ex.Message, ex);
            }
        }

        private static bool ExecuteReaderWithBoolean(string abfrage, Action<SqlCommand> ParameterAnBefehlAnhägen)
        {
            // Notizen mit sqlReader verwenden wir keine Using-statment wegen einem Problem mit der Verbindung. wenn reader geschlossen wird.
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand command = new SqlCommand(abfrage, connection);

                ParameterAnBefehlAnhägen(command);
                connection.Open();
                // Gibt die sqldataread zurück und sorgt dafür , dass die verbindung geschlossen wird.
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader.HasRows;

            }
            catch (Exception ex)
            {
                connection.Dispose(); //Stellsicher, dass die Verbindung im Fehlerfall freigegeben wird.
                throw new DatenZugriffException("Fehler beim Abrufen des DataReaders: " + ex.Message, ex);
            }
        }

        private static int ExecuteNonQuery(string abfrage, Action<SqlCommand> ParameterAnBefehlAnhängen)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        ParameterAnBefehlAnhängen(command);
                        connection.Open();
                        int BetroffeneZeile = command.ExecuteNonQuery();

                        return BetroffeneZeile;
                    }
                }
            }
            catch (Exception ex)    
            {
                throw new DatenZugriffException("Fehler beim Abrufen des DataReaders: " + ex.Message, ex);
            }
        }

        public static bool FindRezeptByID(int rezeptID, ref int VersicherungsID, ref string rezeptName, ref string Dosierung,
       ref string Häufigkeit, ref DateTime StartDatum, ref DateTime EndDatum, ref string SpezielleAnweisungen,
            ref int TerminID)
        {
            bool isFound = false;
            string abfrage = @"Select * from Rezepte  where RezeptID = @RezeptID";

            using (SqlDataReader reader = ExecuteReader(abfrage, command =>
            command.Parameters.AddWithValue("@RezeptID", rezeptID)))
            {
                if (reader.Read())
                {
                    isFound = true;  // Daten für Rezepte wurden gefunden.

                    VersicherungsID= (int)reader["VersicherungID"];
                    rezeptName = (string)reader["Rezeptname"];
                    Dosierung = reader["Dosierung"] != DBNull.Value ? (string)reader["Dosierung"] : string.Empty;
                    Häufigkeit = reader["Häufigkeit"] != DBNull.Value ? (string)reader["Häufigkeit"] : string.Empty;
                    StartDatum= (DateTime)reader["StartDatum"];
                    EndDatum = (DateTime)reader["EndDatum"];
                    SpezielleAnweisungen = reader["SpezielleAnweisungen"] != DBNull.Value ? (string)reader["SpezielleAnweisungen"] : string.Empty;
                    TerminID = (int)reader["TerminID"];
                }

            }
            return isFound;
        }

        public static bool FindRezeptByTerminID(ref int rezeptID, ref int VersicherungsID, ref string rezeptName, ref string Dosierung,
      ref string Häufigkeit, ref DateTime StartDatum, ref DateTime EndDatum, ref string SpezielleAnweisungen,
           int TerminID)
        {
            bool isFound = false;
            string abfrage = @"Select * from Rezepte  where TerminID = @TerminID";

            using (SqlDataReader reader = ExecuteReader(abfrage, command =>
            command.Parameters.AddWithValue("@TerminID", TerminID)))
            {
                if (reader.Read())
                {
                    isFound = true;  // Daten für Rezepte wurden gefunden.

                    rezeptID = (int)reader["RezeptID"];
                    VersicherungsID= (int)reader["VersicherungID"];
                    rezeptName = (string)reader["Rezeptname"];
                    Dosierung = reader["Dosierung"] != DBNull.Value ? (string)reader["Dosierung"] : string.Empty;
                    Häufigkeit = (string)reader["Häufigkeit"] ;
                    StartDatum= (DateTime)reader["StartDatum"];
                    EndDatum = (DateTime)reader["EndDatum"];
                    SpezielleAnweisungen = (string)reader["SpezielleAnweisungen"];
                }

            }
            return isFound;
        }
        public static int AddNewRezept(int VersicherungsID, string rezeptName, string Dosierung,
        string Häufigkeit, DateTime StartDatum, DateTime EndDatum,string SpezielleAnweisungen, int TerminID)
        {


            string abfrage = @"INSERT INTO Rezepte (VersicherungID, Rezeptname, Dosierung, Häufigkeit, StartDatum,
                                                     EndDatum, SpezielleAnweisungen, TerminID)
                                            VALUES  (@VersicherungID, @Rezeptname, @Dosierung, @Häufigkeit, @StartDatum,
                                                     @EndDatum, @SpezielleAnweisungen,@TerminID)
                                           SELECT SCOPE_IDENTITY()";

            object result = ExecuteScaler(abfrage, command =>
            {
                command.Parameters.AddWithValue("@VersicherungID", VersicherungsID);
                command.Parameters.AddWithValue("@Rezeptname", rezeptName);

                if(!string.IsNullOrEmpty(Dosierung))
                     command.Parameters.AddWithValue("@Dosierung", Dosierung);
                else
                    command.Parameters.AddWithValue("@Dosierung", DBNull.Value);

                command.Parameters.AddWithValue("@Häufigkeit", Häufigkeit);
                command.Parameters.AddWithValue("@StartDatum", StartDatum);
                command.Parameters.AddWithValue("@EndDatum", EndDatum);
                command.Parameters.AddWithValue("@SpezielleAnweisungen",SpezielleAnweisungen);
                command.Parameters.AddWithValue("@TerminID", TerminID);
            });

            return (result != null && int.TryParse(result.ToString(), out int UserID)) ? UserID : -1;
        }

        public static bool UpdateRezept(int RezeptID, int VersicherungsID, string rezeptName, string Dosierung,
        string Häufigkeit, DateTime StartDatum, DateTime EndDatum, string SpezielleAnweisungen, int TerminID)
        {

            string abfrage = @"Update Rezepte
                                      Set  
                                           VersicherungID = @VersicherungID,
                                          Rezeptname  = @Rezeptname,
                                           Dosierung = @Dosierung,
                                           Häufigkeit = @Häufigkeit,
                                           StartDatum= @StartDatum,
                                           EndDatum   = @EndDatum,
                                         SpezielleAnweisungen = @SpezielleAnweisungen,
                                              TerminID  = @TerminID
                                   Where RezeptID = @RezeptID";

            int BetroffeneZeile = ExecuteNonQuery(abfrage, command =>
            {
                command.Parameters.AddWithValue("@RezeptID", RezeptID);
                command.Parameters.AddWithValue("@VersicherungID", VersicherungsID);
                command.Parameters.AddWithValue("@Rezeptname", rezeptName);

                if (!string.IsNullOrEmpty(Dosierung))
                    command.Parameters.AddWithValue("@Dosierung", Dosierung);
                else
                    command.Parameters.AddWithValue("@Dosierung", DBNull.Value);

                command.Parameters.AddWithValue("@Häufigkeit", Häufigkeit);
                command.Parameters.AddWithValue("@StartDatum", StartDatum);
                command.Parameters.AddWithValue("@EndDatum", EndDatum);
                command.Parameters.AddWithValue("@SpezielleAnweisungen", SpezielleAnweisungen);
                command.Parameters.AddWithValue("@TerminID", TerminID);
            });

            return BetroffeneZeile > 0;
        }

        public static bool Delete(int RezeptID)
        {

            string abfrage = @"Delete From Rezepte   Where RezeptID = @RezeptID";

            int BetroffeneZeile = ExecuteNonQuery(abfrage, command =>
                command.Parameters.AddWithValue("@RezeptID", RezeptID)
            );
            return BetroffeneZeile > 0;
        }
        
        public static bool DoesHavAppoitentRezept(int TerminID)
        {
            string abfrage = @"select Case
                                     When Exists (
                                             	select  1 From Rezepte 
                                               Inner join Terminen On Rezepte.TerminID = Terminen.TerminID
                                               Where Terminen.TerminID = @TerminID )
	                                            then 1
	                                            Else 0
                                             End";

            object result = ExecuteScaler(abfrage, command =>
            {
                command.Parameters.AddWithValue("@TerminID", TerminID);
            });

            return result != null && Convert.ToInt32(result) == 1;
        }
        public static DataTable GetAllRezepte()
        {
            DataTable dt = new DataTable();

            string abfrage = @"select * From Rezepte 
                                 Order by RezeptID Desc";

            using (SqlDataReader reader = ExecuteReader(abfrage, command => {/* Kein Parameter erforderlich */ }))
            {
                if (reader.HasRows)
                    dt.Load(reader);
            }

            return dt;
        }
    }
}
