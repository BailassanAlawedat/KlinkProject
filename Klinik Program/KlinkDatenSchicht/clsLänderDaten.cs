using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsLänderDaten
    {
        public enum enMode { Addnew = 0, Update = 1}
        public enMode Mode = enMode.Addnew;

        public int LandID { get; set; }
        public string LandName { get; set; }
        public string LandCode { get; set; }
        public string Kontinent { get; set; }

        private clsLänderDaten(int landID, string LandName, string LandCode, string Kontinent)
        {
            this.LandID = landID;
            this.LandName = LandName;
            this.LandCode = LandCode;
            this.Kontinent = Kontinent;

            Mode = enMode.Update;
        }

        public clsLänderDaten()
        {
            this.LandID = -1;
            this.LandName = "";
            this.LandCode = "";
            this.Kontinent = "";
        }

        public static DataTable GetAllCountries()
        {
            return clsLänderDatenZugriff.GetAllCountries();
        }

        public static clsLänderDaten Find(int LandID)
        {
            string LandName = ""; string LandCode = ""; string Kontinent = "";
            if (clsLänderDatenZugriff.GetCountryDataByID(LandID, ref LandName, ref LandCode, ref Kontinent))
            {
                return new clsLänderDaten(LandID, LandName, LandCode, Kontinent);
            }
            else
                return null;
        }

        public static clsLänderDaten Find(string LandName)
        {
            int LandID = -1; string LandCode = ""; string Kontinent = "";
            if (clsLänderDatenZugriff.GetCountryDataByName(ref LandID, LandName, ref LandCode, ref Kontinent))
            {
                return new clsLänderDaten(LandID, LandName, LandCode, Kontinent);
            }
            else
                return null;
        }
    }
}
