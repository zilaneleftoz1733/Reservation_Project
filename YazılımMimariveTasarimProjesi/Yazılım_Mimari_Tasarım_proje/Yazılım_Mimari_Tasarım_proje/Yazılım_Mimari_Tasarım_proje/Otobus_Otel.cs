using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimari_Tasarım_proje
{
     public class Factory_Otobus_Otel:Rezervasyon_Factory
    {
        public Otel Otel
        {
            get => default;
            set
            {
            }
        }

        public Otobus Otobus
        {
            get => default;
            set
            {
            }
        }

        public override IKonaklama KonaklamaOlusturmak(IKonaklama b)
        {
            return new Otel();
        }
        public override IUlasim UlasimOlusturmak(IUlasim a)
        {
            return new Otobus();

        }
    }
}
