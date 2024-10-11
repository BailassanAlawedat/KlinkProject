using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmMitarbeiterListeAnzeigen : Form
    {
        private DataTable _dtMitarbeiter;
        private DataTable _dtReinigungsPersonl;
        private DataTable _dtKüchenPersonal;
        private DataTable _dtTransportdienst;
        private DataTable _dtSicherheitsdienst;

        private BindingSource _bindingSourceAllgemeineMitarbeiter;
        private BindingSource _bindingSourceReinigungsPersonal;
        private BindingSource _bindingSourceKüchenPersonal;
        private BindingSource _bindingSourceTransportdienst;
        private BindingSource _bindingSourceSicherheitsdienst;

        private BindingSource _HauptBindingSource;

        public frmMitarbeiterListeAnzeigen()
        {
            InitializeComponent();

            _bindingSourceAllgemeineMitarbeiter = new BindingSource();
            _HauptBindingSource = new BindingSource();
        }

        private void frmMitarbeiterListeAnzeigen_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;
            cbSelecetBy.SelectedIndex = 0;

            _LoadMitarbeiterDaten();
            _DataGridViewEinrichten();
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GefiltertBei = cbFilterBei.Text.Trim();

            switch (GefiltertBei)
            {
                case "Allgemeine Mitarbeiter":
                    {
                        _LoadMitarbeiterDaten();
                        lblTitel.Text = "Allgemeine Mitarbeiter Liste";
                        break;
                    }

                case "ReinigungsPersonal":
                    {
                        _LoadReinigungsPersonalMitarbeiter();
                        lblTitel.Text = "ReinigungsPersonal Liste";
                        break;
                    }

                case "KüchenPersonal":
                    {
                        _LoadKüchenPersonalMitarbeiter();
                        lblTitel.Text = "KüchenPersonal Liste";
                        break;
                    }

                case "Transportdienst":
                    {
                        _LoadAllTransportdienstMitarbeiter();
                        lblTitel.Text = "Transportdienste Liste";
                        break;
                    }

                case "Sicherheitsdienst":
                    {
                        _LoadAllSicherheitsdienstMitarbeiter();
                        lblTitel.Text = "Sicherheitsdienste Liste";
                        break;
                    }

                default:
                    {
                        _LoadMitarbeiterDaten();
                        lblTitel.Text = "Allgemeine Mitarbeiter Liste";
                        break;
                    }
            }
        }

        private void _LoadMitarbeiterDaten()
        {
            // Alte DataTable freigeben, bevor neue Daten geladen werden
            _DisposeDataTable(ref _dtMitarbeiter);

            _dtMitarbeiter = clsMitarbeiterDaten.GetAllMitarbeiter();

            if (_dtMitarbeiter != null)
            {
                _bindingSourceAllgemeineMitarbeiter.DataSource = _dtMitarbeiter;
                _HauptBindingSource = _bindingSourceAllgemeineMitarbeiter; // wir verwenden die HauptBindingSource für Filtern
                dgvMitarbeiter.DataSource = _bindingSourceAllgemeineMitarbeiter;
                lblRecod.Text = _dtMitarbeiter.Rows.Count.ToString();
                _UpdateRecord();
            }
        }

        private void _LoadReinigungsPersonalMitarbeiter()
        {
            // Alte DataTable freigeben, bevor neue Daten geladen werden
            _DisposeDataTable(ref _dtReinigungsPersonl);

            _dtReinigungsPersonl = clsReinigungsPersonalDaten.GetAllReinigungsPersonal();

            if (_dtReinigungsPersonl != null)
            {
                _bindingSourceReinigungsPersonal = new BindingSource();
                _bindingSourceReinigungsPersonal.DataSource = _dtReinigungsPersonl;

                _HauptBindingSource = _bindingSourceReinigungsPersonal;

                dgvMitarbeiter.DataSource =  _bindingSourceReinigungsPersonal;
                _UpdateRecord();
               
            }
        }         

        private void _LoadKüchenPersonalMitarbeiter()
        {
            // Alte DataTable freigeben, bevor neue Daten geladen werden
            _DisposeDataTable(ref _dtKüchenPersonal);

            _dtKüchenPersonal = clsKüchenPersonalDaten.GetAllKüchenPersonalMitarbeiter();

            if (_dtKüchenPersonal != null)
            {
                _bindingSourceKüchenPersonal = new BindingSource();
                _bindingSourceKüchenPersonal.DataSource = _dtKüchenPersonal;

                _HauptBindingSource = _bindingSourceKüchenPersonal;

                dgvMitarbeiter.DataSource = _bindingSourceKüchenPersonal;
                _UpdateRecord();
           
            }
        }
        
        private void _LoadAllTransportdienstMitarbeiter()
        {
            // Alte DataTable freigeben, bevor neue Daten geladen werden
            _DisposeDataTable(ref _dtTransportdienst);

            _dtTransportdienst = clsTransportdienstDaten.GetAllTransportdienstMitarbeiter();

            if (_dtTransportdienst != null)
            {
                _bindingSourceTransportdienst = new BindingSource();
                _bindingSourceTransportdienst.DataSource = _dtTransportdienst;

                _HauptBindingSource = _bindingSourceTransportdienst;

                dgvMitarbeiter.DataSource = _bindingSourceTransportdienst;

                _UpdateRecord();
         
            }
        }

        private void _LoadAllSicherheitsdienstMitarbeiter()
        {
            _DisposeDataTable(ref _dtSicherheitsdienst);

            _dtSicherheitsdienst = clsSicherheitsdienstDaten.GetAllSicherheitsdienstMitarbeiter();

            if (_dtSicherheitsdienst != null)
            {
                _bindingSourceSicherheitsdienst = new BindingSource();
                _bindingSourceSicherheitsdienst.DataSource = _dtSicherheitsdienst;
                _HauptBindingSource = _bindingSourceSicherheitsdienst;
                dgvMitarbeiter.DataSource = _bindingSourceSicherheitsdienst;

                _UpdateRecord();
         
            }
        }
        private void _DataGridViewEinrichten()
        {
            dgvMitarbeiter.ColumnHeadersDefaultCellStyle.Font = new Font(dgvMitarbeiter.Font.FontFamily, 14, FontStyle.Bold);
            //dgvMitarbeiter.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            //dgvMitarbeiter.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Iteriere über die Spalten, um individuelle Einstellungen vorzunehmen
            foreach (DataGridViewColumn spalte in dgvMitarbeiter.Columns)
            {
                spalte.Width = 200;
                spalte.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
         
        }

        private void _UpdateRecord()
        {
            lblRecod.Text = _dtMitarbeiter.Rows.Count.ToString();
        }

        private void cbSelecetBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _DatenFilterInDataGridView();
        }

        private void _DatenFilterInDataGridView()
        {
            string SelectedWert = cbSelecetBy.Text.ToString();
            txtFilterWert.Visible = (SelectedWert != "Keine");
            if (SelectedWert != "Keine")
            {
                txtFilterWert.Clear();
                txtFilterWert.Focus();
               _HauptBindingSource.Filter = string.Empty;
            }
        }

        private void txtFilterWert_TextChanged(object sender, EventArgs e)
        {
            _FilterAnwenden();
        }

        private void _FilterAnwenden()
        {
            string Filterspalte = cbSelecetBy.Text;
            string Filterwert = txtFilterWert.Text.Trim();

            if(Filterspalte == "Keine" || string.IsNullOrEmpty(txtFilterWert.Text))
            {
                _HauptBindingSource.Filter = string.Empty;
                _UpdateRecord();
                return;
            }
             
            if(Filterspalte == "SteuerID")
            {
                _HauptBindingSource.Filter = $"SteuerID like '{Filterwert}%'";
                _UpdateRecord();
                return;
            }

            switch (Filterspalte)
            {
                case "MitarbeiterID":
                    {
                        if (int.TryParse(Filterwert, out int id))
                        {
                            _HauptBindingSource.Filter = $"{Filterspalte} = {id}";
                            _UpdateRecord();
                        }
                        break;
                    }
                case "PersonID":
                    {
                        if (int.TryParse(Filterwert, out int id))
                        {
                            _HauptBindingSource.Filter = $"{Filterspalte} = {id}";
                            _UpdateRecord();
                        }
                        break;
                    }
                case "EingestelltBeiUser":
                    {
                        if (int.TryParse(Filterwert, out int id))
                        {
                            _HauptBindingSource.Filter = $"{Filterspalte} = {id}";
                            _UpdateRecord();
                        }
                        break;
                    }

                default:
                    {
                        _HauptBindingSource.Filter = string.Empty;
                        _UpdateRecord();
                        break;
                    }
            }

        }

        private  void _DisposeDataTable(ref DataTable dt)
        {
            if(dt != null)
            {
                dt.Dispose(); // Um die Resourcen freizugeben.
                dt = null;  // wir setzen alle DatenTabellen wieder auf null vor jedem Aufruf 
                               // und nach der FormClosing . 
            }
        }

        private void frmMitarbeiterListeAnzeigen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _DisposeDataTable(ref _dtMitarbeiter);
            _DisposeDataTable(ref _dtReinigungsPersonl);
            _DisposeDataTable(ref _dtKüchenPersonal);
            _DisposeDataTable(ref _dtTransportdienst);
            _DisposeDataTable(ref _dtSicherheitsdienst);
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string FilterWert = cbFilterBei.Text;

            switch (FilterWert)
            {
                case "Allgemeine Mitarbeiter":
                    _AlleContexMenuItemsDeaktivieren();
                    mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem.Enabled = true;
                    break;
                case "ReinigungsPersonal":
                    _AlleContexMenuItemsDeaktivieren();
                    ReinigungsPersonInfoToolStripMenuItem.Enabled = true;
                    break;
                case "Sicherheitsdienst":
                    _AlleContexMenuItemsDeaktivieren();
                    sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem.Enabled = true;
                    break;
                case "KüchenPersonal":
                    _AlleContexMenuItemsDeaktivieren();
                    küchenPersonInfosAnzeigenToolStripMenuItem.Enabled = true;
                    break;
                case "Transportdienst":
                    _AlleContexMenuItemsDeaktivieren();
                    transportdienstPersonInfosAnzeigenToolStripMenuItem.Enabled = true;
                    break;

                default:
                    _AlleContexMenuItemsDeaktivieren();
                    mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem.Enabled = true;
                    break;
            }
        }

        private void _AlleContexMenuItemsDeaktivieren()
        {
            mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem.Enabled = false;
            ReinigungsPersonInfoToolStripMenuItem.Enabled = false;
            küchenPersonInfosAnzeigenToolStripMenuItem.Enabled = false;
            transportdienstPersonInfosAnzeigenToolStripMenuItem.Enabled = false;
            sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem.Enabled = false;
        }

        private void ReinigungsPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MitarbeiterID = (int)dgvMitarbeiter.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvMitarbeiter.CurrentRow.Cells[1].Value;
            frmMitarbeiterDatenAnzeigen frm =
               new frmMitarbeiterDatenAnzeigen(frmMitarbeiterDatenAnzeigen.enAnzeigenMode.ByReinigungsPersonalMitarbeiterID, MitarbeiterID, PersonID);
            frm.ShowDialog();
        }
        private void mitarbeiterInfosBeiMitarbeiterIDAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MitarbeiterID = (int)dgvMitarbeiter.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvMitarbeiter.CurrentRow.Cells[1].Value;

            frmMitarbeiterDatenAnzeigen frm =
                new frmMitarbeiterDatenAnzeigen(frmMitarbeiterDatenAnzeigen.enAnzeigenMode.ByMitarbeiterID, MitarbeiterID, PersonID);
            frm.ShowDialog();
        }

        private void küchenPersonInfosAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MitarbeiterID = (int)dgvMitarbeiter.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvMitarbeiter.CurrentRow.Cells[1].Value;
            frmMitarbeiterDatenAnzeigen frm =
                new frmMitarbeiterDatenAnzeigen(frmMitarbeiterDatenAnzeigen.enAnzeigenMode.ByKüchenPersonalMitarbeiterID, MitarbeiterID, PersonID);
            frm.ShowDialog();
        }

        private void transportdienstPersonInfosAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MitarbeiterID = (int)dgvMitarbeiter.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvMitarbeiter.CurrentRow.Cells[1].Value;
            frmMitarbeiterDatenAnzeigen frm =
                new frmMitarbeiterDatenAnzeigen(frmMitarbeiterDatenAnzeigen.enAnzeigenMode.ByTransportdienstMitarbeiterID, MitarbeiterID, PersonID);
            frm.ShowDialog();
        }

        private void sicherheitsdienstPersonInfosAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MitarbeiterID = (int)dgvMitarbeiter.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvMitarbeiter.CurrentRow.Cells[1].Value;
            frmMitarbeiterDatenAnzeigen frm =
                new frmMitarbeiterDatenAnzeigen(frmMitarbeiterDatenAnzeigen.enAnzeigenMode.BySicherheitsdienstMitarbeiterId, MitarbeiterID, PersonID);
            frm.ShowDialog();
        }

        private void mitarbeiterdatenAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvMitarbeiter.CurrentRow.Cells[1].Value;
            frmAktualisierenUndNeuenMitarbeiterHinzufügen frm = new
                frmAktualisierenUndNeuenMitarbeiterHinzufügen(frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode.UpdateByPersonID, PersonID);
           frm.ShowDialog();

            cbFilterBei_SelectedIndexChanged(null, null);
        }

        private void mitarbeiterdatenEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DatenNachAktualisierenWiederLaden()
        {


        }
    }
}
