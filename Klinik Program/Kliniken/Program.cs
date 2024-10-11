using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmAktualisierenUndNeueArztHinzufügen());
            /// Application.Run(new frmNeuePersonHinzufügen());
            // Application.Run(new frmPersonenListeAnziegen());
            // Application.Run(new frmUpdateUndNeuPatientHinzufügen());
            // Application.Run(new frmPatientListeAnzeigen());
            //Application.Run(new frmMainSystemScreen());
            //Application.Run(new frmFachrichtungenListeAnzeigen());
            //Application.Run(new frmÄrzteListeAnzeigen());
            // Application.Run(new frmAktualisierenUndNeueBezahlungHinzufügen());
            //Application.Run(new frmTerminenListeAnzeigen());
            // Application.Run(new frmAktualisierenUndNeuenBenutzerHinzufügen());
            Application.Run(new frmLoginScreen());
            // Application.Run(new frmBenutzerListeAnzeigen());
            //Application.Run(new frmDatenTablleAnzeigen());

            //Application.Run(new frmMitarbeiterListeAnzeigen());

        }
    }
}
