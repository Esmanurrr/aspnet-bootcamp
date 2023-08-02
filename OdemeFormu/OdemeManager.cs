using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class OdemeManager
    {
        public IOdeme iOdeme;
        public OdemeManager(IOdeme iOdeme)
        {
            this.iOdeme = iOdeme;
        }

        public string Ode(double tutar)
        {
            return iOdeme.Ode(tutar);
        }
    }
}
