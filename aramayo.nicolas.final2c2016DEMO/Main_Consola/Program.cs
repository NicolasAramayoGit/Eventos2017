using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// REFERENCIAS.
using Punto_3;
using Punto_4;
using Punto_7;
using Punto_5;

namespace Main_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PUNTO N°1
            Console.WriteLine("PUNTO N°1:");
            Console.WriteLine(32.EsPar());
            Console.WriteLine(32.EsImpar());

            Console.ReadKey();
            #endregion

            #region PUNTO N°2

            Console.WriteLine("PUNTO NUMERO 2:");

            Stack<Double> pila = new Stack<double>();

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);

            // CREO UNA PILA AUXILIAR.
            Stack<Double> pila_aux = new Stack<double>();

            // INVIERTO LOS ELEMENTOS DE LA PILA A UNA PILA AUXILIAR.
            while (pila_aux.Count != 3)
            {
                pila_aux.Push(pila.Pop());
            }

            // LE ASIGNO LA PILA AUXILIAR A LA PILA ORIGINAL.
            pila = pila_aux;

            // MUESTRO LA PILA.
            while (pila.Count != 0)
            {
                Console.WriteLine(pila.Pop());
            }

            Console.ReadKey();

            #endregion

            #region PUNTO N°3
            Console.WriteLine("PUNTO NUMERO 3:");



            Deposito objDeposito = new Deposito(3);
            Deposito objDeposito2 = new Deposito(3);

            Producto prodUno = new Producto("gaseosa", 10);
            Producto prodDos = new Producto("yerba", 15);
            Producto prodTres = new Producto("azucar", 25);

            Producto prodCuatro = new Producto("gaseosa", 10);
            Producto prodCinco = new Producto("leche", 30);
            Producto prodSeis = new Producto("galletitas", 50);


            // Agrego los productos a los depositos.
            objDeposito._productos.SetValue(prodUno, 0); // gaseosa
            objDeposito._productos.SetValue(prodDos, 1);
            objDeposito._productos.SetValue(prodTres, 2);

            objDeposito2._productos.SetValue(prodCuatro, 0); // gaseosa
            objDeposito2._productos.SetValue(prodCinco, 1);
            objDeposito2._productos.SetValue(prodSeis, 2);

            Producto[] productos;

            productos = objDeposito + objDeposito2;


            Console.ReadKey();


            #endregion

            #region PUNTO N°4
            Console.WriteLine("PUNTO NUMERO 4:");

            Producto pro = new Producto("Pala", 22);
            ProdImpuesto pI = new ProdImpuesto(pro.Nombre, pro.Stock, 600.33);
            ProdExport pEX = new ProdExport(pI, "Argentina");
            ProdVendido p = new ProdVendido(pEX, "Cliente Juan");

            Console.ReadKey();
            #endregion

            #region PUNTO N°5

            Galpon<string> miGalpon = new Galpon<string>();

            miGalpon._lista.Add("producto1");
            miGalpon._lista.Add("producto2");
            miGalpon._lista.Add("producto3");


            //miGalpon.EsImpar += miGalpon_EsImpar;

            //Console.WriteLine("Ingrese una cantidad");

            //miGalpon.Cantidad = int.Parse(Console.ReadLine());

            EventListerner<string> claseQueEscucha = new EventListerner<string>();


            claseQueEscucha.MetodoQueEscucha(miGalpon, "log.txt");



            Console.ReadKey();

            #endregion

            #region PUNTO N°7
            Console.WriteLine("Punto NUMERO 7:");
            try
            {
                ClaseBurbujeoEstatico.metodoEstatico();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message + ex.Message + "Program");
            }

            Console.ReadKey();


            #endregion

        }
    }


    // PUNTON N°1.

    static class MyClass
    {
        /// <summary>
        /// Método de extención determina si es par.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool EsPar(this Int32 valor)
        {
            return valor % 2 == 0;
        }

        /// <summary>
        /// Método de extención que determina si es impar, reutiliza código.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool EsImpar(this Int32 valor)
        {
            return valor.EsPar();
        }
    }


}
