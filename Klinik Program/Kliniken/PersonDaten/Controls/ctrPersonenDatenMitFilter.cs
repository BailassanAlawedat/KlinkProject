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
    public partial class ctrPersonenDatenMitFilter : UserControl
    {
        //define a  custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;

        // Erstelle eine geschützte Methode, um das Ereignis mit einem Parameter auszulösen.
        protected virtual void PersonSelected(int PersonID)
        {
            // Überprüfe, ob es Abonnenten des Ereignisses gibt, und löse das Ereignis aus.
            OnPersonSelected?.Invoke(PersonID);
        }

        public clsPersonDaten SelectedPersonInfo
        {
            get { return ctrPersonDaten1.SelectedPersonInfo; }
        }

        private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrPersonDaten1.PersonID; }
        }

        private  bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbPersonenFilter.Enabled = _FilterEnabled; 
            }
        }
        public ctrPersonenDatenMitFilter()
        {
            InitializeComponent();
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbFilterWert.Clear();
            txtbFilterWert.Focus();
        }

        private void txtbFilterWert_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnPersonSuchen_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtbFilterWert.Text.Trim()))
            {
                MessageBox.Show("Bitte geben Sie daten im Suchfeld ein.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtbFilterWert.Focus();
                return;
            }
            _LoadPersonInfo();
        }

        private void _LoadPersonInfo()
        {

            switch(cbFilterBei.Text.Trim())
            {
                case "PersonID":
                    ctrPersonDaten1.LoadPersonData(int.Parse(txtbFilterWert.Text.Trim()));
                    break;

                case "AusweisID":
                    ctrPersonDaten1.LoadPersonDataByAusweisID(txtbFilterWert.Text.Trim());
                    break;

                case "Email":
                    ctrPersonDaten1.LoadPersonDataByEmail(txtbFilterWert.Text.Trim());
                    break;            
            }
            // Überprüfe, ob es Abonnenten des Ereignisses gibt, und löse das Ereignis aus.
            PersonSelected(ctrPersonDaten1.PersonID);
        }

        public void LoadPersonInfoByPersonID(int PersonID)
        {
            ctrPersonDaten1.LoadPersonData(PersonID);
            txtbFilterWert.Text = PersonID.ToString();
            PersonSelected(ctrPersonDaten1.PersonID);
        }

        private void txtbFilterWert_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (cbFilterBei.Text.Trim() == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            // Wir überprüfen, ob gedrückte Taste Enter ist....
            if (e.KeyChar == (char)13)
                btnPersonSuchen.PerformClick();
        
        }
        private void ctrPersonenFilter_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = cbFilterBei.FindString("PersonID");
        }

        private void btnNeuePersonHinzufügen_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuePersonHinzufügen frm = new frmAktualisierenUndNeuePersonHinzufügen();
            frm.DataBack += _GetDateBack;
            frm.ShowDialog();
        }

        private void _GetDateBack(object sender, int PersonID)
        {
            _PersonID = PersonID;
            cbFilterBei.SelectedIndex = cbFilterBei.FindString("PersonID");
            txtbFilterWert.Text = _PersonID.ToString();

            _LoadPersonInfo();
        }

        public void EingebeFeldSelected()
        {
            txtbFilterWert.Select();
        }
    }
}
