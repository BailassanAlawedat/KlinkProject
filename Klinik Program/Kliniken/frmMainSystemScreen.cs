using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmMainSystemScreen : Form
    {
        frmLoginScreen _frmLoginScreen;
        public frmMainSystemScreen(frmLoginScreen frmloginScreen)
        {
            InitializeComponent();

            _frmLoginScreen = frmloginScreen;
        }
        private void fachrichtungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFachrichtungenListeAnzeigen frm = new frmFachrichtungenListeAnzeigen();
            frm.ShowDialog();
        }

        private void ärzteListeAnziegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÄrzteListeAnzeigen frm = new frmÄrzteListeAnzeigen();
            frm.ShowDialog();
        }

        private void frmMainSystemScreen_Load(object sender, EventArgs e)
        {

        }

        private void benutzerListeAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBenutzerListeAnzeigen frm = new frmBenutzerListeAnzeigen();
            frm.ShowDialog();
        }

        private void neuenBenutzerHinzufügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuenBenutzerHinzufügen frm = new frmAktualisierenUndNeuenBenutzerHinzufügen();
            frm.ShowDialog();
        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobaleKlasse.BenutzerDaten = null;
            this.Close();
            _frmLoginScreen.Show();
        }

        private void neuenArztHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeueArztHinzufügen frm = new frmAktualisierenUndNeueArztHinzufügen();
            frm.ShowDialog();
        }

        private void frmMainSystemScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsGlobaleKlasse.BenutzerDaten = null;
            this.Close();
            _frmLoginScreen.Show();
        }

        private void aktuellenBenutzerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsBenutzerDaten benutzerDaten = clsGlobaleKlasse.BenutzerDaten;

            frmBenutzerDatenAnzeigen frm = new frmBenutzerDatenAnzeigen((int)benutzerDaten.PersonID);
            frm.ShowDialog();
        }

        private void patientenListeAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientListeAnzeigen frm = new frmPatientListeAnzeigen();
            frm.ShowDialog();
        }

        private void neuenPatientenHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateUndNeuPatientHinzufügen frm = new frmUpdateUndNeuPatientHinzufügen();
            frm.ShowDialog();
        }

        private void neuePersonHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuePersonHinzufügen frm = new frmAktualisierenUndNeuePersonHinzufügen();
            frm.ShowDialog();
        }

        private void passwortÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPasswortÄndern frm = new frmPasswortÄndern();
            frm.ShowDialog();
        }

        private void PersonenListeAnzeigentoolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmPersonenListeAnziegen frm = new frmPersonenListeAnziegen();
            frm.ShowDialog();
        }

        private void AlsReinigungsPersonlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode mode = frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode.AddNew;
            frmAktualisierenUndNeuenMitarbeiterHinzufügen.enAbteilung abteilung = frmAktualisierenUndNeuenMitarbeiterHinzufügen.enAbteilung.ReinigungsPersonal;

            frmAktualisierenUndNeuenMitarbeiterHinzufügen frm =
             new frmAktualisierenUndNeuenMitarbeiterHinzufügen(mode, abteilung);

            frm.ShowDialog();
        }

        private void alsKüchenPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode mode = frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode.AddNew;
            frmAktualisierenUndNeuenMitarbeiterHinzufügen.enAbteilung abteilung = frmAktualisierenUndNeuenMitarbeiterHinzufügen.enAbteilung.KüchenPersonal;

            frmAktualisierenUndNeuenMitarbeiterHinzufügen frm =
            new frmAktualisierenUndNeuenMitarbeiterHinzufügen(mode, abteilung);

            frm.ShowDialog();
        }

        private void alsTransportdienstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode mode = frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode.AddNew;
            frmAktualisierenUndNeuenMitarbeiterHinzufügen.enAbteilung abteilung = frmAktualisierenUndNeuenMitarbeiterHinzufügen.enAbteilung.Transportdienst;

            frmAktualisierenUndNeuenMitarbeiterHinzufügen frm =
            new frmAktualisierenUndNeuenMitarbeiterHinzufügen(mode, abteilung);

            frm.ShowDialog();
        }

        private void alsSicherheitsdienstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode mode = frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode.AddNew;
            frmAktualisierenUndNeuenMitarbeiterHinzufügen.enAbteilung abteilung = frmAktualisierenUndNeuenMitarbeiterHinzufügen.enAbteilung.Sicherheitsdienst;

            frmAktualisierenUndNeuenMitarbeiterHinzufügen frm =
            new frmAktualisierenUndNeuenMitarbeiterHinzufügen(mode, abteilung);

            frm.ShowDialog();
        }

        private void MitarbeiterlistetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMitarbeiterListeAnzeigen frm = new frmMitarbeiterListeAnzeigen();
            frm.ShowDialog();
        }
    }
}
