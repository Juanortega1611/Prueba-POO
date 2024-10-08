using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona2 persona2 = 
                new Persona2("Juan",
                "josesantanas1110@gmail.com",1);
            Console.ReadLine();
            persona2.Nombre = "Angel";
            persona2.Email = "angel@gmail";
            persona2.ImprimeNombre();
            persona2.ImprimeEmail();
            persona2.CambiarFecha(DateTime.Now);
            persona2.ImprimeFecha();
            Console.ReadLine();
        }
    }
}
