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

    public partial class frmAktualisierenUndNeuenBenutzerHinzufügen : Form
    {
        private enum enBenutzerMode {Erstelltung = 1, Aktualisierung = 2 }
        private enBenutzerMode _Mode;

         private int _PersonID = -1;
        private int _BenutzerID = -1;
        clsBenutzerDaten _BenutzerDaten;
        public frmAktualisierenUndNeuenBenutzerHinzufügen()
        {
            InitializeComponent();

            _Mode = enBenutzerMode.Erstelltung;
            lblTitel.Text = "Neue Benutzer hinzufügen";
            this.Text =  "Neue Benutzer hinzufügen";
        }

        public frmAktualisierenUndNeuenBenutzerHinzufügen(int PersonID)
        {
            InitializeComponent();

            _Mode = enBenutzerMode.Aktualisierung;
            lblTitel.Text = "Benutzer aktualisieren";
            this.Text = "Benutzer aktualisieren";
            _PersonID = PersonID;
        }


        public frmAktualisierenUndNeuenBenutzerHinzufügen(string Rolle, string Passwort)
        {
            InitializeComponent();

            _Mode = enBenutzerMode.Aktualisierung;
            lblTitel.Text = "Benutzer aktualisieren";
            _BenutzerDaten = clsBenutzerDaten.FindUserByUserRolleAndPassword(Rolle, Passwort);
            _LoadBenutzerInfo();
        }
        private void frmNachPersonSuchen_Load(object sender, EventArgs e)
        {
            ctrPersonenFilter1.EingebeFeldSelected();
            _DatumFormatierung();

            if (_Mode == enBenutzerMode.Aktualisierung)
            {
                ctrPersonenFilter1.LoadPersonInfoByPersonID(_PersonID);
                _LoadBenutzerInfoByPersonID(_PersonID);
            }
        }
        private void _DatumFormatierung()
        {
            string CustomFormat = "dd-MM-yyyy              HH:mm";
            dtpErstelltAm.Format = DateTimePickerFormat.Custom;
            dtpErstelltAm.CustomFormat = CustomFormat;

            dtpAktualisiertAm.Format = DateTimePickerFormat.Custom;
            dtpAktualisiertAm.CustomFormat = CustomFormat;

            dtpLetzterLogin.Format = DateTimePickerFormat.Custom;
            dtpLetzterLogin.CustomFormat = CustomFormat;
        }

        private void _ResetDefaultValue()
        {
                tabPage2BenutzerInfo.Enabled = false;
            lblPersonID.Text = "???";
                lblBenutzerID.Text = "???";
                cbIstAktive.Checked = false;
                txtbRolle.Text = string.Empty;
                txtbBenutzerPasswort.Text = string.Empty;
                dtpErstelltAm.Value = DateTime.Now;
                dtpAktualisiertAm.Value = DateTime.Now;
            _Mode = enBenutzerMode.Erstelltung;
        }
        private void lblBenutzerID_Click(object sender, EventArgs e)
        {

        }

        private void btnZuBenutzerSeite_Click(object sender, EventArgs e)
        {

            tbPersonInfo.SelectedTab = tbPersonInfo.TabPages["tabPage2BenutzerInfo"];
            // Stelle sicher, dass die Registerkarte mit dem Namen "tabPage2BenutzerInfo" vorhanden ist
            TabPage targetTab = tbPersonInfo.TabPages["tabPage2BenutzerInfo"];

            if (targetTab != null)
            {
                // Wähle die Registerkarte aus
                tbPersonInfo.SelectedTab = targetTab;

                // Überprüfe, ob die ausgewählte Registerkarte die gewünschte ist
                if (tbPersonInfo.SelectedTab == targetTab)
                {
                    btnZurPersonInfoSeite.Enabled = true;
                }
            }
            else
            {
                // Die Registerkarte mit dem angegebenen Namen wurde nicht gefunden
                MessageBox.Show("Die Registerkarte 'tabPage2BenutzerInfo' wurde nicht gefunden.");
            }

        }

        private void ctrPersonenFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID != -1)
            {
                    /* wenn ich zur person seite zurückgehen und dann eine andere Person auswähle,soll die 
                 * Benutzerseite wieder mit standardparametern versehen werden.
                */
                
                if(clsArztDaten.IsDoctorExistForPersonID(_PersonID))
                {
                    MessageBox.Show("Diese Person existiert bereits im System als Arzt. Bitte geben Sie eine andere Person ein.",
                   "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(clsPatientDaten.IsPatientExistForPersonID(_PersonID))
                {
                    MessageBox.Show("Diese Person existiert bereits im System als Patienten. Bitte geben Sie eine andere Person ein.",
                 "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(clsBenutzerDaten.DoesUserExistsForThisPerson(_PersonID) && _Mode != enBenutzerMode.Aktualisierung)
                {
                  var result = MessageBox.Show("Diese Person existiert bereits im System als Benutzer." +
                        "Möchten Sie die Benutzerdaten aktualisieren ?",
                  "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.No)
                        return;
                }

               _ResetDefaultValue();
                lblPersonID.Text = _PersonID.ToString();
                _LoadBenutzerInfoByPersonID(_PersonID);
                btnZuBenutzerSeite.Enabled = true;
                tabPage2BenutzerInfo.Enabled= true;
            }
        }

        private void btnZurPersonInfoSeite_Click(object sender, EventArgs e)
        {
            tbPersonInfo.SelectedTab = tbPersonInfo.TabPages["tabPage1PersonInfo"];
            btnBenutzerDatenSpeichern.Enabled = true;
        }

        private void btnBenutzerDatenSpeichern_Click(object sender, EventArgs e)
        {

            if (!_FelderValidation())
                return;

            switch (_Mode)
            {
                case enBenutzerMode.Erstelltung:
                    _AddNewUser();
                    break;

                case enBenutzerMode.Aktualisierung:
                    _UpdateUser();
                    break;
            }

        }

        private bool _FelderValidation()
        {
            if (string.IsNullOrEmpty(txtbRolle.Text.Trim()) || string.IsNullOrEmpty(txtbBenutzerPasswort.Text.Trim()))
            {
                MessageBox.Show("Die beiden Felder müssen mit Daten ausgefüllt werden", "Fehlermeldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtbRolle, "Fehler");
                errorProvider1.SetError(txtbBenutzerPasswort, "Fehler");
                return false;
            }

            string AktuellesBenutzer = txtbRolle.Text.Trim();

            switch (_Mode)
            {
                case enBenutzerMode.Aktualisierung:
                    if (AktuellesBenutzer != _BenutzerDaten.Rollenname)
                    {
                        if (clsBenutzerDaten.DoesRollenNameExists(AktuellesBenutzer))
                        {
                            MessageBox.Show("Dieser Rollenname existiert bereits für eine andere Person. Bitte geben Sie einen anderen Rollennamen ein.",
                                "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    break;

                case enBenutzerMode.Erstelltung:

                    if (clsBenutzerDaten.DoesRollenNameExists(txtbRolle.Text.Trim()))
                     {
                    MessageBox.Show("Dieser Rollenname existiert bereits für eine andere Person. Bitte geben Sie einen anderen Rollennamen ein.",
                     "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return false;
                     }
                     
                    break;
            }
            return true;
        }

        public void _AddNewUser()
        {
            _BenutzerDaten = new clsBenutzerDaten();

            _BenutzerDaten.PersonID = int.Parse(lblPersonID.Text);
            _BenutzerDaten.Rollenname = txtbRolle.Text;
            _BenutzerDaten.BenutzerPasswort = txtbBenutzerPasswort.Text;
            _BenutzerDaten.ErstelltAm = dtpErstelltAm.Value;
            _BenutzerDaten.AktualisiertAm = DateTime.Now;
            _BenutzerDaten.LetzterLogin = dtpLetzterLogin.Value;
            _BenutzerDaten.IstAktive = cbIstAktive.Checked;

            if (_BenutzerDaten.Save())
            {
                lblBenutzerID.Text = _BenutzerDaten.BenutzerID.ToString();
                string message = "hinzugefügt.";
                MessageBox.Show($"Benutzer mit ID [ {_BenutzerDaten.BenutzerID} ]" +
                    $" Wurde erfolgreich {message}. ", "Erfolg",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBenutzerDatenSpeichern.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Fehler beim Hinzufügen eines neuen Benutzer ist aufgetreten",
                    "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void _UpdateUser()
        {
            _BenutzerDaten.Rollenname = txtbRolle.Text;
            _BenutzerDaten.BenutzerPasswort = txtbBenutzerPasswort.Text;
            _BenutzerDaten.ErstelltAm = dtpErstelltAm.Value;
            _BenutzerDaten.AktualisiertAm = DateTime.Now;
            _BenutzerDaten.LetzterLogin = dtpLetzterLogin.Value;
            _BenutzerDaten.IstAktive = cbIstAktive.Checked;

            if (_BenutzerDaten.Save())
            {
                string message = "aktualisiert.";
                MessageBox.Show($"Benutzer mit ID [ {_BenutzerDaten.BenutzerID} ]" +
                    $" Wurde erfolgreich {message}. ", "Erfolg",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBenutzerDatenSpeichern.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Fehler beim Aktualisieren eines neuen Benutzer ist aufgetreten",
                    "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _LoadBenutzerInfoByPersonID(int PersonID)
        {
            if(!clsBenutzerDaten.DoesUserExistsForThisPerson(PersonID))
            {
                btnBenutzerDatenSpeichern.Text = "Benutzerdaten hinzufügen";
                return;
            }
            _Mode = enBenutzerMode.Aktualisierung;
            btnZuBenutzerSeite.Text = "Zum Benutzerdaten Aktualisieren";
            btnBenutzerDatenSpeichern.Text = "Benutzerdaten aktualisieren";

            _BenutzerDaten = clsBenutzerDaten.FindUserByPersonID(PersonID);

            lblBenutzerID.Text = _BenutzerDaten.BenutzerID.ToString();
            txtbRolle.Text = _BenutzerDaten.Rollenname;
            txtbBenutzerPasswort.Text = _BenutzerDaten.BenutzerPasswort;
            dtpErstelltAm.Value = _BenutzerDaten.ErstelltAm.Value;
            dtpAktualisiertAm.Value = _BenutzerDaten.AktualisiertAm.Value;
            dtpLetzterLogin.Value = _BenutzerDaten.LetzterLogin.Value;
            cbIstAktive.Checked = _BenutzerDaten.IstAktive;
          
        }
        private void _LoadBenutzerInfo()
        {
            _BenutzerDaten = clsBenutzerDaten.FindUserByPersonID(_PersonID);

            if (_BenutzerDaten == null && _Mode == enBenutzerMode.Aktualisierung)
            {
                MessageBox.Show("Kein Benutzer mit der ID [ " + _BenutzerID + " ] wurde gefunden","Fehlermeldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _Mode = enBenutzerMode.Aktualisierung;
            btnZuBenutzerSeite.Text = "Zum Benutzerdaten Aktualisieren";
            txtbRolle.Text = _BenutzerDaten.Rollenname;
            txtbBenutzerPasswort.Text = _BenutzerDaten.BenutzerPasswort;
            dtpErstelltAm.Value = _BenutzerDaten.ErstelltAm.Value;
            dtpAktualisiertAm.Value = _BenutzerDaten.AktualisiertAm.Value;
            dtpLetzterLogin.Value = _BenutzerDaten.LetzterLogin.Value;
            cbIstAktive.Checked = _BenutzerDaten.IstAktive;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
