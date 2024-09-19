using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prueba;

public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   



        private void Form1_Load(object sender, EventArgs e)
        {
            var num1 = 7;
            var num2 = 5;
            Operaciones op=new Operaciones();
        int resultadosum = op.Suma(num1, num2);
        int resultadorest = op.Resta(num1, num2);
        int resultadomulti = op.Multiplicacion(num1, num2);
        int resultadodiv = op.Division(num1, num2);
        }

   
    }
    class Operaciones
    {
        public int Suma(int a, int b)
    {
        return a + b;
    }
        public int Resta(int a, int b)
    {
        return a - b;
    }
        public int Multiplicacion(int a, int b)
    {
        return a * b;
    }
        public int Division(int a, int b)
    {
        return a / b;
    }

}
//if/
using System;

public class Sentencias
{
    // Variable de instancia
    public int temperatura = 30;

    // Método para verificar la temperatura
    public void VerificarClima()
    {
        if (temperatura > 35)
        {
            Console.WriteLine("Hace mucho calor.");
        }
        else if (temperatura >= 20 && temperatura <= 35)
        {
            Console.WriteLine("El clima es agradable.");
        }
        else
        {
            Console.WriteLine("Hace frío.");
        }
    }
}
