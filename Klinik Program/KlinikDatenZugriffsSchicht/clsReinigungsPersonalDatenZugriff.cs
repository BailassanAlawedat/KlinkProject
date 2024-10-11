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
    public class clsReinigungsPersonalDatenZugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool GetMitarbeiterbyPersonalID(int PersonalID , ref int mitarbeiterID, ref string Bereichname)
        {

            bool isfound = false;
            string abfrage = @"Select * From ReinigungsPersonal Where PersonalID = @PersonalID";
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
                                Bereichname = (string)reader["BereichName"];
                                

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

        public static bool GetReinigungsPersonalByMitarbeiterID(ref int PersonalID, int mitarbeiterID, ref string Bereichname)
        {

            bool isfound = false;
            string abfrage = @"Select * From ReinigungsPersonal Where MitarbeiterID = @MitarbeiterID";
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
                                Bereichname = (string)reader["BereichName"];
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

        public static DataTable GetAllRenigungsPersonal()
        {
            DataTable dt = new DataTable();
            string abfrage = @"Select * From GetReinigungsPersonalMitarbeiter()
                                     Order By PersonalID";
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
  
        public static int AddNewReinigungsPersonal(int MitarbeiterID)
        {
            int PersonalID = -1;
            string abfarge = @"Insert into ReinigungsPersonal (MitarbeiterID)
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
            string abfrage = @"Delete From ReinigungsPersonal 
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

        public static DataTable GetAllReinigungsMitarbeiter()
        {
            DataTable dt = new DataTable();

            string abfrage = @"Select From Mitarbeiter M INNER JOIN ReinigungsPersonal R ON
                                       M.MitarbeiterID = R.MitarbeiterID
                                       Order by MitarbeiterID Desc";
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch(SqlException)
            {
                throw;
            }
            return dt;
        }
    }
}
