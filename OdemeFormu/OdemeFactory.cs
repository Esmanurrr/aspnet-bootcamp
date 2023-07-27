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
            var newClass = System.Reflection.Assembly.GetAssembly(typeof(IOdeme)).CreateInstance(className);
            return (IOdeme)newClass;
        }
    }
}

