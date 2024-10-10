using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.abstractas
{
    internal class Rectangulo : Figura
    {
        public double B;
        public double H;
        public int MedidaLado { get; set; }
        public Rectangulo(double largo, double ancho)
        {
            B = largo;
            H = ancho;
        }

        public Rectangulo()
        {
        }

        public override void CalculaArea()
        {
            Double Area = B * H;

        }

        public override void CalcularPerimetro()
        {
            Perimetro = MedidaLado * 4;
        }
    }
}
