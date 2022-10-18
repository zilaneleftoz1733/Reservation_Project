using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimari_Tasarım_proje
{
   public  class Otobus:IUlasim 
    {
        public int bilet_adedi { get; set; }

        public IUlasim IUlasim
        {
            get => default;
            set
            {
            }
        }

        public IUlasim IUlasim1
        {
            get => default;
            set
            {
            }
        }

        public DateTime gidisTarihi()
        {
            return gidisTarihi();
        }
        public DateTime donusTarihi()
        {
            return donusTarihi();
        }
        public string firmaAdi()
        {
            return firmaAdi();
        }
        public decimal fiyat()
        {
            return fiyat();
        }
    }
}
