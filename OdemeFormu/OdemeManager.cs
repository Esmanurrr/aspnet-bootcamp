using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class OdemeManager
    {
        IOdeme iOdeme;
        public OdemeManager(IOdeme iOdeme)
        {
            this.iOdeme = iOdeme;
        }

        public string Ode(string tutar)
        {
            return iOdeme.Ode(tutar);
        }
    }
}
