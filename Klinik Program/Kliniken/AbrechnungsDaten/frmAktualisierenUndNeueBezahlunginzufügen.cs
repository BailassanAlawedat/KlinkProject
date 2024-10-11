using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmAktualisierenUndNeueBezahlungHinzufügen : Form
    {
        public delegate void  GetDataBack(object sender, int ID);
        public event GetDataBack _DataBack;
        private enum enMode { addNew = 0, Update = 1}
        enMode _Mode = enMode.addNew;
        private int _BezahlungsID = -1;
        clsBezahlungDaten _Bezahlung;
        public frmAktualisierenUndNeueBezahlungHinzufügen()
        {
            InitializeComponent();
            lblTitel.Text = "Neue Bezahlung hinzufügen";
            _Mode = enMode.addNew;
        }

        public frmAktualisierenUndNeueBezahlungHinzufügen(int BezahlungsID)
        {
            InitializeComponent();
            lblTitel.Text = "Bezahlung aktualisieren";
            _Mode = enMode.Update;
            _BezahlungsID = BezahlungsID;
        }

        private void frmAktualisierenUndNeuenTerminHinzufügen_Load(object sender, EventArgs e)
        {
            cbBezahlungsMethode.SelectedIndex = 1;
        }

        private void lblAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSpeichern_Click(object sender, EventArgs e)
        {
            if(_IsTextBoxEmpty())
            {
                return;
            }

            switch(_Mode)
            {
                case enMode.addNew:
                    _Bezahlung = new clsBezahlungDaten();

                    _Bezahlung.BezahlungsMethode = cbBezahlungsMethode.Text;
                    _Bezahlung.BezahlungsDatum = dtpBezahlungsDatum.Value;
                    _Bezahlung.BetragZumBezahlen = Convert.ToSingle(txtBezahlungsBetrag.Text);

                    if(_Bezahlung.Save())
                    {
                        lblBezahlungsID.Text = _Bezahlung.BezahlungsID.ToString();
                        _Mode = enMode.Update;
                        _DataBack.Invoke(this, _Bezahlung.BezahlungsID);

                        MessageBox.Show("Bezahlung Daten wurden erfolgreich gespeichert", "Erfolg",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Fehler beim Speichern ist aufgetreten", "Fehler Meldung",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                case enMode.Update:

                    _Bezahlung = clsBezahlungDaten.Find(_BezahlungsID);
                    if(_Bezahlung == null)
                    {
                        MessageBox.Show("Bezahlung Daten mit der ID " + _BezahlungsID + " wurden nicht gefunden",
                            "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    lblBezahlungsID.Text = _Bezahlung.BezahlungsID.ToString();
                    cbBezahlungsMethode.Text = _Bezahlung.BezahlungsMethode;
                    dtpBezahlungsDatum.Value = _Bezahlung.BezahlungsDatum;
                    txtBezahlungsBetrag.Text = _Bezahlung.BetragZumBezahlen.ToString();

                    if (_Bezahlung.Save())
                    {
                        lblBezahlungsID.Text = _Bezahlung.BezahlungsID.ToString();
                        _Mode = enMode.Update;
                        MessageBox.Show("Bezahlung Daten wurden erfolgreich aktualisiert", "Erfolg",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Fehler beim Aktualisieren ist aufgetreten", "Fehler Meldung",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



            }
        }


        private bool _IsTextBoxEmpty()
        {
            if (string.IsNullOrEmpty(txtBezahlungsBetrag.Text))
            {
                errorProvider1.SetError(txtBezahlungsBetrag, "Das Feld darf nicht leer sein.");
                return true;
            }
            else
            {
                errorProvider1.SetError(txtBezahlungsBetrag, null);
                return false;
            }
        }
        private void txtBezahlungsBetrag_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
