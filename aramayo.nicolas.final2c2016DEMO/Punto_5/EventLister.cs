using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5
{
    public class EventListerner<T>
    {
        string archivo = null;

        public void MetodoQueEscucha(Galpon<T> migalpon, string rutaArchivo)
        {
            this.archivo = rutaArchivo;

            migalpon.EsImpar += migalpon_EsImpar;

            Console.WriteLine("Ingrese una cantidad: ");

            migalpon.Cantidad = int.Parse(Console.ReadLine()); ;
        }

        void migalpon_EsImpar(object obj, EventArgs args)
        {

            try
            {
                using (StreamWriter escritor = new StreamWriter(archivo, true))
                {
                    escritor.WriteLine(obj);

                    Console.WriteLine("El txt se guardo con exito");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("El archivo no se ha podido guardar", ex);
            }
        }
    }
}
