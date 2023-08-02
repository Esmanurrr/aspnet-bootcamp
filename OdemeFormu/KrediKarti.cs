using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class KrediKarti : IOdeme
    {
        public string Ode(double tutar)
        {
            return "Kredi kartı ile " + tutar + " ödendi.";
        }

    }
}
