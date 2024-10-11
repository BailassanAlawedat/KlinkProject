using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
   public class clsMitarbeiterDaten 
    {
        public enum enMode { addNew = 0, Update = 1}
        public enMode Mode = enMode.addNew;

        public int MitarbeiterID { get; set; }
        public int PersonID { get; set; }
        public clsPersonDaten personInfo => clsPersonDaten.Find(this.PersonID);

        public string Vollname => clsPersonDaten.Find(this.PersonID).Vollname;
        public int VersicherungsID { get; set; }
        public string SteuerID { get; set; }
        public string BerufsBezeichnung { get; set; }
        public string Abteilung { get; set; }
        public string Qualifikationen { get; set; }
        public DateTime EingestelltAm { get; set; }
        public string GefeuertAm { get; set; }
        public int EingestelltBeiUser { get; set; }
        public bool IstAtktive { get; set; }

        private clsMitarbeiterDaten(int mitarbeiterID, int personID, int versicherungsID, string steuerID,
            string berufsBezeichnung, string abteilung, string qualifikationen, DateTime eingestelltAm,
            string gefeuertAm, int eingestelltBeiUser, bool istaktive)
        {
            this.MitarbeiterID = mitarbeiterID;
            this.PersonID = personID;
            this.VersicherungsID = versicherungsID;
            this.SteuerID = steuerID;
            this.BerufsBezeichnung = berufsBezeichnung;
            this.Abteilung = abteilung;
            this.Qualifikationen = qualifikationen;
            this.EingestelltAm = eingestelltAm;
            this.GefeuertAm = gefeuertAm;
            this.EingestelltBeiUser = eingestelltBeiUser;
            this.IstAtktive = istaktive;

            Mode = enMode.Update;
        }

        public clsMitarbeiterDaten()
        {
            this.MitarbeiterID = -1;
            this.VersicherungsID = -1;
            this.SteuerID = string.Empty;
            this.BerufsBezeichnung = string.Empty;
            this.Abteilung = string.Empty;
            this.Qualifikationen = string.Empty;
            this.EingestelltAm = DateTime.Now;
            this.GefeuertAm = string.Empty;
            this.EingestelltBeiUser = -1;
            this.IstAtktive = true;

            Mode = enMode.addNew;
        }

        private bool _AddNew()
        {
            this.MitarbeiterID = clsMitarbeiterDatenZugriff.AddNewMitarbeiter(this.PersonID, this.VersicherungsID,
                this.SteuerID, this.BerufsBezeichnung, this.Abteilung, this.Qualifikationen, this.EingestelltAm,
                this.GefeuertAm, this.EingestelltBeiUser, this.IstAtktive);

            return (this.MitarbeiterID != -1);
        }

        private bool _Update()
        {
            return clsMitarbeiterDatenZugriff.UpdateMitarbeiter(this.MitarbeiterID, this.PersonID, this.VersicherungsID,
                this.SteuerID, this.BerufsBezeichnung, this.Abteilung, this.Qualifikationen, this.EingestelltAm,
                this.GefeuertAm, this.EingestelltBeiUser,this.IstAtktive);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.addNew:
                    if (_AddNew())
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

        public static clsMitarbeiterDaten Find(int MitarbeiterID)
        {
            int personID = -1; int versicherungsID = -1; string steuerID = string.Empty;
            string berufsbezeichnung = string.Empty; string abteilung = string.Empty;
            string qualifikationen = string.Empty; DateTime eingestelltAm = DateTime.Now;
            string gefeuertAm = string.Empty; int eingestelltBeiUser = -1;
            bool istaktive = false;

            if (clsMitarbeiterDatenZugriff.GetMitarbeiterbyID(MitarbeiterID, ref personID, ref versicherungsID,
                ref steuerID, ref berufsbezeichnung, ref abteilung, ref qualifikationen,
                ref eingestelltAm, ref gefeuertAm, ref eingestelltBeiUser, ref istaktive))
            {
                return new clsMitarbeiterDaten(MitarbeiterID, personID, versicherungsID, steuerID,
               berufsbezeichnung, abteilung, qualifikationen, eingestelltAm, 
               gefeuertAm, eingestelltBeiUser,istaktive);
            }
            else
                return null;
        }

        public static clsMitarbeiterDaten FindByPersonID(int PersonID)
        {
            int MitarbeiterID = -1; int versicherungsID = -1; string steuerID = string.Empty;
            string berufsbezeichnung = string.Empty; string abteilung = string.Empty;
            string qualifikationen = string.Empty; DateTime eingestelltAm = DateTime.Now;
            string gefeuertAm = string.Empty; int eingestelltBeiUser = -1;
            bool istaktive = false;

            if (clsMitarbeiterDatenZugriff.GetMitarbeiterbyPersonID(ref MitarbeiterID, PersonID, ref versicherungsID,
                ref steuerID, ref berufsbezeichnung, ref abteilung, ref qualifikationen,
                ref eingestelltAm, ref gefeuertAm, ref eingestelltBeiUser, ref istaktive))
            {
                return new clsMitarbeiterDaten(MitarbeiterID, PersonID, versicherungsID, steuerID,
               berufsbezeichnung, abteilung, qualifikationen, eingestelltAm,
               gefeuertAm, eingestelltBeiUser, istaktive);
            }
            else
                return null;
        }

        public bool Delete()
        {
            bool Done = clsMitarbeiterDatenZugriff.DeleteMitarbeiter(this.MitarbeiterID);

            if (!Done)
                return false;

            //wir löschen dann die generated Person vom System.
            return clsPersonDaten.Delete(this.PersonID);
        }

        public static bool Delete(int MitarbeiterID)
        {
            bool Done = clsMitarbeiterDatenZugriff.DeleteMitarbeiter(MitarbeiterID);

            return Done;
        }

        public static bool DoesMitarbeiterExistForThisPerson(int PersonID)
        {
            return clsMitarbeiterDatenZugriff.DoesMitarbeiterExistForThisPerson(PersonID);
        }
        public static bool IsMitarbeiterActiveForThisPerson(int PersonID)
        {
            return clsMitarbeiterDatenZugriff.isMitarbeiterActiveForThisPersonID(PersonID);
        }

        public static DataTable GetAllMitarbeiter()
        {
            return clsMitarbeiterDatenZugriff.GetAllMitarbeiter();
        }
    }
}
