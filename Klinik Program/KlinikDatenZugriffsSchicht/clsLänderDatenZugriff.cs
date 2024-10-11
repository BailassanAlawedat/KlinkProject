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
    public class clsLänderDatenZugriff
    {
        public static DataTable GetAllCountries()
        {
            DataTable dtLänder = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * from Countries ";

            using(SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(abfrage,connection))
            {
                try
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dtLänder.Load(reader);
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return dtLänder;
        }

        public static bool GetCountryDataByName(ref int CountryID, string CountryName, ref string CountryCode,
                             ref string Continent)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Countries   Where CountryName = @CountryName";
            
            using(SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@CountryName", CountryName);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            isFound = true;

                            CountryID = (int)reader["CountryID"];
                            CountryCode = (string)reader["CountryCode"];
                            Continent = (string)reader["Continent"];
                        }
                    }
                }
                catch(Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim Suchen\n" + ex.Message);
                }
            }
            return isFound;
        }

        public static bool GetCountryDataByID(int CountryID, ref string CountryName, ref string CountryCode,
                            ref string Continent)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Countries   Where CountryID = @CountryID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@CountryID", CountryID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            CountryName = (string)reader["CountryName"];
                            CountryCode = (string)reader["CountryCode"];
                            Continent = (string)reader["Continent"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim Suchen\n" + ex.Message);
                }
            }
            return isFound;
        }
    }
}
