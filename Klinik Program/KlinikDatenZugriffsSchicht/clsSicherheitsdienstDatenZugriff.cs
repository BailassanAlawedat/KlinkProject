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
    public class clsSicherheitsdienstDatenZugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool GetMitarbeiterbyPersonalID(int PersonalID, ref int mitarbeiterID, ref string bereichname)
        {

            bool isfound = false;
            string abfrage = @"Select * From Sicherheitsdienst Where PersonalID = @PersonalID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@PersonalID", PersonalID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                mitarbeiterID = (int)reader["MitarbeiterID"];
                                bereichname = (string)reader["BereichName"];


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

        public static bool GetSicherheitsdienstebyMitarbeiterID(ref int PersonalID, int mitarbeiterID, ref string bereichname)
        {

            bool isfound = false;
            string abfrage = @"Select * From Sicherheitsdienst Where MitarbeiterID = @MitarbeiterID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@MitarbeiterID", mitarbeiterID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                PersonalID = (int)reader["PersonalID"];
                                bereichname = (string)reader["BereichName"];
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

        public static DataTable GetAllPersonal()
        {
            DataTable dt = new DataTable();
            string abfrage = @"Select * From Mitarbeiter M Inner Join Sicherheitsdienst S
                                        ON M.MitarbeiterID = S.MitarbeiterID
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

        public static int AddNewPersonal(int MitarbeiterID)
        {
            int PersonalID = -1;
            string abfarge = @"Insert into Sicherheitsdienst (MitarbeiterID)
                                                          Values (@MitarbeiterID);
                                Select Scope_Identity() ";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfarge, connection))
                    {

                        command.Parameters.AddWithValue("@MitarbeiterID", MitarbeiterID);

                        connection.Open();
                        PersonalID = Convert.ToInt32(command.ExecuteScalar());

                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return PersonalID;
        }
        public static bool Delete(int PersonalID)
        {
            int RowAffected = 0;
            string abfrage = @"Delete From Sicherheitsdienst 
                                             Where PersonalID = @PersonalID";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@PersonalID", PersonalID);

                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }
        
        public static DataTable GetAllSicherheitsdienstMitarbeiter()
        {
            DataTable dt = new DataTable();
            string abfrage = @"Select * From GetAllSicherheitsdienstMitarbeiter()
                                          Order by MitarbeiterID";
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

    }
}
