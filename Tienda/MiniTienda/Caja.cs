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
            //forech
            foreach (Productos producto in carrito.Lista)
            {
                total += producto.Cantidad * producto.Precio;
            }
        //CREAR METODO PAGAR
        Console.WriteLine($"El total a pagar es: {total:C}");
            Pagar(total);
        }
        public void Pagar(decimal total) 
        {
            Console.WriteLine("Seleccione el metodo de pago:");
            Console.WriteLine("1.Efectivo");
            Console.WriteLine("2.Fiado");

            string opcion = Console.ReadLine();
            bool pagoExitoso = false;
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("En efectivo");
                    pagoExitoso = ProcesarPagoEnEfectivo(total);
                    break;
            }
            if (pagoExitoso)
            {
                Console.WriteLine("El pago se ha realizado");
            }
            else 
            { Console.WriteLine("Te falta money");
            }
        }
    }
}