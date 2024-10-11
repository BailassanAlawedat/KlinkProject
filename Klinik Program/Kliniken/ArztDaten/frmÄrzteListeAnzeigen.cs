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
    public partial class frmÄrzteListeAnzeigen : Form
    {
        DataTable _dtArzt;
        public frmÄrzteListeAnzeigen()
        {
            InitializeComponent();
        }

        private void frmÄrzteListeAnzeigen_Load(object sender, EventArgs e)
        {
            _FillArztListe();

        }

        private void _FillArztListe()
        {
            cbFilterBei.SelectedIndex = 0;
            _dtArzt = clsArztDaten.GetAllDoctors();
            dgvÄrzte.DataSource = _dtArzt;
            lblRecord.Text = dgvÄrzte.Rows.Count.ToString();

            foreach(DataGridViewColumn spalte in dgvÄrzte.Columns)
            {
                dgvÄrzte.ColumnHeadersDefaultCellStyle.Font = new Font(dgvÄrzte.Font.FontFamily, 12, FontStyle.Bold);
            }

            if(dgvÄrzte.Rows.Count > 0)
            {
                dgvÄrzte.Columns[0].HeaderText = "ArztID";
                dgvÄrzte.Columns[0].Width = 100;

                dgvÄrzte.Columns[1].HeaderText = "PersonID";
                dgvÄrzte.Columns[1].Width = 100;

                dgvÄrzte.Columns[2].HeaderText = "Vollname";
                dgvÄrzte.Columns[2].Width = 200;

                dgvÄrzte.Columns[3].HeaderText = "AusweisID";
                dgvÄrzte.Columns[3].Width =  100;

                dgvÄrzte.Columns[4].HeaderText = "GeburstTag";
                dgvÄrzte.Columns[4].Width =  150;

                dgvÄrzte.Columns[5].HeaderText = "RegistrierungsDatum";
                dgvÄrzte.Columns[5].Width =  200;

                dgvÄrzte.Columns[6].HeaderText = "Fachrichtung Name";
                dgvÄrzte.Columns[6].Width =  200;

            }
        }

        private void btnArztHinzufügen_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeueArztHinzufügen frm = new frmAktualisierenUndNeueArztHinzufügen();
            frm.ShowDialog();

            frmÄrzteListeAnzeigen_Load(null, null);
        }

        private void arztDatenAnziegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ArztID = (int)dgvÄrzte.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvÄrzte.CurrentRow.Cells[1].Value;
            string Fachrichtung = (string)dgvÄrzte.CurrentRow.Cells[6].Value;

            frmArztDatenAnzeigen frm = new frmArztDatenAnzeigen(ArztID, PersonID, Fachrichtung);
            frm.ShowDialog();
        }

        private void arztDatenAkualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ArztID = (int)dgvÄrzte.CurrentRow.Cells[0].Value;
            frmAktualisierenUndNeueArztHinzufügen frm = new frmAktualisierenUndNeueArztHinzufügen(ArztID);
            frm.ShowDialog();

            frmÄrzteListeAnzeigen_Load(null, null);
        }

        private void neueArztHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arztDatenLöshenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ArztID= (int)dgvÄrzte.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Sind Sie sicher,Sie möchten diese Arzt Daten mit der ID = " +
              ArztID + " löschen ?", "Vorwarnung", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                == DialogResult.Cancel)
            {
                return;
            }

            clsArztDaten Arzt = clsArztDaten.Find(ArztID);
            if (Arzt != null)
            {
                if (Arzt.Delete())
                {
                    MessageBox.Show("Arzt Daten wurden vom System erfolgreich gelöscht", "Erfolg",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmÄrzteListeAnzeigen_Load(null, null);
                }
                else
                    MessageBox.Show("Fehler beim Löschen dieses Arztes ist aufgetreten", "Fehler Meldung",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Der Arzt mit der ID = " + ArztID + " existiert nicht im System.", "Fehler Meldung",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterWert.Visible = (cbFilterBei.Text != "Keine");
            if (cbFilterBei.Text != "Keine")
            {
                txtFilterWert.Focus();
                txtFilterWert.Text = "";
            }
        }

        private void txtFilterWert_TextChanged(object sender, EventArgs e)
        {
           
            string FilterSpalte = "";

            switch (cbFilterBei.Text)
            {
                case "ArztID":
                    FilterSpalte = "ArztID";
                    break;

                case "PersonID":
                    FilterSpalte = "PersonID";
                    break;

                case "AusweisID":
                    FilterSpalte = "AusweisID";
                    break;

                case "Vollname":
                    FilterSpalte = "Vollname";
                    break;

                case "Stadt":
                    FilterSpalte = "Stadt";
                    break;

                case "Postleitzahl":
                    FilterSpalte = "Postleitzahl";
                    break;

                case "Geschlecht":
                    FilterSpalte = "Geschlecht";
                    break;

                default:
                    FilterSpalte = "Keine";
                    break;
            }

            if (txtFilterWert.Text.Trim() == "" || FilterSpalte == "Keine")
            {
                _dtArzt.DefaultView.RowFilter = "";
                lblRecord.Text = dgvÄrzte.Rows.Count.ToString();
                return;
            }

            if (FilterSpalte == "PersonID" || FilterSpalte == "ArztID")
                _dtArzt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterSpalte, txtFilterWert.Text.Trim());
            
            else
                _dtArzt.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterSpalte, txtFilterWert.Text.Trim());              
            
            lblRecord.Text = dgvÄrzte.Rows.Count.ToString();
        }

        private void txtFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBei.Text == "PersonID" || cbFilterBei.Text == "ArztID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnZurückZurTerminListe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTerminenListeAnzeigen frm = new frmTerminenListeAnzeigen();
            frm.ShowDialog();

            this.Close();
        }
    }
}
