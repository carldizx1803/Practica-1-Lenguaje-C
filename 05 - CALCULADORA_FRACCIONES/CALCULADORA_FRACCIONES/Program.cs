using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            int num1 = 0;
            int num2 = 0;
            int denom1 = 0;
            int denom2 = 0;
            string total = "";

            // MENSAJE BIENVENIDA

            Console.Clear();
            Console.Write(" \n BIENVENIDO A LA CALCULADORA DE FRACCIONES \n");
            Console.Write(" ");
            Console.Write(" ");
            System.Threading.Thread.Sleep(1000);
            Console.Write(" MINYETY SOLUTIONS MS ");
            System.Threading.Thread.Sleep(1000);


            // DEFINIENDO LAS FRACCIÓNES
            do
            {
                Console.Clear();
                Console.Write(" \n VAMOS A DEFINIR LA PRIMERA FRACCIÓN A OPERACIONALIZAR \n");
                Console.Write(" ");
                Console.Write(" ");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                // NUMERADOR 1
                Console.Write("DIGITE EL NUMERADOR DE LA PRIMERA FRACCIÓN A OPERACIONALIZAR: \n ");
                num1 = int.Parse(Console.ReadLine());
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                if (num1 < 0)
                {
                    Console.Write("\n NÚMERO NEGATIVO, FAVOR REINTENTAR \n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();

                }

            } while (num1 < 0);

            do
            // DENOMINADOR 1
            {
                Console.Write("DIGITE EL DENOMINADOR DE LA PRIMERA FRACCIÓN A OPERACIONALIZAR: \n");
                denom1 = int.Parse(Console.ReadLine());
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                // CONFIRMACIÓN DE FRACCIÓN
                Console.Write(" ... ");
                System.Threading.Thread.Sleep(500);
                Console.Write(" ... ");
                System.Threading.Thread.Sleep(500);
                Console.Write(" ... ");
                System.Threading.Thread.Sleep(500);
                Console.Write(" FRACCIÓN DEFINIDA CON ÉXITO");
                Console.Clear();
                Console.Write(num2 + "\n---- \n " + "\n" + denom2);
                System.Threading.Thread.Sleep(2000);
                Console.Clear();

                if (denom1 < 0)
                {
                    Console.Write("\n NÚMERO NEGATIVO, FAVOR REINTENTAR \n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }

            } while (denom1 < 0);

            Console.Clear();
            Console.Write(" \n VAMOS A DEFINIR LA SEGUNDA FRACCIÓN A OPERACIONALIZAR: \n");
            Console.Write(" ");
            Console.Write(" ");
            System.Threading.Thread.Sleep(1000);

            // NUMERADOR 2
            do
            {
                Console.Write("DIGITE EL NUMERADOR DE LA SEGUNDA FRACCIÓN A OPERACIONALIZAR: \n");
                num2 = int.Parse(Console.ReadLine());
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                if (num2 < 0)
                {
                    Console.Write("\n NUMERO NEGATIVO, FAVOR REINTENTAR \n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }

            } while (num2 < 0);

            do
            {
                // DENOMINADOR 2
                Console.Write("DIGITE EL DENOMINADOR DE LA SEGUNDA FRACCIÓN A OPERACIONALIZAR: \n");
                denom2 = int.Parse(Console.ReadLine());
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                // CONFIRMACIÓN DE FRACCIÓN
                Console.Write(" ... ");
                System.Threading.Thread.Sleep(500);
                Console.Write(" ... ");
                System.Threading.Thread.Sleep(500);
                Console.Write(" ... ");
                System.Threading.Thread.Sleep(500);
                Console.Write(" FRACCIÓN DEFINIDA CON ÉXITO");
                Console.Clear();
                Console.Write(num2 + "\n---- \n " + "\n" + denom2);
                System.Threading.Thread.Sleep(2000);
                Console.Clear();


                if (denom2 < 0)
                {
                    Console.Write("\n NUMERO NEGATIVO, FAVOR REINTENTAR \n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }

            } while (denom2 < 0);

            //  MENÚ OPERACIONES
            Console.Write("\n SELECCIONE LA OPCIÓN CON LA CUAL DESEA PROCEDER: \n");
            Console.Write("\n 1 - SUMAR FRACCIONES ");
            Console.Write("\n 2 - RESTAR FRACCIONES ");
            Console.Write("\n 3 - MULTIPLICAR FRACCIONES ");
            Console.Write("\n 4 - DIVIDIR FRACCIONES \n");

            do
            {
                menu = int.Parse(Console.ReadLine());

                // OPCIÓN SUMA
                switch (menu)
                {
                    case 1:
                        if (denom1 == denom2)
                        {
                            total = $"{num1 + num2}/{denom2}";
                        }
                        else
                        {
                            total = $"{((num1 * denom2) + (num2 * denom1))}/{denom2 * denom1}";
                        }
                        break;


                    // OPCIÓN RESTA
                    case 2:
                        if (denom1 == denom2)
                        {
                            total = $"{num1 - num2}/{denom2}";
                        }
                        else
                        {
                            total = $"{((num1 * denom2) - (num2 * denom1))}/{denom2 * denom1}";
                        }

                        break;


                    // OPCIÓN MULTIPLICACIÓN
                    case 3:

                        total = $"{num1 * num2}/{denom2 * denom1}";

                        break;


                    // OPCIÓN DIVISIÓN
                    case 4:

                        total = $"{(num1 * denom2)}/{(num2 * denom1)}";
                        break;

                }

                if (menu < 1 || menu > 6)
                {
                    Console.Write("\n ESTA OPCIÓN NO EXISTE, FAVOR REINTENTAR \n");
                }
                else
                {
                    Console.Write($"\n EL RESULTADO DE LA OPERACIÓN ES: {total}");
                }

            } while (menu < 1 || menu > 6);

            Console.ReadKey();
        }
    }
}