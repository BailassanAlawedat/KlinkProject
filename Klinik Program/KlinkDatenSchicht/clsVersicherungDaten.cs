using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsVersicherungDaten
    {
        public enum enMode  {Addnew = 0, Update = 1}
        public enMode Mode = enMode.Addnew;

        public int VersicherungID { get; set; }
        public string VersicherungsName { get; set; }

        private clsVersicherungDaten(int VersicherungID, string VersicherungsName)
        {
            this.VersicherungID = VersicherungID;
            this.VersicherungsName = VersicherungsName;

            Mode = enMode.Update;
        }

        public clsVersicherungDaten()
        {
            this.VersicherungID = -1;
            this.VersicherungsName = "";

            Mode = enMode.Addnew;
        }

        private bool _AddNew()
        {
            this.VersicherungID = clsVersicherungenDatenZugriff.AddNewVersicherung(this.VersicherungsName);

            return (this.VersicherungID != -1);
        }

        private bool _Update()
        {
            return clsVersicherungenDatenZugriff.UpdateVersicherung(this.VersicherungID, this.VersicherungsName);
        }

        public static clsVersicherungDaten Find(int VersicherungID)
        {
           string VersicherungsName = "";
           

            if (clsVersicherungenDatenZugriff.GetVersicherungsDatenByID(VersicherungID, ref VersicherungsName))
            {
                return new clsVersicherungDaten(VersicherungID,VersicherungsName);
            }
            else
                return null;
        }

        public static clsVersicherungDaten Find(string VersicherungsName)
        {
            int VersicherungID = -1 ;


            if (clsVersicherungenDatenZugriff.GetVersicherungsDatenByName(ref VersicherungID,VersicherungsName))
            {
                return new clsVersicherungDaten(VersicherungID, VersicherungsName);
            }
            else
                return null;
        }

        public bool Delete()
        {
            return clsVersicherungenDatenZugriff.DeleteVersicherung(this.VersicherungID);
        }

        public static DataTable GetAllVersicherungen()
        {
            return clsVersicherungenDatenZugriff.GetAllVersicherungen();
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
    }
}
