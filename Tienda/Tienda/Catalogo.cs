using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Catalogo
    {
        private static List<Articulo> Inventario { get; set; }

        private static void LlenarCatalogo()
        {
            Inventario = new List<Articulo>
            {
                new Articulo{ID=1,Nombre="Jabon",Precio=18.9f},
                new Articulo{ID=2,Nombre="Mayonesa",Precio=45.13f},
                new Articulo{ID=3,Nombre="Tomate",Precio=49.00f},
                new Articulo{ID=4,Nombre="Carne",Precio=98.00f},
                new Articulo{ID=5,Nombre="Huevo",Precio=65.00f},
                new Articulo{ID=6,Nombre="Aceite",Precio=45.50f},
                new Articulo{ID=7,Nombre="Jamón",Precio=125.3f},
                new Articulo{ID=8,Nombre="Sabritas",Precio=30.00f},
                new Articulo{ID=9,Nombre="Coca-Cola",Precio=53.2f},
                new Articulo{ID=10,Nombre="Sopa",Precio=23.00f},
                new Articulo{ID=11,Nombre="Cafe",Precio=45.54f},
                new Articulo{ID=12,Nombre="Azucar",Precio=35.5f},
                new Articulo{ID=13,Nombre="Sal",Precio=70.10f},
                new Articulo{ID=14,Nombre="Leche",Precio=25.90f},
                new Articulo{ID=15,Nombre="Cebolla",Precio=20.99f},
            };
        }

        public static void MostrarCatalogo()
        {
            LlenarCatalogo();
            foreach (Articulo art in Inventario) 
            {
                Console.Write($"{art.ID} - {art.Nombre} - {art.Precio:C}");
            }
        }
        public static Articulo BuscarArticulosPorId(int artID)
        {
            return Inventario.Find(Articulo => Articulo.ID.Equals(artID));
        }
    }
}
