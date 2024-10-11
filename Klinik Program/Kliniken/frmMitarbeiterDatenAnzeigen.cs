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
    public partial class frmMitarbeiterDatenAnzeigen : Form
    {
        public enum enAnzeigenMode { ByMitarbeiterID = 1, ByReinigungsPersonalMitarbeiterID = 2, 
                                    ByKüchenPersonalMitarbeiterID = 3, ByTransportdienstMitarbeiterID = 4,
                                    BySicherheitsdienstMitarbeiterId= 5}
        private enAnzeigenMode _Mode = enAnzeigenMode.ByMitarbeiterID;

        private int _MitarbeiterID = -1;
        private int _PersonID = -1;

        public frmMitarbeiterDatenAnzeigen(enAnzeigenMode Mode, int mitarbeiterId, int personID)
        {
            InitializeComponent();

            _Mode = Mode;
            _MitarbeiterID = mitarbeiterId;
            _PersonID = personID;
        }

        private void frmMitarbeiterDatenAnzeigen_Load(object sender, EventArgs e)
        {
            _LoadPersonDaten();
            _LoadMitarbeiterDaten();
        }

        private void _LoadPersonDaten()
        {
            ctrPersonDaten1.LoadPersonData(_PersonID);
        }
        private void _LoadMitarbeiterDaten()
        {
            switch(_Mode)
            {
                case enAnzeigenMode.ByMitarbeiterID:
                    {
                        ctrMiratbeiterKarte1.LoadMitarbeiterDatenByMitarbeiterID(_MitarbeiterID);
                        break;
                    }
                case enAnzeigenMode.ByReinigungsPersonalMitarbeiterID:
                    {
                        ctrMiratbeiterKarte1.LoadReinigungsPersonalDatenByMitarbeiterID(_MitarbeiterID);
                        break;
                    }
                case enAnzeigenMode.ByKüchenPersonalMitarbeiterID:
                    {
                        ctrMiratbeiterKarte1.LoaKüchenPersonalDatenByMitarbeiterID(_MitarbeiterID);
                        break;
                    }
                case enAnzeigenMode.ByTransportdienstMitarbeiterID:
                    {
                        ctrMiratbeiterKarte1.LoadTransportdiensteByMitarbeiterID(_MitarbeiterID);
                        break;
                    }
                case enAnzeigenMode.BySicherheitsdienstMitarbeiterId:
                    {
                        ctrMiratbeiterKarte1.LoadSicherheitsdiensteByMitarbeiterID(_MitarbeiterID);
                        break;
                    }

            }
        }
    }
}
