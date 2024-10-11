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
    public partial class frmFachrichtungenListeAnzeigen : Form
    {
        DataTable _dtFachrichtung;
        string _SelectedItem;
        public frmFachrichtungenListeAnzeigen()
        {
            InitializeComponent();

            _FillComboBoxMitFachrichtungen();
        }

        private void _FillComboBoxMitFachrichtungen()
        {
            _dtFachrichtung = clsFachrichtungenDaten.GetAllProfessions();

            if(_dtFachrichtung != null)
            {
               foreach(DataRow row in _dtFachrichtung.Rows)
                {
                    cbFachrichtungen.Items.Add(row["FachrichtungsName"]);
                }
            }
        }
        private void frmFachrichtungenListeAnzeigen_Load(object sender, EventArgs e)
        {
            cbFachrichtungen.SelectedIndex = 0;

            _dtFachrichtung = clsFachrichtungenDaten.GetAllProfessions();
            dgvFachrichtung.DataSource = _dtFachrichtung;
            lblRecord.Text = dgvFachrichtung.Rows.Count.ToString();

            if(dgvFachrichtung.Rows.Count > 0)
            {
                dgvFachrichtung.Columns[0].HeaderText = "Fachrichtung ID";
                dgvFachrichtung.Columns[0].Width = 250;

                dgvFachrichtung.Columns[1].HeaderText = "Fachrichtung Name";
                dgvFachrichtung.Columns[1].Width = 350;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFachrichtungHinzufügen_Click(object sender, EventArgs e)
        {
            frmFachrictungHinzufügenOderAkualisieren frm = new frmFachrictungHinzufügenOderAkualisieren();
            frm.ShowDialog();

            frmFachrichtungenListeAnzeigen_Load(null, null);
        }

        private void btnFachrichtungAktualisieren_Click(object sender, EventArgs e)
        {
            if (cbFachrichtungen.SelectedItem != null)
            {

                string AlteAusgewähltes_Item
                    = cbFachrichtungen.SelectedItem as string;
                int fachrichtungsID = clsFachrichtungenDaten.Find(AlteAusgewähltes_Item).FachrichtungsID;

                frmFachrictungHinzufügenOderAkualisieren frm = new frmFachrictungHinzufügenOderAkualisieren(fachrichtungsID);
                frm.Databack += DataBack_FormFachrichtung;
                frm.ShowDialog();

                string NeuAusgewähltes_Item = _SelectedItem;
                // den Index des alten elements in comboBox finden.
                int index = cbFachrichtungen.FindStringExact(AlteAusgewähltes_Item);

                if(index != -1 && NeuAusgewähltes_Item != null)
                {
                    cbFachrichtungen.Items[index] = NeuAusgewähltes_Item;
                }

                frmFachrichtungenListeAnzeigen_Load(null, null);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Fachrichtung aus.");
            }
        }

        private void DataBack_FormFachrichtung(object sender, string item)
        {
            _SelectedItem = item;
        }
        private void cbFachrichtungen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
