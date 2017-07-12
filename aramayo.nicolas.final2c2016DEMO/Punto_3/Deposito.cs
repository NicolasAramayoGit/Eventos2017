using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    [Serializable]
    public class Deposito
    {
        public Producto[] _productos;

        

        /// <summary>
        /// Constructor por defecto, inicializa el array productos en 3 elementos;
        /// </summary>
        public Deposito()
        {
            this._productos = new Producto[3];
        }

        /// <summary>
        /// Constructor que inicializa la cantidad del array productos, pasado por parametro.
        /// </summary>
        /// <param name="cantidadElementos"></param>
        public Deposito(int cantidadElementos)
        {
            this._productos = new Producto[cantidadElementos];
        }

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            bool ElementoRepetido = false;
            Producto[] aux;
            aux = new Producto[d1._productos.Length + d2._productos.Length];

            // Agrego vector d1 al vector auxiliar.
            for (int i = 0; i < d1._productos.Length; i++)
            {
                aux[i] = d1._productos[i];
            }
            
            // Comparo los vectores auxiliar y d2 para sumar stock.
            for (int i = 0; i < d2._productos.GetLength(0); i++)
            {
                for (int j = 0; j < aux.Length; j++)
                {
                    if (aux[j] != null && d2._productos[i] != null)
                    {
                        if (aux[j].Nombre == d2._productos[i].Nombre)
                        {
                            aux[j].Stock = aux[j].Stock + d2._productos[i].Stock;
                            ElementoRepetido = true;
                        } 
                    }
                }

                // Si el producto no esta repetido lo agrego, al primer elemento en null.
                if (!ElementoRepetido)
                {
                    for (int k = 0; k < aux.Length; k++)
                    {
                        if (aux[k] == null)
                        {
                            aux[k] = d2._productos[i];
                            break;
                        }
                    }
                }

                ElementoRepetido = false;
            }

            return aux;


        }


        //public static List<Producto> operator +(Deposito uno, Deposito dos)
        //{
        //    List<Producto> lista = new List<Producto>();
        //    bool estaEnLaLista = false;

        //    foreach (Producto itemUno in uno.Lista)
        //    {
        //        lista.Add(itemUno);
        //    }
        //    foreach (Producto itemDos in dos.Lista)
        //    {
        //        for (int i = 0; i < lista.Count; i++)
        //        {
        //            if (itemDos == lista[i])
        //            {
        //                lista[i].Stock += itemDos.Stock;
        //                estaEnLaLista = true;
        //            }
        //        }
        //        if (!estaEnLaLista)
        //        {
        //            lista.Add(itemDos);
        //        }
        //    }

        //    return lista;
        //}


    }
}
