using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmFachrictungHinzufügenOderAkualisieren : Form
    {
        public delegate void DatabackEventHandler(object sender, string item);
        public event DatabackEventHandler Databack;
        private enum enMode { Addnew = 0, Update = 1 }
        private enMode _Mode = enMode.Addnew;

        private int _FachrichtungsID = -1;
        private clsFachrichtungenDaten _Fachrichtung;

        
             
        public frmFachrictungHinzufügenOderAkualisieren(int FachrichtungsID) 
        {
            InitializeComponent();
            _FachrichtungsID = FachrichtungsID;
            _Mode = enMode.Update;

            _LoadFachichungenData();
        }
        public frmFachrictungHinzufügenOderAkualisieren()
        {
            InitializeComponent();

            _Mode = enMode.Addnew;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            switch(_Mode)
            {
                case enMode.Addnew:
                    {
                        if (clsFachrichtungenDaten.DoesProfissionExist(txtFachrichtung.Text.Trim()))
                        {
                            MessageBox.Show("Diese Fachrichtung existiert schon in der Tabelle", "Fehler Meldung",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }

                         _Fachrichtung = new clsFachrichtungenDaten();

                        _Fachrichtung.FachrichtungsName = txtFachrichtung.Text.Trim();
                        if(_Fachrichtung.Save())
                        {
                            MessageBox.Show("Die Fachrichtung wurde erfolgreich gespeichert", "Erfolg",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblFachrichtungID.Text = _Fachrichtung.FachrichtungsID.ToString();

                            return;
                        }
                        else
                            MessageBox.Show("Die Fachrichtung wurde nicht erfolgreich gespeichert", "Fehler Meldung",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case enMode.Update:
                    {
                        _Fachrichtung.FachrichtungsName = txtFachrichtung.Text.Trim();
                        if(_Fachrichtung.Save())
                        {
                            MessageBox.Show("Die Fachrichtung wurde erfolgreich aktualisiert", "Erfolg",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Databack?.Invoke(this, _Fachrichtung.FachrichtungsName);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Die Fachrichtung wurde nicht erfolgreich aktualisiert.", "Fehler Meldung",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                    }
            }   
            
        }

        private void _LoadFachichungenData()
        {
            _Fachrichtung = clsFachrichtungenDaten.Find(_FachrichtungsID);
            if (_Fachrichtung != null)
            {
                lblFachrichtungID.Text = _Fachrichtung.FachrichtungsID.ToString();
                txtFachrichtung.Text =_Fachrichtung.FachrichtungsName;
                lblTitel.Text = "Fachrichtung Aktualisieren";
                btnHinzufügen.Text ="Aktualisieren";
            }
            else
                MessageBox.Show("Farichtung mit der ID " + _FachrichtungsID + " wurde nicht gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
