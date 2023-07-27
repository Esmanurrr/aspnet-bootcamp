using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class SmsOdeme : IOdeme
    {
        public string Ode(string tutar)
        {
            return "Sms ile " + tutar + " ödendi."; ;
        }
    }
}
