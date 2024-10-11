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
    public partial class ctrPersonFilter : UserControl
    {
        public event Action<int> OnSelectedPersonID;
        protected virtual void SelectedPersonID(int PersonID)
        {
            OnSelectedPersonID?.Invoke(PersonID);
        }

        private clsPersonDaten _PersonInfo;
        public clsPersonDaten SelectedPersonInfo
        {
            get { return _PersonInfo; }
        }
        private int _PersonID = -1;
        public ctrPersonFilter()
        {
            InitializeComponent();
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set { _FilterEnabled = value;
                gbPersonFilter.Enabled = _FilterEnabled;
                }
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

        }

        public void EingebeFeldSelected()
        {
            txtbFilterWert.Select();
        }
        private void btnPersonSuchen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbFilterWert.Text.Trim()))
            {
                MessageBox.Show("Bitte geben Sie daten im Suchfeld ein.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtbFilterWert.Focus();
                return;
            }

            string FilterBy = cbFilterBei.SelectedItem as string;
            int personID = int.Parse(txtbFilterWert.Text.Trim());
            switch (FilterBy)
            {
                case "PersonID":
                    {
                        bool ExistByPersonID = clsPersonDaten.IsPersonExist(personID);
                        if (ExistByPersonID)
                        {
                            if (OnSelectedPersonID != null)
                            {
                                SelectedPersonID(personID);
                            }
                        }
                        break;
                    }

                case "AusweisID":
                    {
                        bool ExistByAusweisID = clsPersonDaten.IsPersonExist(txtbFilterWert.Text.Trim());
                        if(ExistByAusweisID)
                        {
                            //wir suchen nach personid durch AusweisId.
                            int PersonID = clsPersonDaten.Find(txtbFilterWert.Text.Trim()).PersonID;
                            if (OnSelectedPersonID != null)
                            {
                                SelectedPersonID(personID);
                            }
                        }
                        break;
                    }

                case "Email":
                    {
                        bool ExistByEmail = clsPersonDaten.IsPersonExistByEmailAdresse(txtbFilterWert.Text.Trim());
                        if(ExistByEmail)
                        {
                            int PersonID = clsPersonDaten.FindByEmailAddresse(txtbFilterWert.Text.Trim()).PersonID;
                            if (OnSelectedPersonID != null)
                            {
                                SelectedPersonID(personID); // personid freigeben.
                            }
                        }
                        break;
                    }

                default:
                    {
                        bool ExistByPersonID = clsPersonDaten.IsPersonExist(personID);
                        if (ExistByPersonID)
                        {
                            if (OnSelectedPersonID != null)
                            {
                                SelectedPersonID(personID);
                            }
                        }
                        break;
                    }
            }
        }

           
        private void txtbFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBei.Text.Trim() == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            // Wir überprüfen, ob gedrückte Taste Enter ist....
            if (e.KeyChar == (char)13)
                btnPersonSuchen.PerformClick();
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbFilterWert.Clear();
            txtbFilterWert.Select();
        }

        public void txtFilterWertSetzen(int  PersonID)
        {
            txtbFilterWert.Text = PersonID.ToString();
            if (OnSelectedPersonID != null)
            {
                SelectedPersonID(PersonID);
            }
        }

        private void ctrPersonFilter_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;
        }
    }
}
