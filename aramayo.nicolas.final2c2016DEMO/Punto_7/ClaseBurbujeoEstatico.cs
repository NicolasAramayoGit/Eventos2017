using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_7
{
    public class ClaseBurbujeoEstatico
    {
        public static void metodoEstatico()
        {
            ClaseBurbujeoInstancia obj = new ClaseBurbujeoInstancia();

            try
            {
                obj.metodoInstancia();
            }
            catch (Exception ex)
            {

                throw new MiExcepcion("metodo estatico", ex);
            }
            

        }
    }
}
