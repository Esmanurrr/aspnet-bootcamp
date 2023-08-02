using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class OdemeFactory
    {
        public IOdeme GetInstance(string className)
        {
            //KrediKarti k = new KrediKarti();
            var newClass = System.Reflection.Assembly.GetAssembly(typeof(IOdeme)).CreateInstance("OdemeFormu." + className);
            return (IOdeme)newClass;
        }
    }
}

