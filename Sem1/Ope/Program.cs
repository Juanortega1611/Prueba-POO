using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ope
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var num1 = 7;
            var num2 = 5;
            operaciones op = new operaciones();
            int resultadosum = op.suma(num1, num2);
            int resultadorest = op.resta(num1, num2);
            int resultadomulti = op.multiplicacion(num1, num2);
            int resultadodivi = op.divicion(num1, num2);
        }
    }
    class operaciones
    {
        public int suma(int a, int b)
        {
            return a + b;
        }
        public int resta(int a, int b)
        {
            return a - b;
        }
        public int multiplicacion(int a, int b)
        {
            return a * b;
        }
        public int divicion(int a, int b)
        {
            return a / b;
        }
    }
}