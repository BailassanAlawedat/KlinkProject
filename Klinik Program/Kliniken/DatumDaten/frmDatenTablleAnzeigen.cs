using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Kliniken
{
    public partial class frmDatenTablleAnzeigen : Form
    {
        public class DatenEventArgs : EventArgs
        {
            public DateTime Datum { get; }
            public string Zeit { get; }
            public string Status { get;  }
            
            public DatenEventArgs (DateTime datum,string zeit,string status)
            {
                this.Datum = datum;
                this.Zeit = zeit;
                this.Status = status;
            }
        }

        public EventHandler<DatenEventArgs> OnDatenBack;
        protected virtual void RelaisDatenback(DateTime datum, string zeit,string status)
        {
            OnDatenBack?.Invoke(this, new DatenEventArgs(datum, zeit, status));
        }

        private DateTime _Datum = DateTime.Now;
        private string _Zeit = string.Empty;
        private string _Status = string.Empty;
        private int _ArztID = -1;
        public frmDatenTablleAnzeigen(string patientenName, int ArztID)
        {
            InitializeComponent();

            lblPatientenName.Text = patientenName;
            _ArztID = ArztID;
        }

       private bool isFrei = true;

        private DataTable _dtDaten;

        private void frmDatenTablleAnzeigen_Load(object sender, EventArgs e)
        {
            _DataGridViewEinrichten();
        }
       
       private void _DataGridViewEinrichten()
        {
            _dtDaten = clsDatumDaten.GetArztDatumDaten(_ArztID);

            // Setze die Spalten manuell
            _LoadDataInDataGridView(dgvDatenTabelle);
            //Wochenende Zeitfenster Farbe setzen
            FarbeFürWochenEndeSetzen(dgvDatenTabelle);
            //Freie und belegte Zeitfenster Farbe setzen.
            FarbeSetzenFürFreieUndBelegteTermine(dgvDatenTabelle);
        }
        private  void _LoadDataInDataGridView(DataGridView dataGridView1)
        { 
            string[] Zeitfenster = _GeneriereZeitraum();

            DateTime startDatum = DateTime.Now.Date;
            DateTime endDatum = new DateTime(DateTime.Now.Year, 12, 31);
            int TageZahl = (endDatum - startDatum).Days + 1; // Annäherung für ein Jahr

            // Setze Spalten für das DataGridView
            dataGridView1.ColumnCount = Zeitfenster.Length + 1; // +1 für das Datum
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[0].Name = "Datum"; // Name der ersten Spalte
            
            for (int i = 0; i < Zeitfenster.Length; i++)
            {
                // Setze Namen für die Zeitfenster-Spalten
                dataGridView1.Columns[i + 1].Name = Zeitfenster[i];
            }

            //// Generiere Beispieldaten für 360 Ein Jahr.
            DateTime startDate = DateTime.Now.Date; // Startdatum (heute)
            for (int i = 0; i < TageZahl; i++)
            {
                string[] dgvRow = new string[Zeitfenster.Length + 1]; // Array für eine Zeile
                DateTime currentDate = startDate.AddDays(i); // Berechne das Datum für den aktuellen Tag

                // Überspringe vergangene Tage
                if (currentDate < DateTime.Now.Date)
                {
                    continue;
                }

                dgvRow[0] = currentDate.ToString("dd.MM.yyyy"); // Datum in die erste Spalte einfügen
                for (int j = 1; j <= Zeitfenster.Length; j++)
                {
                    if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        dgvRow[j] = "Feiertag";

                    }
                    else
                        dgvRow[j] = "Frei"; // Alle Zeitfenster sind anfangs frei
                }

                _GetDatenFromDataBaseIfExists(dgvRow, currentDate, Zeitfenster);

            dataGridView1.Rows.Add(dgvRow); // Füge die Zeile zum DataGridView hinzu
        }
            //Allte Spalten auf eine bestimmte Breite setzen 
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 110;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //// Alle Zeilen auf eine bestimmte Höhe setzen
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 30; //Höhe
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void  _GetDatenFromDataBaseIfExists(string[] dgvRow, DateTime currentDate, string[] timeSlots)
        {

            if (_dtDaten != null && _dtDaten.Columns.Contains("Datum"))
            {
                //überprüfen , ob für das aktuelle Datum Temrine in Datenbank existieren.
                DataRow[] rows = _dtDaten.Select($"Datum = '{currentDate.ToString("yyyy-MM-dd")}' ");

                if (rows.Length > 0)
                {
                    foreach (DataRow datarow in rows)
                    {
                        string Zeit = datarow["Zeiten"].ToString();
                        string Status = datarow["Status"].ToString();

                        for (int j = 0; j < timeSlots.Length; j++)
                        {
                            if (Zeit == timeSlots[j].ToString())
                            {
                                dgvRow[j + 1] = Status;
                            }
                        }
                    }
                }
            }
        }

        private string[] _GeneriereZeitraum()
        {
            TimeSpan interval = TimeSpan.FromMinutes(15);
            List<string> Zeitfenster = new List<string>();

            // Generiere Zeitfenster für den Vormittag
            _GeneriereZeitfensterFürZeitraum(TimeSpan.FromHours(8), TimeSpan.FromHours(12),
                interval, Zeitfenster);

            // Generiere Zeitfenster für den Nachmittag
            _GeneriereZeitfensterFürZeitraum(TimeSpan.FromHours(14), TimeSpan.FromHours(17),
               interval, Zeitfenster);

            return Zeitfenster.ToArray();
        }

        private void _GeneriereZeitfensterFürZeitraum(TimeSpan StartZeit, TimeSpan EndZeit, 
            TimeSpan Interval,  List<string> Zeitfenster )
        {
            TimeSpan AktuelleZeit = StartZeit;

            while (AktuelleZeit < EndZeit)
            {
                TimeSpan nextZeit = AktuelleZeit + Interval;

                if (nextZeit > EndZeit)
                    break;

                string ZeitfensterEintrag = $"{AktuelleZeit.ToString(@"hh\:mm")} - {nextZeit.ToString(@"hh\:mm")}";

                Zeitfenster.Add(ZeitfensterEintrag);

                AktuelleZeit = nextZeit;
            }
        }
        private void FarbeSetzenFürFreieUndBelegteTermine(DataGridView dataGridView1)
        {
            // Setze Farben für "Frei" und "Belegt"
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        // Färbe Zellen grün für "Frei"
                        if (cell.Value.ToString() == "Frei")
                        {
                            cell.Style.BackColor = Color.Green;
                            cell.Style.ForeColor = Color.White;
                        }
                        // Färbe Zellen rot für "Belegt"
                        else if (cell.Value.ToString() == "Belegt")
                        {
                            cell.Style.BackColor = Color.Red;
                            cell.Style.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private void FarbeFürWochenEndeSetzen(DataGridView dataGridView1)
        {
            // Gehe jede Zeile im DataGridView durch
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Überspringe leere Zeilen oder Zeilen ohne Zellen
                if (row.Cells.Count == 0 || row.Cells[0].Value == null)
                    continue;

                // Versuche, den Wert der ersten Zelle als Datum zu parsen
                if (DateTime.TryParse(row.Cells[0].Value.ToString(), out DateTime date))
                {
                    // Überprüfe, ob das Datum auf ein Wochenende fällt (Samstag oder Sonntag)
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        // // Setze die Hintergrundfarbe der gesamten Zeile auf Blau
                        foreach (DataGridViewCell cell in row.Cells)
                        {

                            cell.Style.BackColor = Color.LightGray;
                            cell.Style.ForeColor = Color.Black; // Weißer Text auf blauem Hintergrund
                        }
                        // Da diese Zeile bereits als Wochenende gefärbt wurde, überspringe den weiteren Status-Check
                        continue;
                    }
                }
            }
        }

        private void dgvDatenTabelle_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Überprüfen, ob ein Zellklick innerhalb der Datenzellen erfolgt ist
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {

                DataGridViewCell clickedCell = dgvDatenTabelle.Rows[e.RowIndex].Cells[e.ColumnIndex];

                //überprüfe Zellinhalt.
                string cellValue = clickedCell.Value.ToString() ?? string.Empty;
               if(cellValue == "Feiertag")
                {
                    return;
                }
                // Toggle between "Frei" and "Belegt" based on the flag
                var status = (isFrei) ? "Frei" : "Belegt";

                clickedCell.Value= status;
                _Status = clickedCell.Value.ToString();
                clickedCell.Style.BackColor = (isFrei) ? Color.Green : Color.Red;
                clickedCell.Style.ForeColor = Color.White;

                if(status == "Belegt")
                {
                    //Hole das Datum aus der ersten Spalte der angeklickten Zeile.
                    _Datum = Convert.ToDateTime(dgvDatenTabelle.Rows[e.RowIndex].Cells[0].Value);

                    //Hole die Zeit aus der angeklickten Zeile
                    _Zeit = dgvDatenTabelle.Columns[e.ColumnIndex].Name;

                }
                //Toggle the flag
                isFrei = !isFrei;
            }
        }

        private void btnÜbernehmen_Click(object sender, EventArgs e)
        {
            if (_Status == "Frei")
            {
                MessageBox.Show("Sie haben kein Datum reserviert", "Fehlermeldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // das Ondateback Ereignis auslösen und die Daten übergeben.
            RelaisDatenback(_Datum, _Zeit, _Status);
            this.Close();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
