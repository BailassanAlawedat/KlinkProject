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
    public partial class frmDatumListeForPatientenAnzeigen : Form
    {
        private int _PatientID = -1;
        private string _Patientname = string.Empty;
        private string _Geburtsdatum = string.Empty;
        public frmDatumListeForPatientenAnzeigen(int patientID, string Patientname,string geburtsdatum)
        {
            InitializeComponent();
            _PatientID = patientID;
            _Patientname = Patientname;
            _Geburtsdatum = geburtsdatum;
        }

        private void frmDatumListeForPatientenAnzeigen_Load(object sender, EventArgs e)
        {
            _LoadDatumListe();
        }

        private void _LoadDatumListe()
        {
            lblPatientName.Text = _Patientname;
            lblGeburtstag.Text = _Geburtsdatum;

            List<clsTerminDaten> termindaten = clsTerminDaten.GetTermiListByPatientID(_PatientID);

            // Sicherstellen, dass die Liste DatumListe existiert und geleert wird
            DatumListe.Items.Clear();

            foreach(var termin in termindaten)
            {
                string DatumString = $"Datum: {termin.datum.ToString("dd.MM.yyyy")}   -   Uhrzeit: {termin.zeit}" +
                    $"\t==> Terminstatus: {(termin.TerminStatus == false ? "  Nicht Erledigt" : "  Erledigt")}\n";
                DatumListe.Items.Add(DatumString);
            }
        }


    }
}
