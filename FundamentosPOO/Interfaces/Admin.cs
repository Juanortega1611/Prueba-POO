using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Interfaces
{
    internal class Admin : IUsuario
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Nivel { get; set; }
        public bool ActualizaPerfil(string nombre, string Email)
        {
            //ACTUALIZAR INFORMACION
            return true;
        }

        public void login()
        {
            //HACER CONEXION A BASE DE DATOS Y BUSCAR EN LA TABLA ADMINS
            Console.WriteLine("Usuario logeado");
        }
    }
}
