using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
     class Caja
    {
        private static int NumCompra = 0;
        public int Numero { get; set; }
        private decimal Pagando { get; set; }
        private Carrito Cart {get; set;}
        private float Subtotal = 0;
        private float Total=0;
        public Caja(int numero)
        {
            Numero = numero;
        }

        public void IngresarCarrito(Carrito cart)
        {
            Cart = cart;
            foreach(Articulo articulo in cart.Lista)
            {
                Subtotal += articulo.Precio * articulo.Cantidad;
            }
            MostrarTotales();
        }

        public void MostrarTotales()
        {
            float iva = Subtotal * .16f;
            Total = Subtotal + iva;

            Console.WriteLine($"Sub total : {Subtotal:C}");
            Console.WriteLine($"I.V.A : {Subtotal * .16:C}");
            Console.WriteLine($"Total : {Total:C}");

        }

        public void Cobrar()
        {
            Console.WriteLine("Ingrese Cantidad a pagar");
            Pagando = Convert.ToDecimal(Console.ReadLine());
            Cambio = (float)Pagando - Total;
            ImprimirTicket();

            {
                Lista = Cart.Lista,
                Total = Total,
                Subtotal = Subtotal,
                IVA = Subtotal * .16,
                Pagado = Pagando,
                Cambio = Cambio,
                Fecha = DateTime.Now,
                Num.Compra = Numero,
            };
            ticket.Imprimir();
        }

    }
}
