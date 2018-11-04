using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    class Konut:EmlakBilgisi
    {
        int salonsayisi;
        public int salonSayisi
        {
            get { return salonsayisi; }
            set { salonsayisi = value; }
        }

        int odasayisi;
        public int odaSayisi
        {
            get { return odasayisi; }
            set { odasayisi = value; }
        }
        int balkonsayisi;
        public int balkonSayisi
        {
            get { return balkonsayisi; }
            set { balkonsayisi = value; }
        }
        int katsayisi;
        public int katSayisi
        {
            get { return katsayisi; }
            set { katsayisi = value; }
        }
    }
}
