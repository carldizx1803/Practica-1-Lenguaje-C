using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORIAL_DE_UN_NÚMERO
{

    internal class Program
    {
        public static double FACTORIAL_NUMERO(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            return num * FACTORIAL_NUMERO(num - 1);
        }
        static void Main(string[] args)
        {
            int factorial;
            Console.Clear();
            Console.Write(" BIENVENIDO AL CÁLCULO FACTORIAL DE UN NÚMERO ");
            Console.Write(" ");
            Console.Write(" ");
            System.Threading.Thread.Sleep(2000);

            Console.Write(" ");
            Console.Write(" ");
            Console.Write("\n ¿A QUÉ NÚMERO LE QUIERES CALCULAR EL FACTORIAL?, INSERTA SU VALOR \n");
            factorial = int.Parse(Console.ReadLine());

            Console.WriteLine("\n EL FACTORIAL DE {0} ES: {1}", factorial, FACTORIAL_NUMERO(factorial));
            Console.ReadKey();
        }
    }
}