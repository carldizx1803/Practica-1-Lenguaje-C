using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECUACIONES_SEGUNDO_GRADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA;
            int numB;
            int numC;
            double formulAarriba = 0;
            double formulAbajo = 0;

            Console.Clear();
            Console.Write(" BIENVENIDO A LA CÁLCULADORA FÓRMULA GENERAL");
            Console.Write(" ");
            Console.Write(" ");
            Console.Write(" ");
            System.Threading.Thread.Sleep(3000);
            Console.Write(" ");
            Console.Write(" ");
            Console.Write(" ");
            Console.Write("\n ax2+bx+c=0 \n");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            // VARIABLE A
            Console.WriteLine("¿Cuál es el valor de A? \n Ingréselo:");
            numA = Convert.ToInt32(Console.ReadLine());

            // VARIABLE B
            Console.WriteLine("¿Cuál es el valor de B? \n Ingréselo:");
            numB = Convert.ToInt32(Console.ReadLine());

            // VARIABLE C
            Console.WriteLine("¿Cuál es el valor de C? \n Ingréselo:");
            numC = Convert.ToInt32(Console.ReadLine());

            // OPERACIÓN ARRIBA
            formulAarriba = ((-1 * numB) + Math.Sqrt(Math.Pow(numB, 2) - (4 * numA * numC))) / (2 * numA);
            // OPERACIÓN ABAJO
            formulAbajo = ((-1 * numB) - Math.Sqrt(Math.Pow(numB, 2) - (4 * numA * numC))) / (2 * numA);

            Console.WriteLine(formulAarriba);
            Console.WriteLine("\n ----------- \n");
            Console.WriteLine(formulAbajo);

            Console.ReadKey();

        }
    }
}

