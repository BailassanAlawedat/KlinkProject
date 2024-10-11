using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public abstract class clsPersonal
    {
        public abstract int PersonalID { get; set; }
        public abstract int MitabeiterID { get; set; }
        public abstract string Bereichname { get; set; }
        public abstract bool Save();

        public abstract bool Delete();
    }
}
