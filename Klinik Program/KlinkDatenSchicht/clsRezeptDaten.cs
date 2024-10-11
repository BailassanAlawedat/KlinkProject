using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsRezeptDaten
    {
        public enum enMode { Addnew = 0, Update = 1 }
        public enMode Mode = enMode.Addnew;

        public int RezeptID { get; set; }
        public int VersicherungID { get; set; }
        public string RezeptName { get; set; }
        public string Dosierung { get; set; }
        public string Häufigkeit { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EndDatum { get; set; }
        public string SpezielleAnweisungen { get; set; }
        public int TerminID { get; set; }
        public clsTerminDaten TerminInfo;
        private clsRezeptDaten(int rezeptID, int versicherungID, string rezeptName, string dosierung,
            string häufigkeit, DateTime startDatum, DateTime endDatum, string spezielleAnweisungen, int TerminID)
        {
            this.RezeptID=rezeptID;
            this.VersicherungID=versicherungID;
            this.RezeptName=rezeptName;
            this.Dosierung=dosierung;
            this.Häufigkeit=häufigkeit;
            this.StartDatum=startDatum;
            this.EndDatum=endDatum;
            this.SpezielleAnweisungen=spezielleAnweisungen;
            this.TerminID = TerminID;
            this.TerminInfo = clsTerminDaten.Find(this.TerminID);

            Mode = enMode.Update;
        }

        public clsRezeptDaten()
        {
            this.RezeptID = -1;
            this.VersicherungID = -1;
            this.RezeptName = string.Empty;
            this.Dosierung = string.Empty;
            this.Häufigkeit = string.Empty;
            this.StartDatum = DateTime.Now;
            this.EndDatum = DateTime.Now;
            this.SpezielleAnweisungen = string.Empty;
            this.TerminID = -1;

            Mode = enMode.Addnew;
        }

        private bool _Addnew()
        {
            this.RezeptID = clsRezepteDatenZugriff.AddNewRezept(this.VersicherungID, this.RezeptName,
                this.Dosierung, this.Häufigkeit, this.StartDatum, this.EndDatum,
                this.SpezielleAnweisungen, this.TerminID);

            return (this.RezeptID != -1);
        }


        private bool _Update()
        {
               return clsRezepteDatenZugriff.UpdateRezept(this.RezeptID,this.VersicherungID, this.RezeptName,
                this.Dosierung, this.Häufigkeit, this.StartDatum, this.EndDatum,
                this.SpezielleAnweisungen, this.TerminID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Addnew:
                    if (_Addnew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static clsRezeptDaten Find(int RezeptID)
        {
            int VersicherungID = -1; string RezeptName = string.Empty; string Dosierung = string.Empty;
            string Häufigkeit = string.Empty; DateTime Startdatum = DateTime.Now;
            DateTime Enddatum = DateTime.Now;
            string SpezielleAnweisungen = string.Empty; int TerminID = -1;

            bool isFound = clsRezepteDatenZugriff.FindRezeptByID(RezeptID, ref VersicherungID, ref RezeptName,
                ref Dosierung, ref Häufigkeit, ref Startdatum, ref Enddatum,
                ref SpezielleAnweisungen, ref TerminID);

            if (isFound)
                return new clsRezeptDaten(RezeptID, VersicherungID, RezeptName, Dosierung, Häufigkeit,
                    Startdatum, Enddatum, SpezielleAnweisungen, TerminID);
            else
                return null;
        }


        public static clsRezeptDaten FindRezeptByTerminID(int TerminID)
        {
            int VersicherungID = -1; string RezeptName = string.Empty; string Dosierung = string.Empty;
            string Häufigkeit = string.Empty; DateTime Startdatum = DateTime.Now;
            DateTime Enddatum = DateTime.Now;
            string SpezielleAnweisungen = string.Empty; int RezeptID = -1;

            bool isFound = clsRezepteDatenZugriff.FindRezeptByTerminID(ref RezeptID, ref VersicherungID, ref RezeptName,
                ref Dosierung, ref Häufigkeit, ref Startdatum, ref Enddatum,
                ref SpezielleAnweisungen, TerminID);

            if (isFound)
                return new clsRezeptDaten(RezeptID, VersicherungID, RezeptName, Dosierung, Häufigkeit,
                    Startdatum, Enddatum, SpezielleAnweisungen, TerminID);
            else
                return null;
        }

        public bool Delete()
        {
            return clsRezepteDatenZugriff.Delete(this.RezeptID);
        }

        public static bool DoesHaveAppointmentRezept(int TerminID)
        {
            if (clsRezepteDatenZugriff.DoesHavAppoitentRezept(TerminID))
                return true;
            else
                return false;
        }
        public static DataTable GetAllRezepte()
        {
            return clsRezepteDatenZugriff.GetAllRezepte();
        }
    }
}
