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
using clsHilfsMethoden;
using System.Runtime.InteropServices;

namespace Kliniken
{
    public partial class frmAktualisierenUndNeuePersonHinzufügen : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        private enum enMode { Addnew = 0, Update = 1 }
        private enMode _Mode = enMode.Addnew;

        private int _PersonID = -1;
        
        public frmAktualisierenUndNeuePersonHinzufügen()
        {
            InitializeComponent();

            _Mode = enMode.Addnew;
            lblTitel.Text = "Neue Person hinzufügen";
        }
        public frmAktualisierenUndNeuePersonHinzufügen(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;
            lblTitel.Text = "Person Daten aktualisieren";
        }
        private void frmNeuePersonHinzufügen_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                ctrNeuPersonHinzufügen1.ResetDefaulValue(false);
                ctrNeuPersonHinzufügen1.LoadPersonData(_PersonID);
            }
            else
                ctrNeuPersonHinzufügen1.ResetDefaulValue(true);

            if (_PersonID != -1)
                lblPersonID.Text = _PersonID.ToString();
        }

        private void btnDatenSpeichern_Click(object sender, EventArgs e)
        {
            if (!ctrNeuPersonHinzufügen1._IsTextBoxesVollWithData())
            {
                MessageBox.Show("Leere Felder müssen ausgefüllt werden", "Fehler Meldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Mode == enMode.Addnew)
            {
                if (ctrNeuPersonHinzufügen1.SaveData())
                {
                    MessageBox.Show("Person Daten wurde erfolgreich hinzugefügt", "Erfolg",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBack?.Invoke(this, _PersonID);
                    this.Close();
                }
                else
                    MessageBox.Show("Fehler beim Hinzufügen der Daten ist aufgetreten\n" +
                        "Bitte versuchen Sie es erneut", "Fehler Meldung",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if(ctrNeuPersonHinzufügen1.SaveData())
                {
                    MessageBox.Show("Person Daten wurde erfolgreich aktualisiert", "Erfolg",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Fehler beim Aktualisieren der Daten ist aufgetreten\n" +
                      "Bitte versuchen Sie es erneut", "Fehler Meldung",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrNeuPersonHinzufügen1_OnPersonSelected(int obj)
        {     
            
            _PersonID = obj; 
            lblPersonID.Text = _PersonID.ToString();
            
        }

    }
}

