using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsReinigungsPersonalDaten : clsPersonal
    {
        public  enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public override int PersonalID { get; set; }
        public override int MitabeiterID { get; set; }
        public override string Bereichname { get; set; }
        public clsMitarbeiterDaten mitarbeiterInfo
        {
            get { return clsMitarbeiterDaten.Find(this.MitabeiterID); }
        }

        private clsReinigungsPersonalDaten(int PersonalID, int mitarbeiterID, string bereichname)
        {
            this.PersonalID = PersonalID;
            this.MitabeiterID = mitarbeiterID;
            this.Bereichname = bereichname;
            Mode = enMode.Update;
        }
        public clsReinigungsPersonalDaten()
        {
            this.PersonalID = -1;
            Mode = enMode.AddNew;
        }

        private bool _AddNew()
        {
            this.PersonalID = clsReinigungsPersonalDatenZugriff.AddNewReinigungsPersonal(this.MitabeiterID);
            return (this.PersonalID != -1);
        }

        public override bool Save()
        {
            if(Mode == enMode.AddNew)
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

        public static clsReinigungsPersonalDaten Find(int PersonalID)
        {
            int MitarbeiterID = -1; string bereichname = string.Empty;
            if (clsReinigungsPersonalDatenZugriff.GetMitarbeiterbyPersonalID(PersonalID, 
                 ref MitarbeiterID, ref bereichname))
            {
                return new clsReinigungsPersonalDaten(PersonalID, MitarbeiterID, bereichname);
            }
            else
                return null;
        }

        public static clsReinigungsPersonalDaten FindByMitarbeiterID(int MitarbeiterID)
        {
            int PersonalID = -1; string bereichname = string.Empty;
            if (clsReinigungsPersonalDatenZugriff.GetReinigungsPersonalByMitarbeiterID(ref PersonalID,
                MitarbeiterID, ref bereichname))
            {
                return new clsReinigungsPersonalDaten(PersonalID, MitarbeiterID,bereichname);
            }
            else
                return null;
        }

        public override bool Delete()
        {
            bool WurderReinigunsPersonalGelöscht = clsReinigungsPersonalDatenZugriff.Delete(this.PersonalID);

            if (!WurderReinigunsPersonalGelöscht)
                return false;

             // Wir archivieren dien mitarbeitedaten für andere Zwicke wie statische sachen .
            return clsMitarbeiterDaten.Delete(this.MitabeiterID);          
        }

        public static DataTable GetAllReinigungsPersonal()
        {
            return clsReinigungsPersonalDatenZugriff.GetAllRenigungsPersonal();
        }
    }
}
