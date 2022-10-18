using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimari_Tasarım_proje
{
     public class Rapor_Bilgileri
    {
                   
            private string ad;
            private string soyad;
            private int tcno;

            
            private string konaklama;
            private string ulasim;
            private string gidistarihi;
            private string fiyat;

           
            public string Ad { get { return ad; } set { this.ad = value; } }
            public string Soyad { get { return soyad; } set { this.soyad = value; } }
            public int TCNO { get { return tcno; } set { this.tcno = value; } }

            

            public string Konaklama { get { return konaklama; } set { this.konaklama = value; } }
            public string Ulasim { get { return ulasim; } set { this.ulasim = value; } }
            public string GidisTarihi { get { return gidistarihi; } set { this.gidistarihi = value; } }
            public string Fiyat { get { return fiyat; } set { this.fiyat = value; } }


        }
    }

