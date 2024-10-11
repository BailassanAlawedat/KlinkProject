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
    public class clsArztDaten :clsPersonDaten
    {
        public enum enMode { Addnew = 0, Update = 1 }
        public enMode Mode = enMode.Addnew;

        public int FachrichtungsID { get; set; }
        public int ArztID { get; set; }

        public clsPersonDaten PersonDaten;
        public clsFachrichtungenDaten FachrichtungsInfo;
        private clsArztDaten(int personID, string ausweisID, string vorname, string nachname,
                  DateTime geburtsTag, DateTime RegistrierungsDatum, byte geschlecht, int LandID, string stadt, string postleitzahl,
                 string straße, string hausNummer, string email, string telefonNummer, string fotoPfad,
                 int ArztID, int FachrichtungsID)
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
            //
            //ArztDaten
            this.ArztID = ArztID;
            this.FachrichtungsID = FachrichtungsID;
            this.FachrichtungsInfo = clsFachrichtungenDaten.Find(this.FachrichtungsID);

            Mode = enMode.Update;
        }
        public clsArztDaten()
        {
            this.ArztID = -1;
            Mode = enMode.Addnew;
        }

        private bool _AddNewDoctor()
        {
            this.ArztID = clsÄrzteDatenZugriff.AddNeuDoctor(this.PersonID, this.FachrichtungsID);
            return (this.ArztID != 0);
        }

        private bool _UpdateDoctor()
        {
            if (clsÄrzteDatenZugriff.UpdateDoctorByDoctorID(this.ArztID, this.FachrichtungsID))
            {
                return clsPersonDatenZugriff.UpdatePerson(this.PersonID, this.AusweisID, this.Vorname,
                this.Nachname, this.GeburtsTag, this.RegistrierungsDatum, this.Geschlecht, this.LandID, this.Stadt, this.Postleitzahl,
                this.Straße, this.HausNummer, this.Email, this.TelefonNummer, this.FotoPfad);
            }
            else
                return false;
        }


        public static clsArztDaten Find(int ArztID)
        {
            int PersonID = -1; int FachrichtungsID = -1;
            bool isFound;
            isFound = clsÄrzteDatenZugriff.GetDoctorDatenByID(ArztID, ref PersonID, ref FachrichtungsID);

            if (isFound)
            {
                //zuerst suchen wir nach der Generlisierende Person
                clsPersonDaten PersonInfo = clsPersonDaten.Find(PersonID);

                return new clsArztDaten(PersonInfo.PersonID, PersonInfo.AusweisID, PersonInfo.Vollname,
                    PersonInfo.Nachname, PersonInfo.GeburtsTag, PersonInfo.RegistrierungsDatum,
                    PersonInfo.Geschlecht, PersonInfo.LandID,
                    PersonInfo.Stadt, PersonInfo.Postleitzahl, PersonInfo.Straße, PersonInfo.HausNummer,
                    PersonInfo.Email, PersonInfo.TelefonNummer, PersonInfo.FotoPfad, ArztID, FachrichtungsID);
            }
            else
                return null;

        }
        public static clsArztDaten FindByPersonID(int PersonID)
        {
            int ArztID = -1;
            int FachrichtungsID = -1;
            bool isFound;
            isFound = clsÄrzteDatenZugriff.GetDoctorDatenByPersonID(ref ArztID, PersonID, ref FachrichtungsID);

            if (isFound)
            {
                //zuerst suchen wir nach der Generlisierende Person
                clsPersonDaten PersonInfo = clsPersonDaten.Find(PersonID);

                return new clsArztDaten(PersonInfo.PersonID, PersonInfo.AusweisID, PersonInfo.Vollname,
                    PersonInfo.Nachname, PersonInfo.GeburtsTag, PersonInfo.RegistrierungsDatum,
                    PersonInfo.Geschlecht, PersonInfo.LandID,
                    PersonInfo.Stadt, PersonInfo.Postleitzahl, PersonInfo.Straße, PersonInfo.HausNummer,
                    PersonInfo.Email, PersonInfo.TelefonNummer, PersonInfo.FotoPfad, ArztID, FachrichtungsID);
            }
            else
                return null;
        }

        public static clsArztDaten FindByPersonName(string Personname)
        {
            int PersonID = -1;
            int ArztID = -1;
            int FachrichtungsID = -1;
            bool isFound;
            isFound = clsÄrzteDatenZugriff.GetDoctorDataByPersonName(Personname,ref ArztID, ref PersonID, ref FachrichtungsID);

            if (isFound)
            {
                //zuerst suchen wir nach der Generlisierende Person
                clsPersonDaten PersonInfo = clsPersonDaten.FindByPersonName(Personname);

                return new clsArztDaten(PersonInfo.PersonID, PersonInfo.AusweisID, PersonInfo.Vollname,
                    PersonInfo.Nachname, PersonInfo.GeburtsTag, PersonInfo.RegistrierungsDatum,
                    PersonInfo.Geschlecht, PersonInfo.LandID,
                    PersonInfo.Stadt, PersonInfo.Postleitzahl, PersonInfo.Straße, PersonInfo.HausNummer,
                    PersonInfo.Email, PersonInfo.TelefonNummer, PersonInfo.FotoPfad, ArztID, FachrichtungsID);
            }
            else
                return null;
        }

        public bool Delete()
        {
            bool SindArztDatenGelöscht = false;
            bool SindPersonDatenGelöscht = false;
            //zuerst löschen wir patient daten 
            SindArztDatenGelöscht = clsÄrzteDatenZugriff.DeleteDoctor(this.ArztID);

            if (!SindArztDatenGelöscht)
                return false;
            //und dann löschen wir person daten
            SindPersonDatenGelöscht = base.Delete();

            return SindPersonDatenGelöscht;
            ;
        }

        public bool Save()
        {

            //wegen vererbung rufen wir zuerst die Save Methode in der BasisKlasse auf.
            //es kümmert sich um Hinzufügen alle Informationen in Personen Tabelle.

            //base.Mode =(clsPersonDaten.enMode)Mode;
            //if (!base.Save())
            //    return false;

            //und erst jetzt speichern wir die Informationen in Patients Tabelle.
            switch (Mode)
            {
                case enMode.Addnew:
                    if (_AddNewDoctor())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateDoctor();
            }
            return false;
        }

        public static DataTable GetAllDoctors()
        {
            return clsÄrzteDatenZugriff.GetAllDoctors();
        }

        public static bool IsDoctorExistForPersonID(int personID)
        {
            return clsÄrzteDatenZugriff.IsDoctorExistForPersonID(personID);
        }
    }
}
