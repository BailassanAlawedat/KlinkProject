using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmAktualisierenUndNeueArztHinzufügen : Form
    {
         private enum enMode { Addnew = 0, Update = 1, PersonZuArzt = 2} 
        private enMode _Mode = enMode.Addnew;
        private clsArztDaten _ArztDaten;
        private int _ArztID;
        private int _SelectedPersonID;
        public frmAktualisierenUndNeueArztHinzufügen()
        {
            InitializeComponent();

            _Mode = enMode.Addnew;
        }

        public frmAktualisierenUndNeueArztHinzufügen(int ArztID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _ArztID = ArztID;
            lblTitle.Text = "Arzt Daten aktualisieren";
        }

        public frmAktualisierenUndNeueArztHinzufügen(int ArztID, int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.PersonZuArzt;
            _ArztID = ArztID;
            _SelectedPersonID = PersonID;
            lblTitle.Text = "Arzt Daten aktualisieren";
        }

        private void frmAktualisierenUndNeueArztHinzufügen_Load(object sender, EventArgs e)
        {
            _FillComboBoxWithProfessions();
            _LoadPersonData();
        }

        private void _FillComboBoxWithProfessions()
        {
            DataTable dt = clsFachrichtungenDaten.GetAllProfessions();

            foreach(DataRow row in dt.Rows)
            {
                cbFachrichtungen.Items.Add(row["FachrichtungsName"]);
            }

            cbFachrichtungen.SelectedIndex = 0;
        }

        private void _LoadPersonData()
        {
            switch(_Mode)
            {
                case enMode.Addnew:
                    ctrNeuPersonHinzufügen1.ResetDefaulValue(true);
                    break;

                case enMode.Update:
                    ctrNeuPersonHinzufügen1.ResetDefaulValue(false);
                    _ArztDaten = clsArztDaten.Find(_ArztID);
                    if(_ArztDaten == null)
                    {
                        MessageBox.Show("Arzt Daten mit der ID " + _ArztID.ToString() + " wurden nicht gefunden",
                            "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ctrNeuPersonHinzufügen1.LoadPersonData(_ArztDaten.PersonID);
                    cbFachrichtungen.Text = _ArztDaten.FachrichtungsInfo.FachrichtungsName;
                    lblPersonID.Text = "Person ID: " + _ArztDaten.PersonID;
                    lblArztID.Text = "Arzt ID: " + _ArztDaten.ArztID;
                    btnDatenSpeichern.Text = "Arzt Daten aktualisieren";

                    break;

                case enMode.PersonZuArzt:
                    ctrNeuPersonHinzufügen1.ResetDefaulValue(false);
                    btnDatenSpeichern.Text = "Person aktualisieren";
                    ctrNeuPersonHinzufügen1.LoadPersonData(_SelectedPersonID);
                    lblPersonID.Text = "Person ID:" + _SelectedPersonID;
                    break;
            }
        }

        private void btnDatenSpeichern_Click(object sender, EventArgs e)
        {
            if(!ctrNeuPersonHinzufügen1._IsTextBoxesVollWithData())
            {
                MessageBox.Show("Leere Felder müssen ausgefüllt werden", "Fehler Meldung",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Mode == enMode.Addnew || _Mode == enMode.PersonZuArzt)
            {
                if(ctrNeuPersonHinzufügen1.SaveData())
                {
                    if (_SelectedPersonID == -1)
                        return;

                    if (clsPatientDaten.IsPatientExistForPersonID(_SelectedPersonID))
                    {
                        MessageBox.Show("Diese Person ist schon ein Patient im System", "Nicht erlaubt",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(clsArztDaten.IsDoctorExistForPersonID(_SelectedPersonID))
                    {
                        MessageBox.Show("Diese Person ist schon ein Arzt im System", "Nicht erlaubt",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _ArztDaten = new clsArztDaten();
                    _ArztDaten.PersonID = _SelectedPersonID;

                    string FachrichtungsName = cbFachrichtungen.SelectedItem as string;
                    _ArztDaten.FachrichtungsID = clsFachrichtungenDaten.Find(FachrichtungsName).FachrichtungsID;

                    if(_ArztDaten.Save())
                    {
                        lblArztID.Text = "Inserted ArztID = " + _ArztDaten.ArztID;
                        lblPersonID.Text = "Inserted PersonID = " + _ArztDaten.PersonID;

                        MessageBox.Show("Arzt Daten wurden erfolgreich gespeichert", "Erfolg",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

            }
            else
            {
                if (ctrNeuPersonHinzufügen1.SaveData())
                {
                    MessageBox.Show("Arzt Daten wurden erfolgreich aktualisiert", "Erfolg",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    this.Close();
                }
                else
                    MessageBox.Show("Fehler beim Aktualisieren Der Daten ist aufgetreten\n" +
                        "Versuchen Sie es bitte erneut", "FehlerMeldung",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrNeuPersonHinzufügen1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
