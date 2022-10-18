using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimari_Tasarım_proje
{
    public abstract class Rezervasyon_Factory
    {
        public abstract IUlasim UlasimOlusturmak(IUlasim a);
        public abstract IKonaklama KonaklamaOlusturmak(IKonaklama b);
    }
}
