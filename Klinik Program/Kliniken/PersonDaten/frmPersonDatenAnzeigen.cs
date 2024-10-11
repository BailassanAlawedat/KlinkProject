using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmPersonDatenAnzeigen : Form
    {
        private int _PersonID = -1;
        public frmPersonDatenAnzeigen(int PersonID, string Titelname = " Person Infos")
        {
            InitializeComponent();
            _PersonID = PersonID;
            lblTitel.Text = Titelname;
        }

        private void frmPersonDatenAnzeigen_Load(object sender, EventArgs e)
        {
            ctrPersonDaten1.LoadPersonData(_PersonID);
        }
    }
}
