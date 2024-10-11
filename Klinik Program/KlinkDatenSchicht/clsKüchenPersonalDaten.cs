 using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsKüchenPersonalDaten : clsPersonal
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public override int PersonalID { get; set; }
        public override int MitabeiterID { get; set; }
        public override string Bereichname { get; set; }
        public clsMitarbeiterDaten mitarbeiterInfo
        {
            get { return clsMitarbeiterDaten.Find(this.MitabeiterID); }
        }

        private clsKüchenPersonalDaten(int PersonalID, int mitarbeiterID, string bereichname)
        {
            this.PersonalID = PersonalID;
            this.MitabeiterID = mitarbeiterID;
            this.Bereichname = bereichname;
            Mode = enMode.Update;
        }
        public clsKüchenPersonalDaten()
        {
            this.PersonalID = -1;
            Mode = enMode.AddNew;
        }

        private bool _AddNew()
        {
            this.PersonalID = clsKüchenPersonalDatenZugriff.AddNewKüchenPersonal(this.MitabeiterID);
            return (this.PersonalID != -1);
        }

        public override bool Save()
        {
            if (Mode == enMode.AddNew)
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

        public static clsKüchenPersonalDaten Find(int PersonalID)
        {
            int MitarbeiterID = -1; string bereichname = string.Empty;
            if (clsKüchenPersonalDatenZugriff.GetMitarbeiterbyPersonalID(PersonalID, ref MitarbeiterID,
                       ref bereichname ))
            {
                return new clsKüchenPersonalDaten(PersonalID, MitarbeiterID, bereichname);
            }
            else
                return null;
        }

        public static clsKüchenPersonalDaten FindByMitarbeiterID(int MitarbeiterID)
        {
            int PersonalID = -1; string bereichname = string.Empty;
            if (clsKüchenPersonalDatenZugriff.GetKüchenPersonalByMitarbeiterID(ref PersonalID,
                MitarbeiterID, ref bereichname))
            {
                return new clsKüchenPersonalDaten(PersonalID, MitarbeiterID, bereichname);
            }
            else
                return null;
        }

        public override bool Delete()
        {
            bool WurderKüchenPersonalGelöscht = clsKüchenPersonalDatenZugriff.Delete(this.PersonalID);

            if (!WurderKüchenPersonalGelöscht)
                return false;

            // Anstatt die datensätze zulöschen, werden sie nur deaktiviert.
            return clsMitarbeiterDaten.Delete(this.MitabeiterID);
        }

        public static DataTable GetAllKüchenPersonalMitarbeiter()
        {
            return clsKüchenPersonalDatenZugriff.GetAllKüchenPersonal();
        }
    }
}
