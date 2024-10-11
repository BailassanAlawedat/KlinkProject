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
    public partial class frmPatientListeAnzeigen : Form
    {
        DataTable _dtPatienten;
        public frmPatientListeAnzeigen()
        {
            InitializeComponent();
        }

        private void btnPatientHinzufügen_Click(object sender, EventArgs e)
        {
            frmUpdateUndNeuPatientHinzufügen frm = new frmUpdateUndNeuPatientHinzufügen();
            frm.ShowDialog();

            frmPatientListeAnzeigen_Load(null, null);
        }

        private void frmPatientListeAnzeigen_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;

            _dtPatienten = clsPatientDaten.GetAllPatients();
            dgvPatient.DataSource = _dtPatienten;
            lblRecord.Text = dgvPatient.Rows.Count.ToString();

            foreach (DataGridViewColumn spalte in dgvPatient.Columns)
            {
                dgvPatient.ColumnHeadersDefaultCellStyle.Font = new Font(dgvPatient.Font.FontFamily, 14, FontStyle.Bold);
            }

            if (dgvPatient.Rows.Count > 0)
            {
                dgvPatient.Columns[0].HeaderText = "PatientID";
                dgvPatient.Columns[0].Width = 100;

                dgvPatient.Columns[1].HeaderText = "PersonID";
                dgvPatient.Columns[1].Width =  100;

                dgvPatient.Columns[2].HeaderText = "Vollname";
                dgvPatient.Columns[2].Width = 200;

                dgvPatient.Columns[3].HeaderText = "AusweisID";
                dgvPatient.Columns[3].Width =  150;

                dgvPatient.Columns[4].HeaderText = "Geburtstag";
                dgvPatient.Columns[4].Width =  150;

                dgvPatient.Columns[5].HeaderText = "RegistrierungsDatum";
                dgvPatient.Columns[5].Width =  250;

                dgvPatient.Columns[6].HeaderText = "Email";
                dgvPatient.Columns[6].Width = 200;

                dgvPatient.Columns[7].HeaderText = "TelefonNummer";
                dgvPatient.Columns[7].Width = 150;

            }
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
            //wir ordnen die Namen in ComboBox zu den Namen in DatenBank
            switch(cbFilterBei.Text)
            {
                case "PatientID":
                    FilterSpalte = "PatientID";
                    break;

                case "PersonID":
                    FilterSpalte = "PersonID";
                    break;

                case "AusweisID":
                    FilterSpalte ="AusweisID";
                    break;

                case "Vollname":
                    FilterSpalte = "Vollname";
                    break;

                case "Email":
                    FilterSpalte = "Email";
                    break;

                default:
                    FilterSpalte = "Keine";
                    break;
            }

            if(FilterSpalte == "Keine" || txtFilterWert.Text.Trim() =="" )
            {
                _dtPatienten.DefaultView.RowFilter = "";
                lblRecord.Text = dgvPatient.Rows.Count.ToString();
                return;
            }

            if(FilterSpalte == "PatientID" ||FilterSpalte == "PersonID")
            {
                _dtPatienten.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterSpalte, txtFilterWert.Text.Trim());
            }
            else
            {
                _dtPatienten.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterSpalte, txtFilterWert.Text.Trim());
            }
            lblRecord.Text = dgvPatient.Rows.Count.ToString();
        }

        private void txtFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBei.Text == "PatientID" || cbFilterBei.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientDatenAnseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int patientID = (int)dgvPatient.CurrentRow.Cells[0].Value;

            frmPatientDatenAnzeigen frm = new frmPatientDatenAnzeigen(patientID);
            frm.ShowDialog();
        }

        private void patientDatenAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPatient.CurrentRow.Cells[1].Value;
            int PatientID = (int)dgvPatient.CurrentRow.Cells[0].Value;

            frmUpdateUndNeuPatientHinzufügen frm = new frmUpdateUndNeuPatientHinzufügen(PatientID, PersonID);
            frm.ShowDialog();

            frmPatientListeAnzeigen_Load(null, null);
        }

        private void patientDatenLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatient.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Sind Sie sicher,Sie möchten die Patient Daten mit der ID = " +
              PatientID + " löschen", "Vorwarnung", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                == DialogResult.Cancel)
            {
                return;
            }

            clsPatientDaten Patient = clsPatientDaten.Find(PatientID);
            if (Patient != null)
            {
                if (Patient.Delete())
                {
                    MessageBox.Show("Patient Daten wurden vom System erfolgreich gelöscht", "Erfolg",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmPatientListeAnzeigen_Load(null, null);
                }
                else
                    MessageBox.Show("Fehler beim Löschen dieser Patient ist aufgetreten", "Fehler Meldung",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Die Patient existiert nicht im System.", "Fehler Meldung",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tsmiTerminVereinbaren_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatient.CurrentRow.Cells[0].Value;
            frmAktualisierenUndNeuenTerminHinzufügen frm = new frmAktualisierenUndNeuenTerminHinzufügen(PatientID);
            frm.ShowDialog();
        }
        private void TerminListeAnzeigentoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatient.CurrentRow.Cells[0].Value;
            string Patientname = clsPatientDaten.Find(PatientID).Vollname;
            string Geburtsdatum = clsPatientDaten.Find(PatientID).GeburtsTag.ToString("dd.MM.yyyy");

            if (!clsTerminDaten.DoesHavePatientAppointment(PatientID))
            {
                DialogResult Result = MessageBox.Show("Dieser Patient hat noch keine Termine im System\n" +
                    "Möschen Sie ihm einen Termin vergeben ? ", "Infos",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    frmAktualisierenUndNeuenTerminHinzufügen frm = new frmAktualisierenUndNeuenTerminHinzufügen(PatientID);
                    frm.ShowDialog();
                }

            }
            else
            {
                frmDatumListeForPatientenAnzeigen frm1 = new frmDatumListeForPatientenAnzeigen(PatientID, Patientname, Geburtsdatum);
                frm1.ShowDialog();
            }
        }

        private void btnZurückZurTerminListe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTerminenListeAnzeigen frm = new frmTerminenListeAnzeigen();
            frm.ShowDialog();
            this.Close();
        }

        private void frmPatientListeAnzeigen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
    
}
