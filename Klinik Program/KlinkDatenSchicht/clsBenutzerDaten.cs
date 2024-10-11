using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsBenutzerDaten
    {
        public enum enMode { Addnew = 0, Update = 1}
        public enMode Mode { get; set; } = enMode.Addnew;

        public int BenutzerID { get; set; }
        public int? PersonID { get; set; }
        public clsPersonDaten PersonInfo { get; set; }
        public string Rollenname { get; set; }
        public string BenutzerPasswort { get; set; }
        public DateTime? ErstelltAm { get; set; }
        public DateTime? AktualisiertAm { get; set; }
        public DateTime? LetzterLogin { get; set; }
        public bool IstAktive { get; set; }


        private clsBenutzerDaten(int benutzerID, int personID, string rollenname, string benutzerPasswort, 
            DateTime? erstelltAm, DateTime? aktualisiertAm, DateTime? letzterLogin, bool istAktive)
        {
            
            this.BenutzerID = benutzerID;
            this.PersonID = personID;
            this.PersonInfo = clsPersonDaten.Find(personID);
            this.Rollenname = rollenname;
            this.BenutzerPasswort = benutzerPasswort;
            this.ErstelltAm = erstelltAm;
            this.AktualisiertAm = aktualisiertAm;
            this.LetzterLogin = letzterLogin;
            this.IstAktive = istAktive;

            Mode = enMode.Update;
        }

        public clsBenutzerDaten()
        {
            this.BenutzerID = -1;
            this.PersonID = -1;
            this.Rollenname =  string.Empty;
            this.BenutzerPasswort = string.Empty;
            this.ErstelltAm = null;
            this.AktualisiertAm = null;
            this.LetzterLogin = null;
            this.IstAktive = false;

            Mode = enMode.Addnew;
        }

        public static clsBenutzerDaten Find(int BenutzerID)
        {
            int  PersonID = -1 ; string rollenname = string.Empty; string benutzerPasswort = string.Empty; DateTime? erstelltAm = null;
            DateTime? aktualisiertAm = null; DateTime? letzterLogin = null; bool istAktive = false; ;

            if (clsBenutzerDatenZugriff.FindUserByID(BenutzerID, ref PersonID, ref rollenname, ref benutzerPasswort,
                ref erstelltAm, ref aktualisiertAm, ref letzterLogin, ref istAktive))
            {
                return new clsBenutzerDaten(BenutzerID, PersonID, rollenname, benutzerPasswort, erstelltAm,
                    aktualisiertAm, letzterLogin, istAktive);
            }
            else
                return null;
        }
        public static clsBenutzerDaten FindUserByPersonID(int PersonID)
        {
            int BenutzerID = -1; string rollenname = string.Empty; string benutzerPasswort = string.Empty; DateTime? erstelltAm = null;
            DateTime? aktualisiertAm = null; DateTime? letzterLogin = null; bool istAktive = false; ;

            if (clsBenutzerDatenZugriff.FindUserByPersonID(ref BenutzerID, PersonID, ref rollenname, ref benutzerPasswort,
                ref erstelltAm, ref aktualisiertAm, ref letzterLogin, ref istAktive))
            {
                return new clsBenutzerDaten(BenutzerID, PersonID, rollenname, benutzerPasswort, erstelltAm,
                    aktualisiertAm, letzterLogin, istAktive);
            }
            else
                return null;
        }
        public static clsBenutzerDaten FindUserByUserRolleAndPassword(string Rollenname, string Passwort)
        {
            int BenutzerID = -1;
            int PersonID = -1; DateTime? erstelltAm = null;
            DateTime? aktualisiertAm = null; DateTime? letzterLogin = null; bool istAktive = false; ;

            if (clsBenutzerDatenZugriff.FindUserByUserRolleAndUserPassword(ref BenutzerID, ref PersonID, Rollenname, Passwort,
                ref erstelltAm, ref aktualisiertAm, ref letzterLogin, ref istAktive))
            {
                return new clsBenutzerDaten(BenutzerID, PersonID, Rollenname, Passwort, erstelltAm,
                    aktualisiertAm, letzterLogin, istAktive);
            }
            else
                return null;
        }

        private bool _AddNew()
        {
            this.BenutzerID = clsBenutzerDatenZugriff.AddNeuUser(this.PersonID, this.Rollenname, this.BenutzerPasswort,
                this.ErstelltAm, this.AktualisiertAm, this.LetzterLogin, this.IstAktive);

            return (this.BenutzerID != -1);
        }


        private bool _Update()
        {
            return clsBenutzerDatenZugriff.UpdateUserByID(this.BenutzerID, this.PersonID, this.Rollenname, this.BenutzerPasswort,
                this.ErstelltAm, this.AktualisiertAm, this.LetzterLogin, this.IstAktive);
        }

        public bool UpdatePasswortByRollenname()
        {
            return clsBenutzerDatenZugriff.UpdatePasswortByRollenname(this.Rollenname, this.BenutzerPasswort);
        }

        public bool UpdateLetzterLogin()
        {
            return clsBenutzerDatenZugriff.UpdateLetzterLoginByRollenname(this.Rollenname);
        }

        public static bool DoesUserExistsForThisPerson(int PersonID)
        {
            return clsBenutzerDatenZugriff.DoesUserExistsForThisPerson(PersonID);
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Addnew:
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

        public static bool Delete(int benutzerid)
        {
            return clsBenutzerDatenZugriff.Delete(benutzerid);
        }

        public static bool DeactivateUser(int BenutzerID)
        {
            return clsBenutzerDatenZugriff.DeactivateUser(BenutzerID);
        }

        public static bool ActivateUser(int BenutzerID)
        {
            return clsBenutzerDatenZugriff.ActivateUser(BenutzerID);
        }
        public static DataTable GetAllUsers()
        {
            return clsBenutzerDatenZugriff.GetAllUsers();
        }

        public static bool DoesRollenNameExists(string rolleName)
        {
            return clsBenutzerDatenZugriff.DoesRollenNameExistsInDB(rolleName);
        }
    }
}
