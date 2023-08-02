using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeOrnek
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple =true, Inherited = true)]//fieldlarda geçerli olsun, birden fazla kez kullanılabilsin ve miras alınabilsin
    public class ZorunluAlanAttribute : Attribute
    {

    }
}
