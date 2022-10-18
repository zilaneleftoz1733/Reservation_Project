using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimari_Tasarım_proje
{
    public abstract class odeme
    {
        public int tutar { get; set; }
        public abstract string OdemeYap();

    }
}
