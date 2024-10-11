using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsDatumDaten
    {
        public enum enmode { addnew = 0, update = 1}
        public enmode Mode = enmode.addnew;
        public int datumID { get; set; }
        public DateTime datum { get; set; }
        public string zeit { get; set; }
        public string status { get; set; }

        private clsDatumDaten(int datumID,DateTime datum, string zeit, string status)
        {
            this.datumID=datumID;
            this.datum=datum;
            this.zeit=zeit;
            this.status=status;
            Mode = enmode.update;
        }
        public clsDatumDaten()
        {
            this.datumID =-1;
            this.datum=datum = DateTime.Now;
            this.zeit= string.Empty;
            this.status= string.Empty;
            Mode = enmode.addnew;
        }

        private  bool _Addnew()
        {
            this.datumID = clsDatumDatenZugriff.AddNew(this.datum,
                this.zeit, this.status);
            return this.datumID != -1;
        }
        private bool _Update()
        {
            return clsDatumDatenZugriff.Update(this.datumID, this.datum,
                this.zeit, this.status);
        }

        public virtual bool Save()
        {
           switch(Mode)
            {
                case enmode.addnew:
                    if (_Addnew())
                    {
                        Mode = enmode.update;
                        return true;
                    }
                    else
                        return false;

                case enmode.update:
                    return _Update()
;            }
            return false;
        }

        public static clsDatumDaten Find(int datumID)
        {
             DateTime datum = DateTime.Now;  string zeit = string.Empty;
            string status = string.Empty;

            if (clsDatumDatenZugriff.GetDatumByDatumID(datumID, ref datum, ref zeit, ref status))
            {
                return new clsDatumDaten(datumID, datum, zeit, status);
            }
            else
                return null;
        }
        
        //public static clsDatumDaten FindByPatientId(int patientID)
        //{
        //    int datumID = -1; DateTime datum = DateTime.Now; string zeit = string.Empty;
        //    string status = string.Empty ; int terminID = -1;

        //    if (clsDatumDatenZugriff.GetDatumByPatientID(patientID, ref datumID,
        //        ref datum, ref zeit, ref status))
        //    {
        //        return new clsDatumDaten(datumID, terminID, datum, zeit, status);
        //    }
        //    else
        //        return null;
        //}

        public virtual bool  Delete()
        {
            return clsDatumDatenZugriff.Delete(this.datumID);
        }

        public static bool IsDoctorFreeOnThisTime(int arztID, DateTime datumToCheck, string zeitToCheck)
        {
            return clsDatumDatenZugriff.IsDoctorFreeOnThisTime(arztID, datumToCheck,zeitToCheck);
        }
        
        public static bool DoesHavPatientAnAppointmentOnThisDate(int patientID, DateTime datumToCheck)
        {
            return clsDatumDatenZugriff.DoesHavePatientAnAppointmentOnThisDate(patientID, datumToCheck);
        }

        public static DataTable GetAllDatumDaten()
        {
            return clsDatumDatenZugriff.GetAllDatumDaten();
        }

        public static DataTable GetArztDatumDaten(int ArztID)
        {
            return clsDatumDatenZugriff.GetArztDatumDaten(ArztID);
        }
    }
}
