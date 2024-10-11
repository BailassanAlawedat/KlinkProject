using clsHilfsMethoden;
using Kliniken.Properties;
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
    public partial class ctrPersonDaten : UserControl
    {
        clsPersonDaten _Personen;
        int _PersonID = -1;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPersonDaten SelectedPersonInfo
        {
            get { return _Personen; }
        }
        public ctrPersonDaten()
        {
            InitializeComponent();
        }

        private void ctrPersonDaten_Load(object sender, EventArgs e)
        {
           
           
        }

        public void LoadPersonData(int PersonID)
        {
            _ResetDefaultValue();

            _Personen = clsPersonDaten.Find(PersonID);
            if(_Personen == null)
            {
                MessageBox.Show("Person mit der ID [ " + PersonID + " ] wurde nicht gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = _Personen.PersonID;
            _FillPersonData();
        }

        public void LoadPersonDataByAusweisID(string AusweisID)
        {
            _ResetDefaultValue();

            _Personen = clsPersonDaten.Find(AusweisID);
            if (_Personen == null)
            {
                MessageBox.Show("Person mit der AusweisID [ " + AusweisID + " ] wurde nicht gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = _Personen.PersonID;
            _FillPersonData();
        }

        public void LoadPersonDataByEmail(string Email)
        {
            _ResetDefaultValue();

            _Personen = clsPersonDaten.FindByEmailAddresse(Email);
            if (_Personen == null)
            {
                MessageBox.Show("Person mit der Email [ " + Email + " ] wurde nicht gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = _Personen.PersonID;
            _FillPersonData();
        }
        private void _FillPersonData()
        {
            lblPersonID.Text = _Personen.PersonID.ToString();
            lblAusweisID.Text = _Personen.AusweisID;
            lblVollname.Text = _Personen.Vollname;
            lblGeburtstag.Text = clsDatumFormat.DateToShort( _Personen.GeburtsTag);
            lblRegistrierungsDatum.Text = clsDatumFormat.DateToShort(_Personen.RegistrierungsDatum);
            lblGeschlecht.Text = (_Personen.Geschlecht == 0) ? "Maenlich" : "Weiblich";
            lblLandName.Text = _Personen.LandsDaten.LandName;
            lblStadt.Text = _Personen.Stadt;
            lblPostleitzahl.Text = _Personen.Postleitzahl;
            lblStraße.Text = _Personen.Straße;
            lblTelefon.Text = _Personen.TelefonNummer;
            lblEmail.Text =  _Personen.Email;
            if(string.IsNullOrEmpty(_Personen.FotoPfad))
            {
                if (_Personen.Geschlecht == 0)
                    pictureBox1.Image = Resources.Male_512;
                else
                    pictureBox1.Image = Resources.Female_512;
            }
            else
                pictureBox1.ImageLocation = _Personen.FotoPfad;
        }
        private void _ResetDefaultValue()
        {
            lblPersonID.Text = "[???]";
            lblAusweisID.Text = "[???]";
            lblVollname.Text = "[?????]";
            lblGeburtstag.Text = "[??\\??\\????]";
            lblRegistrierungsDatum.Text = "[??\\??\\????]";
            lblGeschlecht.Text = "[???]";
            lblLandName.Text = "[???]";
            lblStadt.Text = "[???]";
            lblPostleitzahl.Text = "[???]";
            lblStraße.Text = "[???]";
            lblTelefon.Text = "[???]";
            lblEmail.Text = "[??????]";
            pictureBox1.Image = Resources.Male_512 ;
        }

      
    }
}
