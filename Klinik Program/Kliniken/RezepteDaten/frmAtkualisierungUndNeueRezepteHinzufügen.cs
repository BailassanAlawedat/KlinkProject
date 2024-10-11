using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
  
    public partial class frmAtkualisierungUndNeueRezepteHinzufügen : Form
    {
        public delegate void EventHandler(object sender, int RezeptID);
        public event EventHandler Databack;

        private void SendDataback(int RezeptID)
        {
            Databack(this, RezeptID);
        }
        public enum enMode { Addnew = 0, UpdateByTerminID = 1, UpdateByRezeptID = 2}
        public enMode Mode = enMode.Addnew;
        private int _TerminID = -1;
        private int _VersicherungID = -1;
        private int _RezeptID = -1;
        private clsRezeptDaten _Rezeptdaten;


        public frmAtkualisierungUndNeueRezepteHinzufügen(int TerminID, int VersicherungID)
        {
            InitializeComponent();

            Mode = enMode.Addnew;
            _TerminID = TerminID;
            lblTerminID.Text = _TerminID.ToString();

            _VersicherungID = VersicherungID;
            lblVersicherungID.Text = _VersicherungID.ToString();

            _Rezeptdaten = new clsRezeptDaten();
        }
        public frmAtkualisierungUndNeueRezepteHinzufügen(int ID, enMode UpdateBy)
        { 
            InitializeComponent();

            Mode = UpdateBy;
            switch(Mode)
            {
                case enMode.UpdateByRezeptID:
                    _RezeptID = ID;
                    break;

                case enMode.UpdateByTerminID:
                    _TerminID = ID;
                    break;

                default:
                    break;
            }
            btnSpeichern.Text = "aktualisieren";
        }
        private void frmAtkualisierungUndNeueRezepteHinzufügen_Load(object sender, EventArgs e)
        {
            cbHäufigkeit.SelectedIndex = 0;
            cbSpzielleAnweisungen.SelectedIndex = 0;

            switch(Mode)
            {
                case enMode.UpdateByRezeptID:
                    _LoadRezepteByRezeptID();
                    break;

                case enMode.UpdateByTerminID:
                    _LoadRezepteByTerminID();
                    break;
            }
        }


        private void _LoadRezepteByTerminID()
        {
            _ResetDefautlValue();

            _Rezeptdaten = clsRezeptDaten.FindRezeptByTerminID(_TerminID);
            if(_Rezeptdaten == null)
            {
                MessageBox.Show("Rezept mit der TerminID { " + _TerminID + " } wurde nicht gefunden.",
                    "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRezeptID.Text = _Rezeptdaten.RezeptID.ToString();
            lblTerminID.Text = _Rezeptdaten.TerminID.ToString();
            lblVersicherungID.Text = _Rezeptdaten.VersicherungID.ToString();
            txtRezeptname.Text = _Rezeptdaten.RezeptName;

            if (_Rezeptdaten.Dosierung == string.Empty)
                txtDosierung.Text = string.Empty;
            else
                txtDosierung.Text = _Rezeptdaten.Dosierung;

            dtpStartdatum.Value = _Rezeptdaten.StartDatum;
            dtpEnddatum.Value = _Rezeptdaten.EndDatum;
            cbHäufigkeit.Text = _Rezeptdaten.Häufigkeit;
            cbSpzielleAnweisungen.Text = _Rezeptdaten.SpezielleAnweisungen;
        }


        private void _LoadRezepteByRezeptID()
        {
            _ResetDefautlValue();

            _Rezeptdaten = clsRezeptDaten.Find(_RezeptID);
            if (_Rezeptdaten != null)
            {
                MessageBox.Show("Rezept mit der RezeptID { " + _RezeptID + " } wurde nicht gefunden.",
                    "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRezeptID.Text = _Rezeptdaten.RezeptID.ToString();
            lblTerminID.Text = _Rezeptdaten.TerminID.ToString();

            lblVersicherungID.Text = _Rezeptdaten.VersicherungID.ToString();
            txtRezeptname.Text = _Rezeptdaten.RezeptName;

            if (_Rezeptdaten.Dosierung == string.Empty)
                txtDosierung.Text = string.Empty;
            else
                txtDosierung.Text = _Rezeptdaten.Dosierung;

            dtpStartdatum.Value = _Rezeptdaten.StartDatum;
            dtpEnddatum.Value = _Rezeptdaten.EndDatum;
            cbHäufigkeit.Text = _Rezeptdaten.Häufigkeit;
            cbSpzielleAnweisungen.Text = _Rezeptdaten.SpezielleAnweisungen;
        }

        private void _ResetDefautlValue()
        {
            lblRezeptID.Text = "[???]";
            lblTerminID.Text = "[???]";
            lblVersicherungID.Text = "[???]";
            txtRezeptname.Text = string.Empty;
            txtDosierung.Text = string.Empty;
            dtpStartdatum.Value = DateTime.Now;
            dtpEnddatum.Value = DateTime.Now;
            cbHäufigkeit.SelectedIndex = 0;
            cbSpzielleAnweisungen.SelectedIndex = 0;
        }

        private void _FillRezeptDaten()
        {
            _Rezeptdaten.TerminID = int.Parse(lblTerminID.Text);
            _Rezeptdaten.VersicherungID = int.Parse(lblVersicherungID.Text);
            _Rezeptdaten.RezeptName = txtRezeptname.Text;

            if (!string.IsNullOrEmpty(txtDosierung.Text))
                _Rezeptdaten.Dosierung = txtDosierung.Text;
            else
                _Rezeptdaten.Dosierung = string.Empty;

            _Rezeptdaten.StartDatum = dtpStartdatum.Value;
            _Rezeptdaten.EndDatum =dtpEnddatum.Value;
            _Rezeptdaten.Häufigkeit = cbHäufigkeit.SelectedItem as string;
            _Rezeptdaten.SpezielleAnweisungen = cbSpzielleAnweisungen.SelectedItem as string;
        }

        private void txtRezeptname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRezeptname.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRezeptname, "Das Feld darf nicht leer sein");
            }
            else
                errorProvider1.SetError(txtRezeptname, null);
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            _DatenSpeichern();

        }

        private void _DatenSpeichern()
        {
            if (!ValidateChildren())
                return;

            _FillRezeptDaten();


            if (Mode == enMode.UpdateByRezeptID || Mode == enMode.UpdateByTerminID)
            {
                if (_Rezeptdaten.Save())
                {
                    MessageBox.Show("Rezeptdaten wurden erfolgreich aktualisiert.", "Erflog",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Fehler beim Aktualisieren der Rezeptdaten ist aufgetreten.\n" +
                        "Bitte versuchen Sie noch ein mal.", "Fehlermeldung",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (HatDiesenTerminEinRezpet())
                    return;

                if (_Rezeptdaten.Save())
                {
                    lblRezeptID.Text = _Rezeptdaten.RezeptID.ToString();
                    MessageBox.Show("Rezeptdaten wurden erfolgreich gespeichert.", "Erflog",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // das Event auslösen.
                    SendDataback(_Rezeptdaten.RezeptID);

                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Fehler beim Speichern der Rezeptdaten ist aufgetreten.\n" +
                        "Bitte versuchen Sie noch ein mal.", "Fehlermeldung",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private bool HatDiesenTerminEinRezpet()
        {
            if (clsRezeptDaten.DoesHaveAppointmentRezept(_TerminID))
            {
                MessageBox.Show("Dieser Termin hat breits ein Rezept", "Fehlermeldung",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
