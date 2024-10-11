using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public static class clsDatenTabelleAnzeigen
    {
        private static  bool isFrei = true;

        private static  DataGridView dataGridView1;

        public static void  DataGridViewEinrichten(DataGridView dataGridView1)
        {
            _LoadDataInDataGridView(dataGridView1);

            FarbeFürWochenEndeSetzen(dataGridView1);

            FarbeSetzenFürFreieUndBelegteTermine(dataGridView1);
        }
        private static void _LoadDataInDataGridView(DataGridView dataGridView1)
        {
            // Define time slots
            string[] timeSlots = { "08:00 - 08:30", "08:30 - 09:00", "09:30 - 10:00", "10:30 - 11:00",
            "11:30 - 12:00", "14:00 - 14:30", "14:30 - 15:00", "15:30 - 16:00","16:30 - 17:00"};

            int daysInThreeMonths = 360; // Annäherung für drei Monate

            // Setze Spalten für das DataGridView
            dataGridView1.ColumnCount = timeSlots.Length + 1; // +1 für das Datum
            dataGridView1.Columns[0].Name = "Datum"; // Name der ersten Spalte
            for (int i = 0; i < timeSlots.Length; i++)
            {
                // Setze Namen für die Zeitfenster-Spalten
                dataGridView1.Columns[i + 1].Name = timeSlots[i];
            }

            // Generiere Beispieldaten für drei Monate
            DateTime startDate = DateTime.Now.Date; // Startdatum (heute)
            for (int i = 0; i < daysInThreeMonths; i++)
            {
                string[] row = new string[timeSlots.Length + 1]; // Array für eine Zeile
                DateTime currentDate = startDate.AddDays(i); // Berechne das Datum für den aktuellen Tag

                // Überspringe vergangene Tage
                if (currentDate < DateTime.Now.Date)
                {
                    continue;
                }

                row[0] = currentDate.ToString("dd.MM.yyyy"); // Datum in die erste Spalte einfügen
                for (int j = 1; j <= timeSlots.Length; j++)
                {
                    if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        row[j] = "Feiertag";
                    }
                    else
                        row[j] = "Frei"; // Alle Zeitfenster sind anfangs frei
                }
                dataGridView1.Rows.Add(row); // Füge die Zeile zum DataGridView hinzu
            }
        }

        private static  void FarbeSetzenFürFreieUndBelegteTermine(DataGridView dataGridView1)
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

        private static  void FarbeFürWochenEndeSetzen(DataGridView dataGridView1)
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
                        // Setze die Hintergrundfarbe der gesamten Zeile auf Blau
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Style.BackColor = Color.Blue;
                            cell.Style.ForeColor = Color.White; // Weißer Text auf blauem Hintergrund
                        }
                        // Da diese Zeile bereits als Wochenende gefärbt wurde, überspringe den weiteren Status-Check
                        continue;
                    }
                }
            }
        }
        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Überprüfen, ob ein Zellklick innerhalb der Datenzellen erfolgt ist
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

        //        // Toggle between "Frei" and "Belegt" based on the flag
        //        if (clickedCell.Value.ToString() == "Frei" || clickedCell.Value.ToString() == "Belegt")
        //        {
        //            if (isFrei)
        //            {
        //                clickedCell.Value = "Frei";
        //                clickedCell.Style.BackColor = Color.Green;
        //                clickedCell.Style.ForeColor = Color.White;
        //            }
        //            else
        //            {
        //                clickedCell.Value = "Belegt";
        //                clickedCell.Style.BackColor = Color.Red;
        //                clickedCell.Style.ForeColor = Color.White;
        //            }
        //        }

        //        // Toggle the flag
        //        isFrei = !isFrei;

        //    }
        //}
    }
}

