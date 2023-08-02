using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeOrnek
{
    public static class ZorunlulukKontrolu
    {
        public static bool Dogrula(object dogrulanacakEntity)
        {
            Type dogrulanacakTur = dogrulanacakEntity.GetType();
            FieldInfo[] dogrulanacakTurAlanlari = dogrulanacakTur.GetFields(BindingFlags.Instance | BindingFlags.Public);//kendisine gelen classın fieldlarına eriştik
            foreach(FieldInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);//burdaki fieldlarda attribute var mı?

                if(zorunluAlanOznitelikleri.Length != 0)
                {
                    string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakEntity) as string;
                    if (string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
