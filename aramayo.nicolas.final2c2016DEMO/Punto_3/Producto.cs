using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    public class Producto
    {
        private string _nombre;
        private int _stock;

        public int Stock
        {
            get
            {
                return this._stock;
            }

            set
            {
                this._stock = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }

            set
            {
                this._nombre = value;
            }
        }

        /// <summary>
        /// constructor que toma dos parametros nombre del producto y el stock.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        public Producto(string nombre, int stock)
        {
            this._nombre = nombre;
            this._stock = stock;
        }


        

       

        /// <summary>
        /// Devuelvo un producto con el stock
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static int operator +(Producto p1, Producto p2)
        {
            return p1._stock + p2._stock;
        }

        

    }
}
