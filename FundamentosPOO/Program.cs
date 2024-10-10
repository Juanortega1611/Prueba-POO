using FundamentosPOO.abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{
    internal class Program
    {
        //TAREA:
        //INVESTIGAR LAS CLASES ABSTRACTAS CON EJEMPLOS
        static void Main(string[] args)
        {
            //Persona2 persona2 = 
            //    new Persona2("Juan",
            //"josesantanas1110@gmail.com",1);
            //Console.ReadLine();
            // persona2.Nombre = "Angel";
            // persona2.Email = "angel@gmail";
            // persona2.ImprimeNombre();
            // persona2.ImprimeEmail();
            // persona2.CambiarFecha(DateTime.Now);
            // persona2.ImprimeFecha();


            Cuadrado cuadrado = new Cuadrado()
            {
                MedidaLado = 5,
                UnidadMedida = "Metros"
            };
            cuadrado.MuestraArea();
            cuadrado.MuestraPerimetro();
            cuadrado.MedidaLado = 8;
            cuadrado.MuestraArea();

            //TAREA:
            //HACER LA IMPLEMENTACION PARA RECTANGULO, CIRCULO, TRIANGULO Y POLIGONO

            Console.ReadLine();
        }
        Rectangulo rectangulo = new Rectangulo()
        {
            MedidaLado = 5,
            UnidadMedida = "Metros"
        };
            cuadrado.MuestraArea();
            cuadrado.MuestraPerimetro();
            cuadrado.MedidaLado = 8;
            cuadrado.MuestraArea();

            //TAREA:
            //HACER LA IMPLEMENTACION PARA RECTANGULO, CIRCULO, TRIANGULO Y POLIGONO

            Console.ReadLine();
        }
}
}
