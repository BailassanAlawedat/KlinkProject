using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmTerminenListeAnzeigen : Form
    {
        private int _RezpetID = -1;
        private DataTable _dtTerminen;
        private BindingSource _bindingSource;

        public frmTerminenListeAnzeigen()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }

        private void frmTerminenListeAnzeigen_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;

            _TermineLaden();
            _DataGridViewEinrichten();
        }

        private void _TermineLaden()
        {
            _dtTerminen = clsTerminDaten.GetAllAppoitments();
            _bindingSource.DataSource = _dtTerminen;
            dgvTerminen.DataSource = _bindingSource;
            lblRecord.Text = _dtTerminen.Rows.Count.ToString();
        }

    private void _DataGridViewEinrichten()
    {
        if (dgvTerminen.Rows.Count > 0)
        {
            dgvTerminen.Columns[0].HeaderText = "TerminID";
            dgvTerminen.Columns[0].Width = 130;

            dgvTerminen.Columns[1].HeaderText = "VersicherungsName";
            dgvTerminen.Columns[1].Width =  300;

            dgvTerminen.Columns[2].HeaderText = "Arzt Vollname";
            dgvTerminen.Columns[2].Width = 200;

            dgvTerminen.Columns[3].HeaderText = "Patienten Vollname";
            dgvTerminen.Columns[3].Width =  200;

            dgvTerminen.Columns[4].HeaderText = "Termin Status";
            dgvTerminen.Columns[4].Width = 150;
        }
    }

     

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
             txtbFilterWert.Visible = (cbFilterBei.Text != "Alle" && 
                cbFilterBei.Text != "TerminStatus");

            cbFilterNachTerminStatus.Visible = (cbFilterBei.Text == "TerminStatus");

            if(cbFilterBei.Text == "Alle")
            {
                _bindingSource.Filter =string.Empty;
                lblRecord.Text = _bindingSource.Count.ToString();
            }
            else if(cbFilterBei.Text == "TerminStatus" )
            {
                cbFilterNachTerminStatus.SelectedIndex = 0;
                cbFilterNachTerminStatus.Focus();
            }
          
        }

        private void txtbFilterWert_TextChanged(object sender, EventArgs e)
        {
            _FilterAnwenden();
            //string FilterSpalte = "";
            //switch(cbFilterBei.Text)
            //{
            //    case "Alle":
            //        FilterSpalte = "Alle";
            //        break;

            //    case "TerminID":
            //        FilterSpalte = "TerminID";
            //        break;

            //    case "VersicherungsName":
            //        FilterSpalte = "VersicherungsName";
            //        break;

            //    case "ArztVollname":
            //        FilterSpalte = "ArztVollname";
            //        break;

            //    case "PatientenVollname":
            //        FilterSpalte = "PatientenVollname";
            //        break;

            //    case "TerminDatum":
            //        FilterSpalte = "TerminDatum";
            //        break;

            //    default:
            //        FilterSpalte = "Alle";
            //        break;
            //}

            //if(FilterSpalte == "Alle" || txtbFilterWert.Text.Trim() == "")
            //{
            //    _dtTerminen.DefaultView.RowFilter = "";
            //    lblRecord.Text = dgvTerminen.Rows.Count.ToString();
            
            //    return;
            //}

            //if(FilterSpalte == "TerminID") 
            // _dtTerminen.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterSpalte, txtbFilterWert.Text.Trim());

            //else
            //    _dtTerminen.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterSpalte, txtbFilterWert.Text.Trim());


            //lblRecord.Text = dgvTerminen.Rows.Count.ToString();
        }

        private void _FilterAnwenden()
        {
            string FilterSpalte = cbFilterBei.Text;
            string FilterWert = txtbFilterWert.Text.Trim();

            if(FilterSpalte == "Alle" || string.IsNullOrEmpty(FilterWert))
            {
                _bindingSource.Filter = string.Empty;
            }     
            else
            {
                if(FilterSpalte == "TerminID" && int.TryParse(FilterWert, out int ID ))
                {
                    _bindingSource.Filter = $"{FilterSpalte} = {ID}";
                }
                else
                {
                    _bindingSource.Filter = $"{FilterSpalte} like '{FilterWert}%'";
                }
            }
            lblRecord.Text = _bindingSource.Count.ToString();
        }

        private void txtbTerminStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBei.Text.Trim() == "TerminID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterNachTerminStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterWert = cbFilterNachTerminStatus.Text;
            if(cbFilterNachTerminStatus.SelectedIndex == 0)
            {
                _bindingSource.Filter = string.Empty;
            }
            else
            {
                _bindingSource.Filter = $"TerminStatus Like '{FilterWert}%'";
            }


            lblRecord.Text = _bindingSource.Count.ToString();

        }
      private void patienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string PersonName = dgvTerminen.CurrentRow.Cells[3].Value.ToString();
            int PersonID = clsPersonDaten.GetPatientIDByPersonName(PersonName);

            frmPersonDatenAnzeigen frm = new frmPersonDatenAnzeigen(PersonID, "Patienten Infos");
            frm.ShowDialog();

        }
  
        private void tsmiArztDatenAnzeigen_Click(object sender, EventArgs e)
        {
            string PersonName = dgvTerminen.CurrentRow.Cells[2].Value.ToString();
            clsArztDaten arztDaten = clsArztDaten.FindByPersonName(PersonName);
            string Farichtungsname = arztDaten.FachrichtungsInfo.FachrichtungsName;

            frmArztDatenAnzeigen frm = new frmArztDatenAnzeigen(arztDaten.ArztID, arztDaten.PersonID, Farichtungsname);

            frm.ShowDialog();
        }

        private void tsmiTerminAktualisieren_Click(object sender, EventArgs e)
        {
            int TerminID = (int)dgvTerminen.CurrentRow.Cells[0].Value;

            frmAktualisierenUndNeuenTerminHinzufügen frm = 
           new frmAktualisierenUndNeuenTerminHinzufügen(TerminID, frmAktualisierenUndNeuenTerminHinzufügen.enMode.UpdateByTerminID);
           frm.ShowDialog();

            _TermineLaden();
            _DataGridViewEinrichten();
        }

        private void tmsiTerminLöschen_Click(object sender, EventArgs e)
        {
            int TerminID = (int)dgvTerminen.CurrentRow.Cells[0].Value;

            clsTerminDaten TerminDaten = clsTerminDaten.Find(TerminID);
            if(TerminDaten == null)
            {
                Console.WriteLine("Termin mit der ID [" + TerminID + "] wurde nicht gefunden", "Fehler Meldung",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Sind Sie sicher, dass Sie diesen Termin entfernen möchten", "Warnung",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            if (TerminDaten.Delete())
                            {
                                MessageBox.Show("Termin mit der ID [" + TerminDaten.TerminID + "] wurde erfolgreich entfernt",
                                    "Erflog", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                _TermineLaden();
                            }
                            else
                            {
                                MessageBox.Show("Fehler beim Entfernen dieses Termins ist aufgetreten",
                                   "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }        
                }
            
           
        }

        private void btnZurÄrztenListe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmÄrzteListeAnzeigen frm = new frmÄrzteListeAnzeigen();
            frm.ShowDialog();
            this.Close();
        }

        private void NeuesRezeptHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {

                int TerminID = (int)dgvTerminen.CurrentRow.Cells[0].Value;
                string VersicherungName = dgvTerminen.CurrentRow.Cells[1].Value.ToString();

                int VersicherungID = clsVersicherungDaten.Find(VersicherungName).VersicherungID;

                
                frmAtkualisierungUndNeueRezepteHinzufügen frm =
                    new frmAtkualisierungUndNeueRezepteHinzufügen(TerminID, VersicherungID);
               frm.Databack += _DataBack;  
                frm.ShowDialog();
        }

        private void _DataBack(object sender, int RezeptID)
        {
            _RezpetID = RezeptID;
        }

        private void cmsTerminen_Opening(object sender, CancelEventArgs e)
        {
            int TerminID = (int)dgvTerminen.CurrentRow.Cells[0].Value;
            tsmiTerminAktualisieren.Enabled = (!clsTerminDaten.IsAppointmentDone(TerminID));

            string Erledigt = dgvTerminen.CurrentRow.Cells[4].Value.ToString();           
            NeuesRezeptHinzufügenToolStripMenuItem.Enabled = (Erledigt == "Erledigt");
            rezeptAktualisierenToolStripMenuItem.Enabled = (Erledigt == "Erledigt");
        }

        private void rezeptAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TerminID = (int)dgvTerminen.CurrentRow.Cells[0].Value;

            if(!clsRezeptDaten.DoesHaveAppointmentRezept(TerminID))
            {
                MessageBox.Show("Dieser Termin hat noch kein Rezept, um es zu aktualisieren", "Fehlermeldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAtkualisierungUndNeueRezepteHinzufügen frm =
                new frmAtkualisierungUndNeueRezepteHinzufügen(TerminID, frmAtkualisierungUndNeueRezepteHinzufügen.enMode.UpdateByTerminID);
            frm.ShowDialog();
        }

        private void TerminListeAnzeigentoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            int TerminID = (int)dgvTerminen.CurrentRow.Cells[0].Value;
            int patientID = clsPatientDaten.FindPatientDataByTerminID(TerminID).PatientID;
            string Patientname = clsPatientDaten.FindPatientDataByTerminID(TerminID).Vollname;
            string Geburtsdatum = clsPatientDaten.FindPatientDataByTerminID(TerminID).GeburtsTag.ToString("dd.MM.yyyy");
            frmDatumListeForPatientenAnzeigen frm = new frmDatumListeForPatientenAnzeigen(patientID,Patientname,Geburtsdatum);
            frm.ShowDialog();    
        }

        private void btnZurPatientenListe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientListeAnzeigen frm = new frmPatientListeAnzeigen();
            frm.ShowDialog();

            _TermineLaden();
            _DataGridViewEinrichten();
            this.Close();
        }
    }
}
