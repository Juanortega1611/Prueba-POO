using MiniTienda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTienda
{
     class Caja
    {
        //MOSTRAR LA LISTA DE PRODUCTOS Y TOTAL DEL CARRITO
        public void Cobrar(Carrito carrito)
        {
            decimal total = 0;
            //foreach
            foreach (Productos producto in carrito.Lista)
            {
                total = total+ producto.Cantidad * producto.Precio;
            }
         //CREAR METODO PAGAR
            Console.WriteLine($"El total a pagar es: {total:C}");
        }
    }
}