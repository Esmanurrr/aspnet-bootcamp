using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class MailOrder : IOdeme
    {
        public string Ode(double tutar)
        {
            return "Mail Order ile " + tutar + " ödendi.";
        }
    }
}
