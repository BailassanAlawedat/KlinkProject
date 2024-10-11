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
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            string username = txtbBenutzername.Text.Trim();
            string password = txtbPassword.Text.Trim();
            clsBenutzerDaten benutzerDaten = clsBenutzerDaten.FindUserByUserRolleAndPassword(username, password);

            if(benutzerDaten != null)
            {
                if (cbDatenSpeichern.Checked)
                    clsGlobaleKlasse.SaveUsernameAndPasswordInRegistry(username, password, cbDatenSpeichern.Checked);
                 

                if(!benutzerDaten.IstAktive)
                {
                    //falls der benutzer nicht aktive ist
                    txtbBenutzername.Focus();
                    MessageBox.Show("Ihre Anmeldedaten sind nicht mehr Aktive, Kontaktieren Sie Ihren Admin",
                                  "Anmeldedaten", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobaleKlasse.BenutzerDaten = benutzerDaten;
                clsGlobaleKlasse.BenutzerDaten.UpdateLetzterLogin();
                this.Hide();
                frmMainSystemScreen frm = new frmMainSystemScreen(this);
                frm.ShowDialog();
            }
            else
            {
                txtbBenutzername.Focus();
                MessageBox.Show("Ungültige AnmeldeDaten", "Fehler beim Anmelden",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                clsEventLogInWindows.LogEvent(clsEventLogInWindows.enEventLogInformation.Fehler,
                    "Fehler beim Anmelden");
            }
            
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string username = string.Empty; string passwort = string.Empty;

            if (clsGlobaleKlasse.GetUsernameAndPasswordFromRegistry(ref username, ref passwort))
            {
                txtbBenutzername.Text = username;
                txtbPassword.Text = passwort;
                cbDatenSpeichern.Checked = true;
            }
            else
                cbDatenSpeichern.Checked = false;
        }
    }
}
