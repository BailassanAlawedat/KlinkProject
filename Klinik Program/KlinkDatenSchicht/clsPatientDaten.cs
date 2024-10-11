using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsPatientDaten :clsPersonDaten
    {
        public enum enMode { Addnew = 0, Update = 1 }
        public enMode Mode = enMode.Addnew;

        public int PatientID { get; set; }
        public clsPersonDaten PersonDaten;

        private clsPatientDaten(int personID, string ausweisID, string vorname, string nachname,
                  DateTime geburtsTag,DateTime RegistrierungsDatum, byte geschlecht, int LandID, string stadt, string postleitzahl,
                 string straße, string hausNummer, string email, string telefonNummer, string fotoPfad,
                 int PatientID)
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
            //PaientDaten
            this.PatientID = PatientID;

            Mode = enMode.Update;
        }
        public clsPatientDaten()
        {
            this.PatientID = -1;

            Mode = enMode.Addnew;
        }

        private bool _AddNewPatient()
        {
            this.PatientID = clsPatientDatenZugriff.AddNeuPatient(this.PersonID);
            return (this.PatientID != 0);
        }

        private bool _UpdatePatient()
        {
            return clsPersonDatenZugriff.UpdatePerson(this.PersonID, this.AusweisID, this.Vorname,
                this.Nachname, this.GeburtsTag,this.RegistrierungsDatum, this.Geschlecht, this.LandID, this.Stadt, this.Postleitzahl,
                this.Straße, this.HausNummer, this.Email, this.TelefonNummer, this.FotoPfad);
        }

        public static clsPatientDaten Find(int PatientID)
        {
            int PersonID = -1;
            bool isFound;
            isFound = clsPatientDatenZugriff.GetPatientDatenByID(PatientID, ref PersonID);

            if (isFound)
            {
                //dann suchen wir nach der Generlisierende Person
                clsPersonDaten PersonInfo = clsPersonDaten.Find(PersonID);

                return new clsPatientDaten(PersonInfo.PersonID, PersonInfo.AusweisID, PersonInfo.Vorname,
                    PersonInfo.Nachname, PersonInfo.GeburtsTag, PersonInfo.RegistrierungsDatum,
                    PersonInfo.Geschlecht, PersonInfo.LandID,
                    PersonInfo.Stadt, PersonInfo.Postleitzahl, PersonInfo.Straße, PersonInfo.HausNummer,
                    PersonInfo.Email, PersonInfo.TelefonNummer, PersonInfo.FotoPfad, PatientID); ;
            }
            else
                return null;
          
        }

        public static clsPatientDaten FindPatientDataByTerminID(int TerminID)
        {
            int PersonID = -1; int PatientID = -1;
            bool isFound;
            isFound = clsPatientDatenZugriff.GetPatientDatenByTerminID(TerminID, ref PatientID, ref PersonID);

            if (isFound)
            {
                //dann suchen wir nach der Generlisierende Person
                clsPersonDaten PersonInfo = clsPersonDaten.Find(PersonID);

                return new clsPatientDaten(PersonInfo.PersonID, PersonInfo.AusweisID, PersonInfo.Vorname,
                    PersonInfo.Nachname, PersonInfo.GeburtsTag, PersonInfo.RegistrierungsDatum,
                    PersonInfo.Geschlecht, PersonInfo.LandID,
                    PersonInfo.Stadt, PersonInfo.Postleitzahl, PersonInfo.Straße, PersonInfo.HausNummer,
                    PersonInfo.Email, PersonInfo.TelefonNummer, PersonInfo.FotoPfad, PatientID); ;
            }
            else
                return null;

        }    
        public static clsPatientDaten FindByPersonID(int PersonID)
        {
            int PatientID = -1; 
            bool isFound;
            isFound = clsPatientDatenZugriff.GetPatientDatenByPersonID(ref PatientID, PersonID);

            if (isFound)
            {
                //zuerst suchen wir nach der Generlisierende Person
                clsPersonDaten PersonInfo = clsPersonDaten.Find(PersonID);

                return new clsPatientDaten(PersonInfo.PersonID, PersonInfo.AusweisID, PersonInfo.Vorname,
                    PersonInfo.Nachname, PersonInfo.GeburtsTag,PersonInfo.RegistrierungsDatum,
                    PersonInfo.Geschlecht, PersonInfo.LandID,
                    PersonInfo.Stadt, PersonInfo.Postleitzahl, PersonInfo.Straße, PersonInfo.HausNummer,
                    PersonInfo.Email, PersonInfo.TelefonNummer, PersonInfo.FotoPfad, PatientID);
            }
            else
                return null;
        }

        public bool Delete()
        {
            bool SindPatientDatenGelöscht = false;
            bool SindPersonDatenGelöscht = false;
            //zuerst löschen wir patient daten 
            SindPatientDatenGelöscht = clsPatientDatenZugriff.DeletePatient(this.PatientID);

            if (!SindPatientDatenGelöscht)
                return false;
            //und dann löschen wir person daten
            SindPersonDatenGelöscht = base.Delete();

            return SindPersonDatenGelöscht;
;        }
        
        public bool Save()
        {

            //wegen vererbung rufen wir zuerst die Save Methode in der BasisKlasse auf.
            //es kümmert sich um Hinzufügen alle Informationen in Personen Tabelle.

            //base.Mode =(clsPersonDaten.enMode)Mode;
            //if (!base.Save())
            //    return false;

            //und erst jetzt speichern wir die Informationen in Patients Tabelle.
            switch(Mode)
            {
                case enMode.Addnew:
                    if (_AddNewPatient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePatient();
            }
            return false;
        }

        public static DataTable GetAllPatients()
        {
            return clsPatientDatenZugriff.GetAllPatients();
        }

        public static bool IsPatientExistForPersonID(int personID)
        {
            return clsPatientDatenZugriff.IsPatientExistForPersonID(personID);
        }
    }
}
