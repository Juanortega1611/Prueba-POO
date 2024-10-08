using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
     class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
                bool Agregar = true;
                Carrito cart = new Carrito();
                while (Agregar)
                { 
                    Catalogo.MostrarCatalogo();
                    Console.WriteLine("Selecciona el articulo");
                    int artID = Convert.ToInt32(Console.ReadLine());

                    Articulo articuloSeleccionado = Catalogo.BuscarArticuloPorID(artID);
                    Console.WriteLine("Cuanta cantidad comprara?");
                    articuloSeleccionado.Cantidad.ToInt32(Console.ReadLine());
                    //TAREA
                    //AGREGAR EL ARTICULO AL CARRITO
                    Carrito cart = new Carrito();
                    cart.AgregarArticulo(articuloSeleccionado);

            //IR A LA CAJA
            Caja caja = new Caja(1);
            //MOSTRAR TOTAL
            caja.IngresarCarrito(cart);
            //COBRAR Y PAGAR
            //DEVOLVER CAMBIO
            //IMPRIMIR TICKET
            caja.Cobrar();


            Console.ReadLine();


        }
    }
}
