using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniTienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();
            bool continuar = true;
            while (continuar)
            {
                //PEDIR PRODUCTOS HASTA QUE EL USUARIO QUIERA
                string nombre = "";
                int cantidad = 0;
                decimal precio = 0;
                Console.WriteLine("Ingresa nombre del producto");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese cantidad");
                cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese precio");
                precio = Convert.ToDecimal(Console.ReadLine());

                if (continuar)
                {
                    Console.WriteLine("¿Quieres agregar otro producto?");
                    Console.WriteLine("S- Yes");
                    Console.WriteLine("N- Not");
                    continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                    Console.Clear();
                }


                //FORMA DE CREAR UNA INSTANCIA
                Productos prod = new Productos();
                prod.Nombre = nombre;
                prod.Cantidad = cantidad;
                prod.Precio = precio;
                carrito.AgregarProducto(prod);


                //FORMA 2 DE CREAR INSTANCIA
                //Producto prod2 = new Produco()
                //{
                //  Nombre = nombre,
                //  Cantidad = cantidad,
                //  Precio = precio
                //};
                carrito.MostrarCarrito();
                Caja caja = new Caja();
                caja.Cobrar(carrito);
                Console.ReadLine();

            }
        }
    }
}
