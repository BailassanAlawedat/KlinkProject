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
    public partial class frmPatientDatenAnzeigen : Form
    {
        private int  _patientID = -1;
        public frmPatientDatenAnzeigen(int PatientID)
        {
            InitializeComponent();
            _patientID = PatientID;
        }

        private void frmPatientDatenAnzeigen_Load(object sender, EventArgs e)
        {
            _LoadPatientenDaten();
        }

        private void _LoadPatientenDaten()
        {
            clsPatientDaten patientDaten = clsPatientDaten.Find(_patientID);
            if(patientDaten == null)
            {
                MessageBox.Show("keiner Patient für diesen Namen wrude im system gefunden",
                    "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblPatientID.Text = patientDaten.PatientID.ToString();
            ctrPersonDaten1.LoadPersonData(patientDaten.PersonID);
        }
    }
}
