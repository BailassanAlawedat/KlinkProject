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
    public partial class frmBenutzerListeAnzeigen : Form
    {
        DataTable _dtBenutzer;
        BindingSource _bindingsource;
        public frmBenutzerListeAnzeigen()
        {
            InitializeComponent();
            _bindingsource = new BindingSource();
        }

        private void frmBenutzerListeAnzeigen_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;
            //txtFilterWert.Visible = false;
            txtFilterWert.Select();

            _LoadBenutzerData();
            _DataGridViewEinrichten();
        }

        private void _LoadBenutzerData()
        {
            _dtBenutzer = clsBenutzerDaten.GetAllUsers();
            _bindingsource.DataSource = _dtBenutzer;
            dgvBenutzer.DataSource = _bindingsource;
            lblRecord.Text = _dtBenutzer.Rows.Count.ToString();
        }

        private void _DataGridViewEinrichten()
        {
            foreach(DataGridViewColumn spalte in dgvBenutzer.Columns)
            {
                dgvBenutzer.ColumnHeadersDefaultCellStyle.Font = new Font(dgvBenutzer.Font.FontFamily, 14, FontStyle.Bold);
            }

            if (dgvBenutzer.Rows.Count > 0)
            {
                dgvBenutzer.Columns[0].HeaderText = "BenutzerID";
                dgvBenutzer.Columns[0].Width = 150;

                dgvBenutzer.Columns[1].HeaderText = "PersonID";
                dgvBenutzer.Columns[1].Width =  150;

                dgvBenutzer.Columns[2].HeaderText = "Rollenname ";
                dgvBenutzer.Columns[2].Width = 200;

                dgvBenutzer.Columns[3].HeaderText = "Erstellt Am";
                dgvBenutzer.Columns[3].Width =  200;

                dgvBenutzer.Columns[4].HeaderText = "Aktualisiert Am";
                dgvBenutzer.Columns[4].Width =  200;

                dgvBenutzer.Columns[5].HeaderText = "Letzter Login";
                dgvBenutzer.Columns[5].Width =  200;

                dgvBenutzer.Columns[6].HeaderText = "Status";
                dgvBenutzer.Columns[6].Width = 150;
            }
        }
        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Filterspalte = cbFilterBei.Text;
            txtFilterWert.Visible = (Filterspalte != "Keine");
            cbStatus.Visible = (Filterspalte == "Status");


            if (Filterspalte != "Keine")
            {
                txtFilterWert.Clear();
                txtFilterWert.Focus();
            }
            else
                _bindingsource.Filter = string.Empty;

            if(Filterspalte == "Status")
            {
                cbStatus.SelectedIndex = cbStatus.FindString("Alle");
                txtFilterWert.Visible = false;
                cbStatus.Focus();
            }
            lblRecord.Text = _bindingsource.Count.ToString();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterWert = cbStatus.Text;

            if (cbStatus.SelectedIndex == 0)
            {
                _bindingsource.Filter = string.Empty;
            }
            else
            {
                _bindingsource.Filter = $"Status like '{FilterWert}%' ";
            }
            lblRecord.Text = _bindingsource.Count.ToString();
        }

        private void txtFilterWert_TextChanged_1(object sender, EventArgs e)
        {
            string FilterSpalte = cbFilterBei.Text;
            string FilterWert = txtFilterWert.Text.Trim();

            if (FilterSpalte == "Keine" || string.IsNullOrEmpty(FilterWert))
            {
                _bindingsource.Filter = string.Empty;
            }
            else
            {
                if ((FilterSpalte == "PersonID" || FilterSpalte == "BenutzerID") && int.TryParse(FilterWert, out int ID))
                {
                    _bindingsource.Filter = $"{FilterSpalte} = {ID}";
                }
                else
                    _bindingsource.Filter = $"{FilterSpalte} like '{FilterWert}%'";
            }
            lblRecord.Text = _bindingsource.Count.ToString();
        }


        private void benutzerDetailsAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvBenutzer.CurrentRow.Cells[1].Value;
            frmBenutzerDatenAnzeigen frm = new frmBenutzerDatenAnzeigen(PersonID);
            frm.ShowDialog();
        }

        private void benutzerDatenAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvBenutzer.CurrentRow.Cells[1].Value;

            frmAktualisierenUndNeuenBenutzerHinzufügen frm = new frmAktualisierenUndNeuenBenutzerHinzufügen(PersonID);
            frm.ShowDialog();

            _LoadBenutzerData();
            _DataGridViewEinrichten();
        }

        private void benutzerDatenLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BenutzerID = (int)dgvBenutzer.CurrentRow.Cells[0].Value;

            var Result = (MessageBox.Show("Sind Sie sicher, Diesen Benutzer von System zu entfernen? ",
                "Frage",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2));
             
            if(Result == DialogResult.No)
            {
                return;
            }

            bool Done = clsBenutzerDaten.Delete(BenutzerID);
            if(Done)
            {
                _LoadBenutzerData();
                _DataGridViewEinrichten();
            }
            else
            {
                MessageBox.Show("Der Benutzer konnte nicht gelöscht werden. Bitte versuchen Sie es später erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void benutzerDeaktivierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BenutzerID = (int)dgvBenutzer.CurrentRow.Cells[0].Value;

            bool Done = clsBenutzerDaten.DeactivateUser(BenutzerID);
            if(Done)
            { 
                _LoadBenutzerData();
                _DataGridViewEinrichten();
                return;
            }
            else
            {
                MessageBox.Show("Der Benutzer konnte nicht deaktiviert werden. Bitte versuchen Sie es später erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void benutzerAktivierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BenutzerID = (int)dgvBenutzer.CurrentRow.Cells[0].Value;

            bool Done = clsBenutzerDaten.ActivateUser(BenutzerID);
            if (Done)
            {
                _LoadBenutzerData();
                _DataGridViewEinrichten();
                return;
            }
            else
            {
                MessageBox.Show("Der Benutzer konnte nicht aktiviert werden. Bitte versuchen Sie es später erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuenBenutzerHinzufügen frm = new frmAktualisierenUndNeuenBenutzerHinzufügen();
            frm.ShowDialog();

            _LoadBenutzerData();
            _DataGridViewEinrichten();
        }

    }
}
