using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsBezahlungDaten
    {
        public enum enMode { Addnew = 0, Update = 1}
        public enMode Mode = enMode.Addnew;
        public int BezahlungsID { get; set; }
        public int TerminID { get; set; }
        public string BezahlungsMethode { get; set; }
        public DateTime BezahlungsDatum { get; set; }
        public float BetragZumBezahlen { get; set; }

        private clsBezahlungDaten(int BezahlungsID, int TerminID, string BezahlungsMethode,
                                   DateTime BezahlungsDatum, float BetragZumBezahlen)
        {
            this.BezahlungsID = BezahlungsID;
            this.TerminID = TerminID;
            this.BezahlungsMethode = BezahlungsMethode;
            this.BezahlungsDatum = BezahlungsDatum;
            this.BetragZumBezahlen = BetragZumBezahlen;

            Mode = enMode.Update;
        }

        public clsBezahlungDaten()
        {
            this.BezahlungsID = -1;
            this.TerminID = -1;
            this.BezahlungsMethode = "";
            this.BezahlungsDatum = DateTime.Now;
            this.BetragZumBezahlen = 0;

            Mode = enMode.Addnew;
        }

        private bool _AddNewBezahlung()
        {
            this.BezahlungsID = clsBezahlungenDatenZugriff.AddNewBezahlung(this.TerminID,this.BezahlungsMethode,
                this.BezahlungsDatum, this.BetragZumBezahlen);
            return (this.BezahlungsID != 0);
        }

        private bool _Update()
        {
            return clsBezahlungenDatenZugriff.UpdateBezahlung(this.BezahlungsID,this.TerminID, 
                this.BezahlungsMethode, this.BezahlungsDatum, this.BetragZumBezahlen);
        }
        public static clsBezahlungDaten Find(int BezahlungsID)
        {
            int TerminID = -1;  string BezahlungsMethode = ""; DateTime BezahlungsDatum = DateTime.Now; 
            float BetragZumBezahlen = 0;

            if (clsBezahlungenDatenZugriff.GetBezahlungsDatenByID(BezahlungsID,ref TerminID,ref BezahlungsMethode,
                                                   ref BezahlungsDatum, ref BetragZumBezahlen))
            {
                return new clsBezahlungDaten(BezahlungsID,TerminID, BezahlungsMethode, BezahlungsDatum, BetragZumBezahlen);
            }
            else
                return null;
        }

        public bool Delete()
        {
            return clsBezahlungenDatenZugriff.DeleteBezahlung(this.BezahlungsID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Addnew:
                    if (_AddNewBezahlung())
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
