using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmAktualisierenUndNeuenTerminHinzufügen : Form
    {
       public enum enMode { Addnew = 0,  UpdateByTerminID = 1, UpdateByPatientID = 2}
        public  enMode _Mode = enMode.Addnew;

        private DataTable _dtArzt;
        private int _FachrichtungsID = -1;
        private int _PatientID = -1;
        private int _TerminID = -1;
        private int _ArztID = -1;
        private DateTime _Datum = DateTime.Now;
        private string _Zeit = string.Empty;
        private string _Status = string.Empty;
        private clsTerminDaten _TerminDaten;
        public frmAktualisierenUndNeuenTerminHinzufügen(int PatientID)
        {
            InitializeComponent();
            _Mode = enMode.Addnew;
            _TerminDaten = new clsTerminDaten();
            _PatientID = PatientID;
            lblPatientID.Text = _PatientID.ToString();
        }

        public frmAktualisierenUndNeuenTerminHinzufügen(int ID, enMode AkualisierungBei)
        {
            InitializeComponent();

            btnTerminHinzugüfgen.Text = "Termin akutalisieren";
            lblTitel.Text = "Termin aktualisieren";
            _Mode = AkualisierungBei;

            switch (_Mode)
            {
                case enMode.UpdateByTerminID:
                    _TerminID = ID;
                    break;

                case enMode.UpdateByPatientID:
                    _PatientID = ID;
                    break;
            }
        }

        private void frmAktualisierenUndNeuenTerminHinzufügen_Load(object sender, EventArgs e)
        {
            _ResetStandardWerte();
              
              _LoadVersicherungenDaten();
             _LoadFachrichtungenDaten();

            switch (_Mode)
            {
                case enMode.UpdateByTerminID:
                    _LoadTerminDatenByTerminID();
                    break;

                case enMode.UpdateByPatientID:
                    _LoadTerminDatenByPatientID();
                    break;
            }
        }

        private void _ResetStandardWerte()
        {
            txtTerminZeit.Clear();

            dtpTerminDatum.Value = DateTime.Now;
            dtpTerminDatum.Format = DateTimePickerFormat.Custom;
            dtpTerminDatum.CustomFormat = "dd-MM-yyyy";
             
        }
        private void _LoadArztDaten()
        {
            _dtArzt = clsFachrichtungenDaten.GetDoctorWithProfission(_FachrichtungsID);
            dgvArzt.DataSource = _dtArzt;
            if(dgvArzt.Rows.Count > 0)
            {
                dgvArzt.Columns[0].HeaderText = "ArztID";
                dgvArzt.Columns[0].Width = 100;
            
                dgvArzt.Columns[1].HeaderText = "PersonID";
                dgvArzt.Columns[1].Width = 100;

                dgvArzt.Columns[2].HeaderText = "Vollname";
                dgvArzt.Columns[2].Width = 200;

                dgvArzt.Columns[3].HeaderText = "GeburtsTag";
                dgvArzt.Columns[3].Width = 150;

                dgvArzt.Columns[4].HeaderText = "FachrichtungsName";
                dgvArzt.Columns[4].Width = 250;
            }
        }

        private void _LoadFachrichtungenDaten()
        {
            DataTable dt = clsFachrichtungenDaten.GetAllProfessions();
            foreach(DataRow row in dt.Rows)
            {
                cbFachrichtung.Items.Add(row["FachrichtungsName"]);      
            }
            cbFachrichtung.SelectedIndex = 0;
        }

        private void _LoadVersicherungenDaten()
        {
            DataTable dt = clsVersicherungDaten.GetAllVersicherungen();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbVersicherungen.Items.Add(row["VersicherungsName"]);
                }
            }
            cbVersicherungen.SelectedIndex = 0;
        }

        private void cbFachrichtung_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FachrichtungsID = clsFachrichtungenDaten.Find(cbFachrichtung.SelectedItem as string).FachrichtungsID;
            _LoadArztDaten();
        }

       
        private void btnNeuePatientHinzufügen_Click(object sender, EventArgs e)
        {
            frmUpdateUndNeuPatientHinzufügen frm = new frmUpdateUndNeuPatientHinzufügen();
            frm.ShowDialog();

            frmAktualisierenUndNeuenTerminHinzufügen_Load(null, null);
        }

        private void _LoadTerminDatenByPatientID()
        {
            _TerminDaten = clsTerminDaten.FindByPatientID(_PatientID);
            if (_TerminDaten != null)
            {
                lblTerminID.Text = _TerminDaten.TerminID.ToString();
                lblArztID.Text = _TerminDaten.ArztID.ToString();
                lblPatientID.Text = _TerminDaten.PatientID.ToString();

                dtpTerminDatum.Value = _TerminDaten.datum;
                txtTerminZeit.Text = _TerminDaten.zeit;

                int VersicherungsID = _TerminDaten.VersicherungsID;
                string VersicherungsName = clsVersicherungDaten.Find(VersicherungsID).VersicherungsName;
                cbVersicherungen.SelectedItem = VersicherungsName;

                string FachrichtungsName = clsFachrichtungenDaten.FindByDoctorID(_TerminDaten.ArztID).FachrichtungsName;
                cbFachrichtung.SelectedItem = FachrichtungsName;

                cbErledigt.Checked = (_TerminDaten.TerminStatus == true) ? true : false;
                cbNichtErledigt.Checked = (_TerminDaten.TerminStatus == false) ? true : false;

                dgvArzt_SelectionChanged(null, null);
            }
            else
            {
                MessageBox.Show("Kein Object für diesen Termin wurde gefunden.", "Fehler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void _LoadTerminDatenByTerminID()
        {
            _TerminDaten = clsTerminDaten.Find(_TerminID);
            if (_TerminDaten != null)
            {
                lblTerminID.Text = _TerminDaten.TerminID.ToString();
                lblArztID.Text = _TerminDaten.ArztID.ToString();
               lblPatientID.Text = _TerminDaten.PatientID.ToString();

                dtpTerminDatum.Value = _TerminDaten.datum;
                txtTerminZeit.Text = _TerminDaten.zeit;

                int VersicherungsID = _TerminDaten.VersicherungsID;
                string VersicherungsName = clsVersicherungDaten.Find(VersicherungsID).VersicherungsName;
                cbVersicherungen.SelectedItem = VersicherungsName;

                string FachrichtungsName = clsFachrichtungenDaten.FindByDoctorID(_TerminDaten.ArztID).FachrichtungsName;
                cbFachrichtung.SelectedItem = FachrichtungsName;

                cbErledigt.Checked = (_TerminDaten.TerminStatus == true) ? true : false;
                cbNichtErledigt.Checked = (_TerminDaten.TerminStatus == false) ? true : false;

                dgvArzt_SelectionChanged(null, null);
            }
            else
            {
                MessageBox.Show("Termin Daten mit der ID [ " + _TerminID + " ] wurde nicht gefunden", "Fehler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void dgvArzt_SelectionChanged(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateByPatientID || _Mode == enMode.UpdateByTerminID)
            { 
                // Hier müssen Sie eine Zeile im DataGridView auswählen, die mit der ArztID übereinstimmt.
                foreach (DataGridViewRow row in dgvArzt.Rows)
                {
                    if (row.Cells["ArztID"].Value.ToString() == lblArztID.Text)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            else
            {
                // Überprüfen, ob eine Zeile ausgewählt ist, um Fehler zu vermeiden.
                if (dgvArzt.CurrentRow != null)
                {
                    _ArztID = (int)dgvArzt.CurrentRow.Cells[0].Value;
                    lblArztID.Text = _ArztID.ToString();
                }
            }
        }
        private void btnTerminHinzugüfgen_Click(object sender, EventArgs e)
        {
             if (!_FillTerminDaten())
                return;

            switch (_Mode)
            {
                case enMode.Addnew:
                    if (!_IsThisAppointmentFree())
                        return;
                  
                    if (_TerminDaten.Save())
                    {
                        _Mode = enMode.UpdateByPatientID;
                        MessageBox.Show("Der Termin mit der TerminID [ " + _TerminDaten.TerminID + " ] " +
                            " und DatumID  wurde erfolgreich hinzugefügt ", "Erfolg",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Fehler ist aufgetreten ", "Fehler Meldung",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;


                case enMode.UpdateByPatientID:
                    if (_TerminDaten.Save())
                    {
                        _Mode = enMode.UpdateByPatientID;
                        MessageBox.Show("Der Termin mit der ID [ " + _TerminDaten.TerminID + " ] wurde erfolgreich aktualisiert ", "Erfolg",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Fehler ist aufgetreten ", "Fehler Meldung",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case enMode.UpdateByTerminID:
                    if (_TerminDaten.Save())
                    {
                        _Mode = enMode.UpdateByTerminID;
                        MessageBox.Show("Der Termin mit der ID [ " + _TerminDaten.TerminID + " ] wurde erfolgreich aktualisiert ", "Erfolg",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Fehler beim Aktualisieren ist aufgetreten ", "Fehler Meldung",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;



            }
        }
        private bool _FillTerminDaten()
        {
            _TerminDaten.ArztID = Convert.ToInt32(lblArztID.Text);
            _TerminDaten.PatientID = Convert.ToInt32(lblPatientID.Text);

            //Datum daten.
            _TerminDaten.datum = dtpTerminDatum.Value;
            if(string.IsNullOrEmpty(txtTerminZeit.Text.Trim()) || _Status == "Frei")
            {
                MessageBox.Show("Es wurde kein Datum reseviert", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _TerminDaten.zeit = txtTerminZeit.Text;
            _TerminDaten.status = _Status;

            int VersicherungsID = clsVersicherungDaten.Find(cbVersicherungen.SelectedItem as string).VersicherungID;
            _TerminDaten.VersicherungsID = VersicherungsID;


            if (cbErledigt.Checked)
                _TerminDaten.TerminStatus = true;
            else
                _TerminDaten.TerminStatus = false;

            return true;
        }

        private bool _IsThisAppointmentFree()
        {
            if (clsTerminDaten.DoesHavePatientAppointmentOnThisTime(_PatientID, dtpTerminDatum.Value))
            {
                clsTerminDaten Termindaten = clsTerminDaten.FindByPatientID(_PatientID);
                if (Termindaten != null)
                {
                    string[] splitzeit = (Termindaten.zeit.Split(new string[] { "-" }, StringSplitOptions.None));

                    string startzeit = splitzeit[0];
                    string endzeit = splitzeit[1];

                    MessageBox.Show("Dieser Patient hat bereits einen Termin an diesem Tag von \n  [ " +
                      startzeit + " ] bis [ " + endzeit + " ] ", "Fehlermeldung",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _ResetStandardWerte();
                    return false;
                      
                }
                else
                    MessageBox.Show("Kein object für diese Patient gefunden", "Fehler Meldung",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (!clsTerminDaten.IsDoctorFreeForThisAppointment(_ArztID, dtpTerminDatum.Value,
               txtTerminZeit.Text))
            {
                MessageBox.Show("Dieser Arzt hat in diesem Zeitraum andere Behandlungen", "Fehler Meldung",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetStandardWerte();
                return false;
            }

            return true;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void cbErledigt_Click(object sender, EventArgs e)
        {
            cbNichtErledigt.Checked = false;
            cbErledigt.Checked = true;
        }

        private void cbNichtErledigt_Click(object sender, EventArgs e)
        {
            cbErledigt.Checked = false;
            cbNichtErledigt.Checked = true;
        }
        private void btnZurTabelle_Click(object sender, EventArgs e)
        {
            int ArztID = int.Parse(lblArztID.Text);

            if (_Mode == enMode.UpdateByTerminID)
            {
                string PatientNameÜberTerminID = clsPatientDaten.FindPatientDataByTerminID(_TerminID).Vollname;            
                frmDatenTablleAnzeigen frm = new frmDatenTablleAnzeigen(PatientNameÜberTerminID, ArztID);
                frm.OnDatenBack += _GetDatenBack;
                frm.Show();
            }
            else
            {
                string PatientNameÜberPaientID = clsPatientDaten.Find(_PatientID).Vollname;
                frmDatenTablleAnzeigen frm = new frmDatenTablleAnzeigen(PatientNameÜberPaientID, ArztID);
                frm.OnDatenBack += _GetDatenBack;
                frm.Show();

            }
       
        }

        private void _GetDatenBack(object sender, frmDatenTablleAnzeigen.DatenEventArgs e)
        {
            _Datum = e.Datum;
            _Zeit = e.Zeit;
            _Status = e.Status;

            _FillDateTimePicker(_Datum, _Zeit);
        }
        private void _FillDateTimePicker(DateTime Datum, string zeiten)
        {
            dtpTerminDatum.Value = Datum;
            txtTerminZeit.Text = zeiten;
        }
    }
}
