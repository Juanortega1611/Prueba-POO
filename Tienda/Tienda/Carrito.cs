using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Carrito
    {
        public List<Articulo> Lista { get; set; }

        public Carrito()
        {
            Lista = new List<Articulo>();
        }
        public void AgregarArticulo(Articulo articulo)
        {
            Lista.Add(articulo);
        }
    }
}