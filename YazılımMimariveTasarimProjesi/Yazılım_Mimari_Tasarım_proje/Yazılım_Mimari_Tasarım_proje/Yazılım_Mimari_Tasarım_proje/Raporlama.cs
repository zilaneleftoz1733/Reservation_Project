using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimari_Tasarım_proje
{
    public abstract class Raporlama
    {
        public Rapor_Bilgileri raporbilgisi;
        public Raporlama(Rapor_Bilgileri rb)
        {
            this.raporbilgisi = rb;
        }
        public string CiktiOlustur()
        {
            string cikti = MusteriBilgileriOlustur();
            cikti += SeyahatBilgileriOlustur();
            return cikti;
        }
        public abstract string MusteriBilgileriOlustur();
        public abstract string SeyahatBilgileriOlustur();
    }
}