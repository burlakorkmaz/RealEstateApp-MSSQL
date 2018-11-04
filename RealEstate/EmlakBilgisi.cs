using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RealEstate
{
    abstract class EmlakBilgisi
    {

        string hometype;
        public string homeType
        {
            get { return hometype; }
            set { hometype = value; }
        }

        double metrekare;
        public double metreKare
        {
            get { return metrekare; }
            set { metrekare = value; }
        }

        string kiraliksatilik;

        public string kiralikSatilik
        {
            get { return kiraliksatilik; }
            set { kiraliksatilik = value; }
        }
        string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        string soyad;
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        double ucret;
        public double Ucret
        {
            get { return ucret; }
            set { ucret = value; }
        }
        double telno;
        public double telNo
        {
            get { return telno;}
            set { telno = value; }
        }
        int kayitsil = 0;
        public int kayitSil
        {
            get { return kayitsil; }
            set { kayitsil = value; }
        }


    }
}
