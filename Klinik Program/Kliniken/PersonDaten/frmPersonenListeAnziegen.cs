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
    public partial class frmPersonenListeAnziegen : Form
    {
        DataTable _dtPersonen;
        private int _Zähler = 1;
        public frmPersonenListeAnziegen()
        {
            InitializeComponent();
        }

        private void frmPersonenListeAnziegen_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;

            _LoadPersonenDataFromDatabase();

            _DataGridViewEinrichten();
        }

        private void _DataGridViewEinrichten()
        {
            if (dgvPerson.Rows.Count > 0)
            {
                dgvPerson.Columns[0].HeaderText = "PersonID";
                dgvPerson.Columns[0].Width = 100;

                dgvPerson.Columns[1].HeaderText = "AusweisID";
                dgvPerson.Columns[1].Width =  150;

                dgvPerson.Columns[2].HeaderText = "Vorname";
                dgvPerson.Columns[2].Width = 200;

                dgvPerson.Columns[3].HeaderText = "Nachname";
                dgvPerson.Columns[3].Width = 200;

                dgvPerson.Columns[4].HeaderText = "GeburstTag";
                dgvPerson.Columns[4].Width =  150;

                dgvPerson.Columns[5].HeaderText = "RegistrierungsDatum";
                dgvPerson.Columns[5].Width =  200;

                dgvPerson.Columns[6].HeaderText = "Geschlecht";
                dgvPerson.Columns[6].Width =  120;

                dgvPerson.Columns[7].HeaderText = "LandName";
                dgvPerson.Columns[7].Width = 150;

                dgvPerson.Columns[8].HeaderText = "Stadt";
                dgvPerson.Columns[8].Width = 150;

                dgvPerson.Columns[9].HeaderText = "Postleitzahl";
                dgvPerson.Columns[9].Width = 150;

                dgvPerson.Columns[10].HeaderText = "Straße";
                dgvPerson.Columns[10].Width =  150;

                dgvPerson.Columns[11].HeaderText = "Hausnummer";
                dgvPerson.Columns[11].Width =  150;

                dgvPerson.Columns[12].HeaderText = "Email";
                dgvPerson.Columns[12].Width =  250;

                dgvPerson.Columns[13].HeaderText = "Telefon";
                dgvPerson.Columns[13].Width =  150;

                dgvPerson.Columns[14].HeaderText = "FotoPfad";
                dgvPerson.Columns[14].Width =  250;
            }
        }
        private void _LoadPersonenDataFromDatabase()
        {

            _dtPersonen = clsPersonDaten.GetPersonenProSeite(100, (int)upDownPersonenSeite.Value);
            dgvPerson.DataSource = _dtPersonen;
            lblRecord.Text = dgvPerson.Rows.Count.ToString();
        }
        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterWert.Visible = (cbFilterBei.Text != "Keine");
            if(cbFilterBei.Text != "Keine")
            {
                txtFilterWert.Focus();
                txtFilterWert.Text = "";
            }
        }

        private void txtFilterWert_TextChanged(object sender, EventArgs e)
        {
            string FilterSpalte = "";

            switch(cbFilterBei.Text)
            {
                case "PersonID":
                    FilterSpalte = "PersonID";
                    break;

                case "AusweisID":
                    FilterSpalte = "AusweisID";
                    break;

                case "Vorname":
                    FilterSpalte = "Vorname";
                    break;

                case "Nachname":
                    FilterSpalte = "Nachname";
                    break;

                case "Stadt":
                    FilterSpalte = "Stadt";
                    break;

                case "Postleitzahl":
                    FilterSpalte = "Postleitzahl";
                    break;

                case "Straße":
                    FilterSpalte = "Straße";
                    break;

                case "Geschlecht":
                    FilterSpalte = "Geschlecht";
                    break;

                default:
                    FilterSpalte = "Keine";
                    break;
            }

            if(txtFilterWert.Text.Trim() == "" || FilterSpalte == "Keine")
            {
                _dtPersonen.DefaultView.RowFilter = "";
                lblRecord.Text = dgvPerson.Rows.Count.ToString();
                return;
            }

            if(FilterSpalte == "PersonID")
            {
                _dtPersonen.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterSpalte, txtFilterWert.Text.Trim());
                lblRecord.Text = dgvPerson.Rows.Count.ToString();
            }
            else
            {
                _dtPersonen.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterSpalte, txtFilterWert.Text.Trim());
                lblRecord.Text = dgvPerson.Rows.Count.ToString();
            }
        }

        private void btnPersonHinzufügen_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuePersonHinzufügen frm = new frmAktualisierenUndNeuePersonHinzufügen();
            frm.ShowDialog();

            frmPersonenListeAnziegen_Load(null, null);
        }

        private void personDatenAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPerson.CurrentRow.Cells[0].Value;
            frmPersonDatenAnzeigen frm = new frmPersonDatenAnzeigen(PersonID);
            frm.ShowDialog();

        }

        private void personDatenAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPerson.CurrentRow.Cells[0].Value;
            frmAktualisierenUndNeuePersonHinzufügen frm = new frmAktualisierenUndNeuePersonHinzufügen(PersonID);
            frm.ShowDialog();

            frmPersonenListeAnziegen_Load(null, null);
        }

        private void personDatenLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPerson.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Sind Sie sicher,Sie möchten die Person Daten mit der ID = " +
              PersonID + " löschen", "Vorwarnung", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) 
                == DialogResult.Cancel)
            {
                return;
            }

            if(clsPersonDaten.Delete(PersonID))
            {
                MessageBox.Show("Person Daten wurden vom System erfolgreich gelöscht", "Erfolg",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPersonenListeAnziegen_Load(null, null);
            }
            else
                MessageBox.Show("Fehler beim Löschen dieser Person ist aufgetreten", "Fehler Meldung",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void personZuPatientAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPerson.CurrentRow.Cells[0].Value;

            frmUpdateUndNeuPatientHinzufügen frm = new frmUpdateUndNeuPatientHinzufügen(PersonID);
            frm.ShowDialog();
        }

        private void txtFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBei.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      
        private void personZuArztAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPerson.CurrentRow.Cells[0].Value;
            frmAktualisierenUndNeueArztHinzufügen frm = new frmAktualisierenUndNeueArztHinzufügen(-1,PersonID);
            frm.ShowDialog();
        }

        private void upDownPersonenSeite_ValueChanged(object sender, EventArgs e)
        {
            _LoadPersonenDataFromDatabase();
        }

    }
}
