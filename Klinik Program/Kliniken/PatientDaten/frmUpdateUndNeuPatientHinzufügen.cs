using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmUpdateUndNeuPatientHinzufügen : Form
    {
        public delegate void GetDataBack(object sender, int ID);
        public GetDataBack Databack;
        private enum enMode { Addnew = 0, Update = 1, WirdPatient = 2 }
        enMode _Mode = enMode.Addnew;

        private int _PatientID = -1;
        private int _SelectedPersonID = -1;
        public frmUpdateUndNeuPatientHinzufügen()
        {
            InitializeComponent();
            _Mode = enMode.Addnew;
            lblTitel.Text = "Neu Person hinzufügen";
        }

        public frmUpdateUndNeuPatientHinzufügen(int PersonID)
        {
            InitializeComponent();
            _SelectedPersonID = PersonID;
            _Mode = enMode.WirdPatient;
            lblTitel.Text = "Person zu Patient aktualisieren";
        }
        public frmUpdateUndNeuPatientHinzufügen(int PatientID, int PersonID)
        {
            InitializeComponent();
            _PatientID = PatientID;
            _SelectedPersonID = PersonID;

            _Mode = enMode.Update;
            lblTitel.Text = "Person Daten aktualisieren";
        }
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatenSpeichern_Click(object sender, EventArgs e)
        {
            if(!ctrNeuPersonHinzufügen1._IsTextBoxesVollWithData())
            {
                MessageBox.Show("Leere Felder müssen ausgefüllt werden", "Fehler Meldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (_Mode == enMode.Addnew ||_Mode == enMode.WirdPatient)
            {
                if (ctrNeuPersonHinzufügen1.SaveData())
                {
                    if (_SelectedPersonID == -1)
                        return;

                    if (clsArztDaten.IsDoctorExistForPersonID(_SelectedPersonID))
                    {
                        MessageBox.Show("Diese Person ist schon ein Arzt im System", "Nicht erlaubt",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }

                    if (clsPatientDaten.IsPatientExistForPersonID(_SelectedPersonID))
                    {
                        MessageBox.Show("Diese Person ist schon ein Patient im System", "Nicht erlaubt",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }

                    clsPatientDaten Patient = new clsPatientDaten();
                    Patient.PersonID = _SelectedPersonID;

                    if (Patient.Save())
                    {
                        lblPatientID.Text = "Inserted PatientID = " + Patient.PatientID.ToString();
                        lblPersonID.Text = "Inserted PersonID = " + Patient.PersonID.ToString();
                      
                        Databack?.Invoke(this, Patient.PatientID);

                        MessageBox.Show("Patient Daten wurden erfolgreich gespeichert", "Erfolg",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else
                        MessageBox.Show("Patient Daten wurden nicht erfolgreich gespeichert", "Fehler Meldung",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("Fehler beim Speichern der Daten aus aufgetreten\n" +
                        "Versuchen Sie es bitte erneut", "Fehler Meldung",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                if (ctrNeuPersonHinzufügen1.SaveData())
                {
                    MessageBox.Show("Patient Daten wurden erfolgreich aktualisiert", "Erfolg",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDatenSpeichern.Enabled = false;
                    this.Close();
                    return;
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

        private void frmUpdateUndNeuPatientHinzufügen_Load(object sender, EventArgs e)
        {
            _LoadPersonInfo();          
        }

        private void _LoadPersonInfo()
        {
            switch (_Mode)
            {
                case enMode.Update:
                    {
                        ctrNeuPersonHinzufügen1.ResetDefaulValue(false);

                        ctrNeuPersonHinzufügen1.LoadPersonData(_SelectedPersonID);
                        lblPersonID.Text = "PersonID: " +_SelectedPersonID.ToString();
                        clsPatientDaten Patient = clsPatientDaten.Find(_PatientID);
                        if (Patient == null)
                        {
                            MessageBox.Show("Patient mit der ID = " +_PatientID + " wurde nicht gefunden",
                                "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        lblPatientID.Text = "PatientID: " +Patient.PatientID.ToString();

                        break;
                    }

                case enMode.Addnew:
                    {
                        ctrNeuPersonHinzufügen1.ResetDefaulValue(true);
                        break;
                    }

                case enMode.WirdPatient:
                    {
                        ctrNeuPersonHinzufügen1.ResetDefaulValue(false);

                        ctrNeuPersonHinzufügen1.LoadPersonData(_SelectedPersonID);
                        lblPersonID.Text = "PersonID: " +_SelectedPersonID.ToString();
                        btnDatenSpeichern.Text = "Person aktualisieren";
                        break;
                    }
            }
        }
        private void ctrNeuPersonHinzufügen1_Load(object sender, EventArgs e)
        {

        }
    }
}
