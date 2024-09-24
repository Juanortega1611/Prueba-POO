using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTienda
{
    class Carrito
    {
        public List<Productos> Lista { get; set; } = new List<Productos>();

        public void AgregarProducto(Productos productos)
        {
            Lista.Add(productos);
        }

        public void MostrarCarrito()
        {
            for (int p = 0; p < Lista.Count; p++)
            {
                Console.WriteLine($"Nombre: {Lista[p].Nombre}, " +
                    $"Cantidad: {Lista[p].Cantidad}," +
                    $"Precio: {Lista[p].Precio}," +
                    $"Total: {Lista[p].Cantidad * Lista[p].Precio}");
            }
        }
     }
}
