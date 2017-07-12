using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    public class ProdVendido : ProdExport
    {
        public string _cliente;
        public ProdVendido(ProdExport productoExport, string cliente) : base(productoExport,productoExport._exportacion)
        {
            this._cliente = cliente;
        }
    }
}
