using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsFachrichtungenDaten
    {
        public enum enMode { Addnew = 0, Update = 1}
        public enMode Mode = enMode.Addnew;

        public int FachrichtungsID { get; set; }
        public string FachrichtungsName { get; set; }

        private clsFachrichtungenDaten(int ID, string name)
        {
            this.FachrichtungsID = ID;
            this.FachrichtungsName = name;

            Mode = enMode.Update;
        }

        public clsFachrichtungenDaten()
        {
            this.FachrichtungsID = -1;
            this.FachrichtungsName = "";

            Mode = enMode.Addnew;
        }

        private bool _AddNew()
        {
            this.FachrichtungsID = clsFachrichtungenDatenZugriff.AddNeuProfission(this.FachrichtungsName);
            return (this.FachrichtungsID != -1);
        }
        private bool _Update()
        {
            return clsFachrichtungenDatenZugriff.UpdateProfission(this.FachrichtungsID, this.FachrichtungsName);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Addnew:
                    if (_AddNew())
                    {
                        Mode =enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static clsFachrichtungenDaten Find(int FachrichtungsID)
        {
            string Name = "";
            if (clsFachrichtungenDatenZugriff.GetProfessionByID(FachrichtungsID, ref Name))
                return new clsFachrichtungenDaten(FachrichtungsID, Name);
            else
                return null;
        }
        public static clsFachrichtungenDaten Find(string FachrichtungsName)
        {
            int ID = -1;
            if (clsFachrichtungenDatenZugriff.GetProfessionByName(ref ID, FachrichtungsName))
                return new clsFachrichtungenDaten(ID, FachrichtungsName);
            else
                return null;
        }

        public static clsFachrichtungenDaten FindByDoctorID(int ArztID)
        {
            string Name = ""; int FachrichtungsID = -1;
            if (clsFachrichtungenDatenZugriff.GetProfessionNameByDoctorID(ArztID, ref FachrichtungsID, ref Name))
                return new clsFachrichtungenDaten(FachrichtungsID, Name);
            else
                return null;
        }
        public static DataTable GetAllProfessions()
        {
            return clsFachrichtungenDatenZugriff.GetAllProfissions();
        }

        public static bool DoesProfissionExist(string FachrichtungsName)
        {

            return clsFachrichtungenDatenZugriff.DoesProfissionExist(FachrichtungsName);
        }

        public static DataTable GetDoctorWithProfission(int FachrichtungsID)
        {
            return clsFachrichtungenDatenZugriff.GetDoctorWithProfission(FachrichtungsID);
        }
    }
}
