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
    public partial class frmArztDatenAnzeigen : Form
    {
        private int _PersonID = -1;
        private int _ArztID = -1;
        private string _Fachrichtung = "";
        public frmArztDatenAnzeigen(int ArztID, int personID, string Fachrichtung)
        {
            InitializeComponent();
            _ArztID = ArztID;
            _PersonID = personID;
            _Fachrichtung = Fachrichtung;
        }

        private void frmArztDatenAnzeigen_Load(object sender, EventArgs e)
        {
            _LoadArztData();
        }

        private void _LoadArztData()
        {
            if (_PersonID != -1)
                ctrPersonDaten1.LoadPersonData(_PersonID);

            lblArztID.Text = _ArztID.ToString();
            lblFachrichtung.Text = _Fachrichtung;
        }
    }
}
