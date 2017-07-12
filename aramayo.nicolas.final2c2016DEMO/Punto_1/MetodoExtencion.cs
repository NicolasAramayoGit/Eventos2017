using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    public static class MetodoExtencion
    {
        public static bool EsPar(this Int32 valor)
        {
            return valor % 2 == 0;
        }

        
        public static bool EsImpar(this Int32 valor)
        {
            return valor.EsPar();
        }

    }
}
