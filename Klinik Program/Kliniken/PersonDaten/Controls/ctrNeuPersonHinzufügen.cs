using clsHilfsMethoden;
using HilfsMethoden;
using Kliniken.Properties;
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
using System.IO;
using System.Runtime.InteropServices;

namespace Kliniken
{
    public partial class ctrNeuPersonHinzufügen : UserControl
    {
        //definiere eine Person event handler
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
                handler(PersonID);  // freigabe der PersonID beim Ereignis.
        }

        clsPersonDaten _Person;
        public clsPersonDaten SelectedPerson
        {
            get { return _Person; }
        }
        private enum _Geschlecht { Mänlich = 0, Weiblich = 1 }
        public ctrNeuPersonHinzufügen()
        {
            InitializeComponent();
        }
        public void ResetDefaulValue(bool AddNew)
        {
            _ResetTextBoxe();
            _FillCountriesInComboBox();

            if (AddNew)
            {
                _Person = new clsPersonDaten();
            }

            if (rbMänlich.Checked)
                pbPersonBild.Image = Resources.Male_512;
            else
                pbPersonBild.Image = Resources.Female_512;

            // in visilbe Modus, wenn ein Bild existiert.
            llBildLöschen.Visible = (pbPersonBild.ImageLocation != null);

            dtpGeburtsTag.Text = DateTime.Now.ToShortDateString();

            //rbMänlich.Checked = true;
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtLänder = clsLänderDaten.GetAllCountries();

            foreach (DataRow row in dtLänder.Rows)
            {
                cbLandName.Items.Add(row["CountryName"]);
            }

            cbLandName.SelectedIndex = cbLandName.FindString("Deutschland");
        }
        private void _ResetTextBoxe()
        {
            _ResetControls(gbNeuePersonHinzufügen.Controls);
        }
        private void _ResetControls(Control.ControlCollection Controls)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text =  string.Empty;
                }
                else if (control.HasChildren)
                {
                    _ResetControls(control.Controls);
                }
            }
        }

        public void LoadPersonData(int PersonID)
        {

            _Person = clsPersonDaten.Find(PersonID);
            if (_Person == null)
            {
                MessageBox.Show("Keine Person Mit der ID = " + PersonID, "Keine Person gefunden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtVorname.Text = _Person.Vorname;
            txtNachname.Text = _Person.Nachname;
            txtAusweisID.Text = _Person.AusweisID;
            dtpGeburtsTag.Text = _Person.GeburtsTag.ToShortDateString();
            dtpRegistrierungsDatum.Text = clsDatumFormat.DateToShort(_Person.RegistrierungsDatum);

            if (_Person.Geschlecht == 0)
                rbMänlich.Checked = true;
            else
                rbWeiblich.Checked = true;

            cbLandName.SelectedIndex = cbLandName.FindString(_Person.LandsDaten.LandName);
            txtStadt.Text = _Person.Stadt;
            txtPostleitzahl.Text = _Person.Postleitzahl;
            txtStraße.Text = _Person.Straße;
            txtHausNummer.Text = _Person.HausNummer;
            txtEmail.Text = _Person.Email;
            txtTelefonNummer.Text = _Person.TelefonNummer;

            if (!string.IsNullOrEmpty(_Person.FotoPfad))
                pbPersonBild.ImageLocation = _Person.FotoPfad;
            else
            {
                if (_Person.Geschlecht == 0)
                    pbPersonBild.Image = Resources.Male_512;
                else
                    pbPersonBild.Image = Resources.Female_512;
            }

            llBildLöschen.Visible = (_Person.FotoPfad != null);

        }
        private bool _HandleImage()
        {
            // Diese Prozedur verwaltet das Bild einer Person.
            // Sie kümmert sich darum, das alte Bild aus dem Ordner zu löschen,
            // falls sich das Bild geändert hat. Außerdem benennt sie das neue Bild
            // mit einer GUID um und platziert es im Bilderordner.

            // _Personen.FotoPfad enthält das alte Bild. Wir überprüfen, ob es sich geändert hat,
            // und kopieren dann das neue Bild.

            if (_Person.FotoPfad != pbPersonBild.ImageLocation)
            {
                if (!string.IsNullOrEmpty(_Person.FotoPfad))
                {
                    //zuerst wir löschen das alte Bild
                    try
                    {
                        // Bild freigeben
                        pbPersonBild.Image = null;
                        pbPersonBild.Update();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        _Person.FotoPfad = "";
                        //if (File.Exists(_Person.FotoPfad))
                        //{
                        //    File.Delete(_Person.FotoPfad);
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            if (pbPersonBild.ImageLocation != null)
            {
                string SourceDateiPfad = pbPersonBild.ImageLocation;
                if (clsOrdnerFürBilderErstellen.CopyImageToProjectImageFolder(ref SourceDateiPfad))
                {
                    pbPersonBild.ImageLocation = SourceDateiPfad;
                    return true;
                }
                else
                {
                    MessageBox.Show("Fehler beim Kopieren des SourceDateiPfad", "Fehler Meldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }


        private bool _Validierung(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                errorProvider1.SetError(textBox, "Das Feld darf nicht leer sein");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox, null);
                return true;
            }
        }

        public bool _IsTextBoxesVollWithData()
        {
            bool IsValid = true;

            IsValid = _Validierung(txtVorname);
            IsValid &= _Validierung(txtNachname);
            IsValid &= _Validierung(txtAusweisID);
            IsValid &= _Validierung(txtStadt);
            IsValid &= _Validierung(txtPostleitzahl);
            IsValid &= _Validierung(txtStraße);
            IsValid &= _Validierung(txtHausNummer);

            return IsValid;

        }

        private void ctrNeuPersonHinzufügen_Load(object sender, EventArgs e)
        {
            //ResetDefaulValue();
            //if (_Mode == enMode.Update)
            //   LoadPersonData();
        }

        public bool SaveData()
        {

            if (!_HandleImage())
            {
                return false;
            }

            int LandID = clsLänderDaten.Find(cbLandName.Text).LandID;

            _Person.Vorname = txtVorname.Text;
            _Person.Nachname = txtNachname.Text;
            _Person.AusweisID = txtAusweisID.Text;
            _Person.GeburtsTag = dtpGeburtsTag.Value;
            _Person.RegistrierungsDatum = dtpRegistrierungsDatum.Value;

            if (rbMänlich.Checked)
                _Person.Geschlecht = Convert.ToByte(_Geschlecht.Mänlich);
            else
                _Person.Geschlecht = Convert.ToByte(_Geschlecht.Weiblich);

            _Person.LandID = LandID;
            _Person.Stadt = txtStadt.Text;
            _Person.Postleitzahl = txtPostleitzahl.Text;
            _Person.Straße = txtStraße.Text;
            _Person.HausNummer = txtHausNummer.Text;

            if (txtEmail.Text != "")
                _Person.Email = txtEmail.Text;
            if (txtTelefonNummer.Text != "")
                _Person.TelefonNummer = txtTelefonNummer.Text;

            if (!string.IsNullOrEmpty(pbPersonBild.ImageLocation))
                _Person.FotoPfad = pbPersonBild.ImageLocation;
            
            if (_Person.Save())
            {
                if (OnPersonSelected != null)
                {
                    PersonSelected(_Person.PersonID);
                }
                return true;
            }

            return false;
        }

        private void rbMänlich_Click(object sender, EventArgs e)
        {
            //wechseln zum StandardFoto falls da kein Bild gibt.
            if (pbPersonBild.ImageLocation == null)
                pbPersonBild.Image = Resources.Male_512;
        }

        private void rbWeiblich_Click(object sender, EventArgs e)
        {
            //wechseln zum StandardFoto falls da kein Bild gibt.
            if (pbPersonBild.ImageLocation == null)
                pbPersonBild.Image = Resources.Female_512;
        }

        private void txtAusweisID_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtAusweisID.Text.Trim() != _Person.AusweisID && clsPersonDaten.IsPersonExist(txtAusweisID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAusweisID, "Diese ID ist für andere Person definiert.");
            }
            else
                errorProvider1.SetError(txtAusweisID, null);

        }

        private void llBildLöschen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Speichern Sie den Pfad des aktuellen Bildes, um es später zu löschen
            string bildPfad = pbPersonBild.ImageLocation;

            pbPersonBild.ImageLocation = null;
              
            if (rbMänlich.Checked)
                pbPersonBild.Image = Resources.Male_512;
            else
                pbPersonBild.Image = Resources.Female_512;

            llBildLöschen.Visible = false;

            if(!string.IsNullOrEmpty(bildPfad))
            {
                try
                {
                    File.Delete(bildPfad);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Löschen des Bildes: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void llBildSetzen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Bild Datei|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;  // damit beim nächsten Mal die gleiche DateiPfad  direkt geöffnet wird

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string AusgewählteDatei = openFileDialog1.FileName;
                pbPersonBild.Load(AusgewählteDatei);
                llBildLöschen.Visible = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if (!clsValidierung.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Fehler, Die Email hat die falsche Format");
            }
            else
                errorProvider1.SetError(txtEmail, null);
        }

        private void gbNeuePersonHinzufügen_Enter(object sender, EventArgs e)
        {

        }
    }
   
}
