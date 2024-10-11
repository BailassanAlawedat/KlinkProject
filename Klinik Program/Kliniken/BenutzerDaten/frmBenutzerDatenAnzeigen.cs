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
    public partial class frmBenutzerDatenAnzeigen : Form
    {
        int _PersonID = -1;
        public frmBenutzerDatenAnzeigen(int PersonId)
        {
            InitializeComponent();
            _PersonID = PersonId;
        }

        private void frmBenutzerDatenAnzeigen_Load(object sender, EventArgs e)
        {

            ctrPersonDaten1.LoadPersonData(_PersonID);
            _LoadBenutzerData();
        }

        private void _LoadBenutzerData()
        {
            clsBenutzerDaten benutzerDaten = clsBenutzerDaten.FindUserByPersonID(_PersonID);
            if(benutzerDaten == null)
            {
                MessageBox.Show("Kein Benutzer wurde für diese Person gefunden", "Fehlermeldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRollenname.Text = benutzerDaten.Rollenname;
            lblIstAktive.Text = (benutzerDaten.IstAktive == true) ? "Ja" : "Nein";
            lblLetzterLogin.Text = benutzerDaten.LetzterLogin.ToString();
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
