using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Reflection
{
    public class MyClass
    {
        
            public int x;
            public int y;
            private void MesajGoster()
            {
                Console.WriteLine("x in degeri : " + x + "y nin değeri " + y);
            }
            public string MesajDon()
            {
                return " bir mesaj";
            }
            public MyClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public bool IsBeetwen(int i)
            {
                if (i > 0) return true;
                return false;
            }
        
    }
}
