using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsTransportdienstDaten :clsPersonal
    {
        public enum enMode { Addnew = 0, Update = 1 }
        public enMode Mode = enMode.Addnew;

        public override int PersonalID { get; set; }
        public override int MitabeiterID { get; set; }
        public override string Bereichname { get; set; }
        public clsMitarbeiterDaten mitarbeiterDaten
        {
            get { return clsMitarbeiterDaten.Find(this.MitabeiterID); }
        }

        private clsTransportdienstDaten(int personalID, int mitarbeiterID , string bereichname)
        {
            this.PersonalID = personalID;
            this.MitabeiterID = mitarbeiterID;
            this.Bereichname = bereichname;
            Mode = enMode.Update;
        }

        public clsTransportdienstDaten()
        {
            this.PersonalID = -1;
            Mode = enMode.Addnew;
        }

        private bool _AddNew()
        {
            this.PersonalID = clsTransportdienstDatenZugriff.AddNewPersonal(this.MitabeiterID);
            return (this.PersonalID != -1);
        }

        public override bool Save()
        {
            if (Mode == enMode.Addnew)
            {
                if (_AddNew())
                {
                    Mode = enMode.Update;
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        public override bool Delete()
        {
            bool wurdeTransportdienstPersonalGelöscht = clsTransportdienstDatenZugriff.Delete(this.PersonalID);
            if (!wurdeTransportdienstPersonalGelöscht)
                return false;

            //hier werden die mitarbeiterdaten archiviert bevor sie gelöscht werden.
            return clsMitarbeiterDaten.Delete(this.MitabeiterID);
        }

        public static DataTable GetAllTransportdienstMitarbeiter()
        {
            return clsTransportdienstDatenZugriff.GetAllTransporstdienstMitarbeiter();
        }

        public static clsTransportdienstDaten Find(int PersonalID)
        {
            int mitarbeiter = -1; string bereichname = string.Empty;
            if (clsTransportdienstDatenZugriff.GetMitarbeiterbyPersonalID(PersonalID, ref mitarbeiter, ref bereichname))
            {
                return new clsTransportdienstDaten(mitarbeiter, PersonalID, bereichname);
            }
            else
               return null;
        }

        public static clsTransportdienstDaten FindByMitarbeiterID(int MitarbeiterID)
        {
            int personalID= -1; string bereichname = string.Empty;
            if (clsTransportdienstDatenZugriff.GetTransportdienstebyMitarbeiterID(ref personalID, MitarbeiterID, ref bereichname))
            {
                return new clsTransportdienstDaten(personalID, MitarbeiterID, bereichname);
            }
            else
                return null;
        }
    }
}
