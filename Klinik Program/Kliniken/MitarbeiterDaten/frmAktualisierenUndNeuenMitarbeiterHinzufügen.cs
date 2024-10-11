using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmAktualisierenUndNeuenMitarbeiterHinzufügen : Form
    {
        private int _PersonID = -1;
        private int _MitarbeiterID = -1;
        public enum enMode { AddNew = 1, UpdateByPersonID = 2, UpdateByMitarbeiterID = 3}
        private enMode _Mode = enMode.AddNew;

        public enum enAbteilung { ReinigungsPersonal = 1, KüchenPersonal = 2, Transportdienst = 3,
        Sicherheitsdienst = 4}
        private enAbteilung _Abteilung = enAbteilung.ReinigungsPersonal;
        public frmAktualisierenUndNeuenMitarbeiterHinzufügen(enMode mode, enAbteilung abteilung)
        {
            InitializeComponent();

            _Mode = mode;
            _Abteilung = abteilung;
            
        }

        public frmAktualisierenUndNeuenMitarbeiterHinzufügen(enMode Mode, int PersonID)
        {
            InitializeComponent();

            _Mode = Mode;
            _PersonID = PersonID;
         
        }
        private void frmAktualisierenUndNeuenMitarbeiterHinzufügen_Load(object sender, EventArgs e)
        {
            if(_PersonID != -1)
                ctrPersonFilter1.txtFilterWertSetzen(_PersonID);
        }     
        private void btnDatenSpeichern_Click(object sender, EventArgs e)
        {
            _DatenFürSpeichernRichten();
        }

        private void _DatenFürSpeichernRichten()
        {
            if (_Mode == enMode.AddNew)
            {
                if (ctrMitarbeiterEinfügen1.MitarbeiterDatenSpeichern())
                {
                    switch (_Abteilung)
                    {
                        case enAbteilung.ReinigungsPersonal:
                            {
                                _ReinigungsPersonalDatenSpeichern();
                                break; ;
                            }

                        case enAbteilung.KüchenPersonal:
                            {
                                _KüchenPersonalDatenSpeichern();
                                break;
                            }

                        case enAbteilung.Transportdienst:
                            {
                                _TransportdienstDatenSpeichern();
                                break;
                            }

                        case enAbteilung.Sicherheitsdienst:
                            {
                                _SicherheitsdienstDatenSpeichern();
                                break;
                            }
                    }
                }
            }
            else if(_Mode == enMode.UpdateByMitarbeiterID || _Mode == enMode.UpdateByPersonID)
            {
                if(ctrMitarbeiterEinfügen1.MitarbeiterDatenSpeichern())
                {
                    MessageBox.Show("Mitarbeiterdaten wurden erfolgreich aktualisiert",
                               "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                    MessageBox.Show("Fehler beim Aktualisieren der Mitarbeiterdaten ist aufgetreten",
                               "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Fehler beim DatenSpeichern des Mitarbeiters ist aufgetreten",
                                "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }       

        private void _ReinigungsPersonalDatenSpeichern()
        {
            clsReinigungsPersonalDaten reinigungsPersonalDaten = new clsReinigungsPersonalDaten();
            reinigungsPersonalDaten.MitabeiterID = _MitarbeiterID;

            if (reinigungsPersonalDaten.Save())
            {
                MessageBox.Show("PersonlaReiniger mit der PersonalID [ " + reinigungsPersonalDaten.PersonalID +
                    " ] Und der MitarbeiterID [ " + _MitarbeiterID + " ] wurde erfolgreich " +
               "hinzugefügt", "Erfolg");
            }
            else
            {
                MessageBox.Show("Fehler beim DatenSpeichern der PersonalReiniger ist aufgetreten",
                                 "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _KüchenPersonalDatenSpeichern()
        {
            clsKüchenPersonalDaten küchenPersonalDaten = new clsKüchenPersonalDaten();
             küchenPersonalDaten.MitabeiterID = _MitarbeiterID;

            if (küchenPersonalDaten.Save())
            {
                MessageBox.Show("Küchen Mitrabeiter mit der PersonalID [ " +  küchenPersonalDaten.PersonalID +
                    " ] Und der MitarbeiterID [ " + _MitarbeiterID + " ] wurde erfolgreich " +
              "hinzugefügt", "Erfolg");
            }
            else
            {
                MessageBox.Show("Fehler beim DatenSpeichern Küchenpersonal ist aufgetreten",
                                 "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _TransportdienstDatenSpeichern()
        {
            clsTransportdienstDaten transportdienstDaten = new clsTransportdienstDaten();
            transportdienstDaten.MitabeiterID = _MitarbeiterID; // die MitarbeiterID wurd durch eventhandelr freigegeben 


            if (transportdienstDaten.Save())
            { 
                MessageBox.Show("Transportdienst Mitrabeiter mit der PersonalID [ " +  transportdienstDaten.PersonalID +
                    " ] Und der MitarbeiterID [ " + _MitarbeiterID + " ] wurde erfolgreich " +
              "hinzugefügt", "Erfolg");
            }
            else
            {
                MessageBox.Show("Fehler beim DatenSpeichern Transportdienst ist aufgetreten",
                                 "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _SicherheitsdienstDatenSpeichern()
        {
            clsSicherheitsdienstDaten sicherheitsdienstDaten = new clsSicherheitsdienstDaten();
            sicherheitsdienstDaten.MitabeiterID = _MitarbeiterID; // die MitarbeiterID wurd durch eventhandelr freigegeben 


            if (sicherheitsdienstDaten.Save())
            {
                    MessageBox.Show("Sicherheitsdienst Mitrabeiter mit der PersonalID [ " +  sicherheitsdienstDaten.PersonalID +
                   " ] Und der MitarbeiterID [ " + _MitarbeiterID + " ] wurde erfolgreich " +
                   "hinzugefügt", "Erfolg");
                
            }
            else
            {
                MessageBox.Show("Fehler beim DatenSpeichern Sicherheitsdienst ist aufgetreten",
                                 "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool _IsValidiert()
        {
            
            if (clsPatientDaten.IsPatientExistForPersonID(_PersonID))
            {
                MessageBox.Show("Diese Person ist bereits als Patient im System defeniert!!",
                   "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (clsArztDaten.IsDoctorExistForPersonID(_PersonID))
            {
                MessageBox.Show("Diese Person ist bereits als Arzt im System definiert!!",
                    "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (clsMitarbeiterDaten.DoesMitarbeiterExistForThisPerson(_PersonID))
            {
                if (clsMitarbeiterDaten.IsMitarbeiterActiveForThisPerson(_PersonID))
                {
                    MessageBox.Show("Diese Person ist bereits als Mitarbeiter und Aktive im System defeniert!!",
                        "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Diese Person ist bereits als Mitarbeiter aber nicht mehr Aktive im System defeniert!!",
                        "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return false;
            }
            return true;
        }

        private void ctrPersonFilter1_OnSelectedPersonID(int obj)
        {
            _PersonID = obj;
            if (_Mode == enMode.AddNew)
            {
                if (!_IsValidiert())
                {
                    return;
                }
            }
          
            btnDatenSpeichern.Enabled = true;           
            _PassendeDatenSetzen();
        }

        private void _PassendeDatenSetzen()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    ctrMitarbeiterEinfügen1.AddNew(true, _PersonID);
                    break;

                case enMode.UpdateByPersonID:
                    ctrMitarbeiterEinfügen1.LoadMitarbeiterDataByPersonID(_PersonID);
                    break;

                case enMode.UpdateByMitarbeiterID:
                    ctrMitarbeiterEinfügen1.LoadMitarbeiterDataByMitarbeiterID(_MitarbeiterID);
                    break;

                default:
                    ctrMitarbeiterEinfügen1.AddNew(true, _PersonID);
                    break;
            }

        }
        private void ctrMitarbeiterEinfügen1_OnMitarbeiterSelectedID(int obj)
        {
            _MitarbeiterID = obj;
        }

    }
}
