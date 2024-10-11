 using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsPersonDaten
    {
        public enum enMode { Addnew = 0, Update}
        public enMode Mode = enMode.Addnew;

        public int PersonID { get; set; }
        public string AusweisID { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Vollname
        {
            get { return Vorname + " " + Nachname; }
        }
        public DateTime GeburtsTag { get; set; }
        public DateTime RegistrierungsDatum { get; set; }
        public byte Geschlecht { get; set; }
        public int LandID { get; set; }
        public clsLänderDaten LandsDaten;
        public string Stadt { get; set; }
        public string Postleitzahl { get; set; }
        public string Straße { get; set; }
        public string HausNummer { get; set; }
        public string Email { get; set; }
        public string TelefonNummer { get; set; }
        public string FotoPfad { get; set; }

        private clsPersonDaten(int personID, string ausweisID, string vorname, string nachname,
                  DateTime geburtsTag,DateTime RegistrierungsDatum, byte geschlecht,int LandID, string stadt, string postleitzahl,
                 string straße, string hausNummer, string email, string telefonNummer, string fotoPfad)
        {
            this.PersonID = personID;
            this.AusweisID = ausweisID;
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.GeburtsTag = geburtsTag;
            this.RegistrierungsDatum = RegistrierungsDatum;
            this.Geschlecht = geschlecht;
            this.LandID = LandID;
            this.LandsDaten = clsLänderDaten.Find(this.LandID);
            this.Stadt = stadt;
            this.Postleitzahl = postleitzahl;
            this.Straße = straße;
            this.HausNummer = hausNummer;
            this.Email = email;
            this.TelefonNummer = telefonNummer;
            this.FotoPfad = fotoPfad;

            Mode = enMode.Update;
        }

        public clsPersonDaten()
        {
            this.PersonID = -1;
            this.AusweisID = "";
            this.Vorname = "";
            this.Nachname = "";
            this.GeburtsTag = DateTime.Now;
            this.RegistrierungsDatum = DateTime.Now;
            this.LandID = -1;
            this.Stadt = "";
            this.Postleitzahl = "";
            this.Straße = "";
            this.HausNummer = "";
            this.Email = "";
            this.TelefonNummer = "";
            this.FotoPfad = "";

            Mode = enMode.Addnew;
        }

        public static clsPersonDaten Find(int PersonID)
        {
            string AusweisID = "";  string Vorname = ""; string Nachname = ""; DateTime GeburtsTag = DateTime.Now;
            DateTime RegistrierungsDatum = DateTime.Now;
            byte Geschlecht = 0; int LandID = -1; string Stadt = ""; string Postleitzahl = ""; 
            string Straße = ""; string HausNummer = "";
            string Email = ""; string TelefonNummer = ""; string FotoPfad = "";

            if (clsPersonDatenZugriff.GetPersonDataByPersonID(PersonID, ref AusweisID, ref Vorname, ref Nachname,
                ref GeburtsTag, ref RegistrierungsDatum, ref Geschlecht, ref LandID, ref Stadt, ref Postleitzahl, ref Straße, ref HausNummer, ref Email,
                                    ref TelefonNummer, ref FotoPfad))
            {
                return new clsPersonDaten(PersonID, AusweisID, Vorname, Nachname, GeburtsTag,RegistrierungsDatum, Geschlecht,
                   LandID, Stadt, Postleitzahl, Straße, HausNummer, Email, TelefonNummer, FotoPfad);
            }
            else
                return null;
        }

        public static clsPersonDaten Find(string AusweisID)
        {
            int PersonID = -1; string Vorname = ""; string Nachname = ""; DateTime GeburtsTag = DateTime.Now;
            DateTime RegistrierungsDatum = DateTime.Now;
            byte Geschlecht = 0; int LandID = -1; string Stadt = ""; string Postleitzahl = ""; 
            string Straße = ""; string HausNummer = "";
            string Email = ""; string TelefonNummer = ""; string FotoPfad = "";

            bool PersonFound = clsPersonDatenZugriff.GetPersonDataByNationalID(ref PersonID, AusweisID, ref Vorname,
              ref Nachname, ref GeburtsTag, ref RegistrierungsDatum, ref Geschlecht, ref LandID, ref Stadt, ref Postleitzahl, ref Straße,
              ref HausNummer, ref Email, ref TelefonNummer, ref FotoPfad);

            if(PersonFound)
            {
                return new clsPersonDaten(PersonID, AusweisID, Vorname, Nachname, GeburtsTag, RegistrierungsDatum, Geschlecht,
                   LandID, Stadt, Postleitzahl, Straße, HausNummer, Email, TelefonNummer, FotoPfad);
            }
            else
                return null;
        }

        public static clsPersonDaten FindByEmailAddresse(string Email)
        {
            int PersonID = -1; string AusweisID = "";  string Vorname = ""; string Nachname = ""; DateTime GeburtsTag = DateTime.Now;
            DateTime RegistrierungsDatum = DateTime.Now;
            byte Geschlecht = 0; int LandID = -1; string Stadt = ""; string Postleitzahl = "";
            string Straße = ""; string HausNummer = "";
            string TelefonNummer = ""; string FotoPfad = "";

            if (clsPersonDatenZugriff.GetPersonDataByEmailAdresse(ref PersonID, ref AusweisID, ref Vorname,
              ref Nachname, ref GeburtsTag, ref RegistrierungsDatum, ref Geschlecht, ref LandID, ref Stadt, ref Postleitzahl, ref Straße,
              ref HausNummer, Email, ref TelefonNummer, ref FotoPfad))
            {
                return new clsPersonDaten(PersonID, AusweisID, Vorname, Nachname, GeburtsTag, RegistrierungsDatum, Geschlecht,
                   LandID, Stadt, Postleitzahl, Straße, HausNummer, Email, TelefonNummer, FotoPfad);
            }
            else
                return null;
        }

        public static clsPersonDaten FindByPersonName(string PersonName)
        {
            int PersonID = -1; string AusweisID = ""; string Vorname = ""; string Nachname = ""; DateTime GeburtsTag = DateTime.Now;
            DateTime RegistrierungsDatum = DateTime.Now;
            byte Geschlecht = 0; int LandID = -1; string Stadt = ""; string Postleitzahl = "";
            string Straße = ""; string HausNummer = ""; string Email = "";
            string TelefonNummer = ""; string FotoPfad = "";

            if (clsPersonDatenZugriff.GetPersonDataByPersonName(PersonName, ref PersonID, ref AusweisID, ref Vorname,
              ref Nachname, ref GeburtsTag, ref RegistrierungsDatum, ref Geschlecht, ref LandID, ref Stadt, ref Postleitzahl, ref Straße,
              ref HausNummer,ref Email, ref TelefonNummer, ref FotoPfad))
            {
                return new clsPersonDaten(PersonID, AusweisID, Vorname, Nachname, GeburtsTag, RegistrierungsDatum, Geschlecht,
                   LandID, Stadt, Postleitzahl, Straße, HausNummer, Email, TelefonNummer, FotoPfad);
            }
            else
                return null;
        }
        public static int GetPatientIDByPersonName(string PersonName)
        {
            return clsPersonDatenZugriff.GetPatientDataByPersonNamen(PersonName);
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDatenZugriff.AddNewPerson(this.AusweisID, this.Vorname, this.Nachname,
                this.GeburtsTag,this.RegistrierungsDatum, this.Geschlecht,this.LandID, this.Stadt, this.Postleitzahl, this.Straße, this.HausNummer,
                this.Email, this.TelefonNummer, this.FotoPfad);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonDatenZugriff.UpdatePerson(this.PersonID, this.AusweisID, this.Vorname, this.Nachname,
                this.GeburtsTag,this.RegistrierungsDatum, this.Geschlecht, this.LandID,this.Stadt, this.Postleitzahl, this.Straße, this.HausNummer,
                this.Email, this.TelefonNummer, this.FotoPfad);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Addnew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonDatenZugriff.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string AusweisID)
        {
            return clsPersonDatenZugriff.IsPersonExist(AusweisID);
        }

        public bool IsPersonExistForPersonID()
        {
            return clsPersonDatenZugriff.IsPersonExist(this.PersonID);
        }

        public static bool Delete(int PersonID)
        {
            return clsPersonDatenZugriff.DeletePerson(PersonID);
        }

        public bool Delete()
        {
            return clsPersonDatenZugriff.DeletePerson(this.PersonID);
        }

        public bool DeleteBy(int PersonID)
        {
            return clsPersonDatenZugriff.DeletePerson(PersonID);
        }
        public static DataTable GetAllPersons()
        {
            return clsPersonDatenZugriff.GetAllPersons();
        }

        public static DataTable GetPersonenProSeite(int PersonenProSeite, int SeiteNummer)
        {
            return clsPersonDatenZugriff.GetPersonenRecordsProSeite(PersonenProSeite, SeiteNummer);
        }

        public static bool IsPersonExistByEmailAdresse(string email)
        {
            return clsPersonDatenZugriff.IsPersonExistByEmailAdresse(email);
        }
    }
}

