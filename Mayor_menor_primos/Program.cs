using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_menor_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("0- Salir");
                Console.WriteLine("1- Validar numeros primos");
                Console.WriteLine("2- Validar numero mayor y numero menor de 3 numeros");
                Console.WriteLine("3- Numero mayor de una lista");
                Console.WriteLine("4- Numero menor de una lista");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        continuar = false;
                        break;
                    case 1:
                        NumerosPirmos();
                        break;
                    case 2:
                        NumeroMayorNUmeroMenor();
                        break;
                    case 3:
                        MayorDeUnaLista();
                        break;
                    case 4:
                        MenorDeUnaLista();
                        break;
                }
                if (continuar)
                {
                    Console.WriteLine("Desea realizar otra operacion");
                    Console.WriteLine("S- SI");
                    Console.WriteLine("N- NO");
                    continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                    Console.Clear();
                }
            }
            Console.ReadLine();
        }
        private static void NumerosPirmos()
        {
            int n = 0;
            Console.WriteLine("Dame un numero mayor a 1");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Numero no valido");
            }
            for (int i = 2; i <= n; i++)
            {
                if (IsPrimo(i))
                {
                    Console.WriteLine($"{i} es primo");
                }
            }
            Console.WriteLine();
        }

        private static bool IsPrimo(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void NumeroMayorNUmeroMenor()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Dame el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            NumeroMayor(num1, num2, num3);
            NumeroMenor(num1, num2, num3);
        }
        private static void NumeroMayor(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El primer numero es el mayor");
                }
                else
                {
                    Console.WriteLine("El tercer numero es el mayor");
                }

            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El segundo numero es el mayor");
                }
                else
                {
                    Console.WriteLine("El tercer numero es el mayor");
                }
            }

        }

        private static void NumeroMenor(int num1, int num2, int num3)
        {
            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine("El primer numero es el menor");
                }
                else
                {
                    Console.WriteLine("El tercer numero es el menor");
                }

            }
            else if (num2 < num1)
            {
                if (num2 < num3)
                {
                    Console.WriteLine("El segundo numero es el menor");
                }
                else
                {
                    Console.WriteLine("El tercer numero es el menor");
                }
            }
        }

        private static void MayorDeUnaLista()
        {
            bool continuar = true;
            List<int> lista = new List<int>();
            while (continuar)
            {
                Console.WriteLine("Escribe un numero");
                int numero = Convert.ToInt32(Console.ReadLine());
                lista.Add(numero);
                Console.WriteLine("¿Quieres agregar otro numero");
                Console.WriteLine("S- Yes");
                Console.WriteLine("N- Not");
                continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                Console.Clear();
            }
            bool esMayor = false;
            int Mayor = 0;
            for (int i = 0; i < lista.Count; i++) //FOR 1
            {
                int N = lista[i]; //Obtener numero de lista
                for(int j = 0; j <lista.Count; j++) //FOR 2
                {
                    int M = lista[j]; //Obtener numero del segundo for
                    if (N < M)
                    {
                        esMayor = false;
                        break;
                    }
                    else
                    {
                            esMayor = true;
                      
                    }
                }
                // si aun no se ha encontrado el mayor,
                //pasa a la siguiente iteracion del for 1
                if (!esMayor)
                {
                    Mayor = N;
                    break;
                }
            }
            Console.WriteLine($"El numero mayor es: {Mayor}");
        }
        private static void MenorDeUnaLista()
        {
            bool continuar = true;
            List<int> lista = new List<int>();
            while(continuar)
            {
                Console.WriteLine("Escribe un numero");
                int numero = Convert.ToInt32(Console.ReadLine());
                lista.Add(numero);
                Console.WriteLine("S- Yes");
                Console.WriteLine("N- Not");
                continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                Console.Clear();
            }
            if (lista.Count > 0)
            {
                int menor = lista.Min();
                Console.WriteLine($"El numero menor es: {menor}");
            }

        }
    }
    
}