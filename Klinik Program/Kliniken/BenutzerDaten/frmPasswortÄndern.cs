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
    public partial class frmPasswortÄndern : Form
    {
     
        clsBenutzerDaten _Benutzerdaten;
        public frmPasswortÄndern()
        {
            InitializeComponent();

            _Benutzerdaten = clsGlobaleKlasse.BenutzerDaten;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPasswortÄndern_Load(object sender, EventArgs e)
        {
            _LoadBenutzerData();
            txtNeuesPasswort.Select();
        }

        private void _LoadBenutzerData()
        {
            txtBenutzername.Text = _Benutzerdaten.Rollenname;
            txtAltesPaasswort.Text =  _Benutzerdaten.BenutzerPasswort;
        }

        private void btnBestätigen_Click(object sender, EventArgs e)
        {
            if (!_ValidateFelder())
                return;

            _Benutzerdaten.BenutzerPasswort = txtNeuesPasswort.Text.Trim();
            if(_Benutzerdaten.UpdatePasswortByRollenname())
            {
                MessageBox.Show("Das Passwort wurde erfolgreich geändert", "Erfolg",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Fehler beim Ändern des Passworts ist aufgetreten \n" +
                    "Bitte versuchen Sie es noch einmal", "Fehlermeldung",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _ValidateFelder()
        {
            string neuesPasswort = txtNeuesPasswort.Text.Trim();
            string passwortBestätigen = txtPasswortBestätigung.Text.Trim();

            if(passwortBestätigen != neuesPasswort)
            {
                MessageBox.Show("PasswortBestätigen muss das neue Passwort entsprechen", "Fehlermeldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
