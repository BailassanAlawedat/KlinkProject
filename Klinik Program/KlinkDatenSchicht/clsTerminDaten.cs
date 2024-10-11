using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace KlinkDatenSchicht
{
    public class  clsTerminDaten : clsDatumDaten
    {
        private static readonly string DBconnectionString = clsTerminDatenZugriff.GetDBConnectionString();
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;
        public int TerminID { get; set; }
        public int ArztID { get; set; }
        public int PatientID { get; set; }
        public string ArztVollname
        {
            get { return clsArztDaten.Find(ArztID).Vollname; }
        }
        public string PatientVollname
        { 
            get { return clsPatientDaten.Find(PatientID).Vollname; }
        }
        public int VersicherungsID { get; set; }
        public bool TerminStatus { get; set; }

        private clsTerminDaten(int datumID, DateTime datum, string zeit, string status, int TerminID,
           int ArztID, int PatientID, int VersicherungsID,bool TerminStatus)
        {
            this.datumID = datumID;
            this.datum = datum;
            this.zeit = zeit;
            this.status = status;
            this.TerminID = TerminID;
            this.ArztID = ArztID;
            this.PatientID = PatientID;
            this.VersicherungsID = VersicherungsID;
            this.TerminStatus = TerminStatus;

            Mode = enMode.Update;
        }

        public clsTerminDaten()
        {
            this.TerminID = -1;
            this.ArztID = -1;
            this.PatientID = -1;
            this.VersicherungsID = -1;
            this.TerminStatus = false;

            Mode = enMode.AddNew;
        }

        public static List<clsTerminDaten> GetTermiListByPatientID(int patientID)
        {
            List<clsTerminDaten> terminDatens = new List<clsTerminDaten>();

            using (SqlConnection connection = new SqlConnection(DBconnectionString))
            using (SqlCommand command = new SqlCommand("Sp_GetTerminListeByPatientID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientID", patientID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsTerminDaten Termin = new clsTerminDaten
                            {
                                TerminID = (int)reader["TerminID"],
                                datumID = (int)reader["DatumID"],
                                datum  = (DateTime)reader["Datum"],
                                 zeit = (string)reader["Zeiten"],
                                TerminStatus = (bool)reader["TerminStatus"]
                            };
                            terminDatens.Add(Termin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler beim Abrufen der Termindaten: " + ex.Message);
                }
            }
            return terminDatens;
        }

        private bool _AddnewAppoitment()
        {       

            this.TerminID = clsTerminDatenZugriff.AddNewAppoitment(this.datumID, this.ArztID,
                  this.PatientID, this.VersicherungsID, this.TerminStatus);

            return (this.TerminID != -1);
        }

        private bool _UpdateAppoitment()
        {
            return clsTerminDatenZugriff.UpdateAppoitment(this.TerminID, this.datumID,
                 this.ArztID, this.PatientID,
                 this.VersicherungsID, this.TerminStatus);
        }

        public static clsTerminDaten Find(int TerminID)
        {
            int datumID = -1;  int ArztID = -1; int PatientID = -1; 
            int VersicherungsID = -1;  bool TerminStatus = false;

            if (clsTerminDatenZugriff.GetAppoitmentByID(TerminID,ref datumID, ref ArztID, ref PatientID, 
                ref VersicherungsID, ref TerminStatus))
            {
                //dann suchen wir nach den deten der geerbrten Klasse datum
                clsDatumDaten datumDaten = clsDatumDaten.Find(datumID);

                return new clsTerminDaten(datumID, datumDaten.datum, datumDaten.zeit, datumDaten.status,
                    TerminID, ArztID, PatientID, VersicherungsID, TerminStatus);
            }
            else
                return null;

        }

        public static clsTerminDaten FindByPatientID(int PatientID)
        {
            int datumID = -1;  int ArztID = -1; int TerminID = -1; 
            int VersicherungsID = -1; bool TerminStatus = false;

            if (clsTerminDatenZugriff.GetAppoitmentByPatientID(ref TerminID,ref datumID, ref ArztID,  PatientID,
                ref VersicherungsID, ref TerminStatus))
            {
                //dann suchen wir nach den deten der geerbrten Klasse datum
                clsDatumDaten datumDaten = clsDatumDaten.Find(datumID);

                return new clsTerminDaten(datumID, datumDaten.datum, datumDaten.zeit, datumDaten.status,
                    TerminID, ArztID, PatientID, VersicherungsID, TerminStatus);
            }
            else
                return null;
        }
   
        public override bool Delete()
        {
            // zuerst löschen wir die TerminDaten .
            bool WurdenTerminDatenGelöscht = clsTerminDatenZugriff.DeleteTermin(this.TerminID);

            if (!WurdenTerminDatenGelöscht)
                return false;

            //if Termindaten gelöscht wurden.
            bool WurdenDatumDatenGelöscht = base.Delete();
            return WurdenDatumDatenGelöscht;
        }

        public static DataTable GetAllAppoitments()
        {
            return clsTerminDatenZugriff.GetAllAppoitments();
        }

        public static bool IsAppoitmentFree(DateTime TerminDatumToCheck,
            TimeSpan StartZeitToCheck, TimeSpan EndZeitToCheck)
        {
            return clsTerminDatenZugriff.isThisAppointmentOverlaop(TerminDatumToCheck,
                StartZeitToCheck, EndZeitToCheck);
        }

        public static bool IsDoctorFreeForThisAppointment(int arztID, DateTime TerminDatumToCheck,
             string StartZeitToCheck)
        {
            return clsTerminDatenZugriff.IsDoctorFreeForThisAppointment(arztID,TerminDatumToCheck,
              StartZeitToCheck);
        }

        public static bool DoesHavePatientAppointmentOnThisTime(int patientID, DateTime TerminDatumToCheck)
        {
            return clsTerminDatenZugriff.DoesHavePatientAppointmentOnthisTime(patientID, TerminDatumToCheck);
        }

        public static bool DoesHavePatientAppointment(int PatientID)
        {
            return clsTerminDatenZugriff.DoesHavePatientAnAppointment(PatientID);
        }
        public override bool Save()
        {
           //Wir stellen sicher, dass die Datumdaten erset gespeichert wurden.
           base.Mode = (clsDatumDaten.enmode) Mode;
            if (!base.Save())
                return false;

            switch(Mode)
            { 
                case enMode.AddNew:
                    if (_AddnewAppoitment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateAppoitment();
            }
            return false;
        }

        public static bool IsAppointmentDone(int TerminID)
        {
            return clsTerminDatenZugriff.IsAppointmentDone(TerminID);
        }
    }
}
