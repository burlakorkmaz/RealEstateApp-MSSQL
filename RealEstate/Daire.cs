using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    class Daire:EmlakBilgisi
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
        string tuvalet;
        public string Tuvalet
        {
            get { return tuvalet; }
            set { tuvalet = value; }
        }
        string banyo;
        public string Banyo
        {
            get { return banyo; }
            set { banyo = value; }
        }

    }
}
