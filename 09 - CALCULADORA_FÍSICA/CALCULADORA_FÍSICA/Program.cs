using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_FÍSICA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double digito1;
            double digito2;
            double total;
            int menu;
            string si;

            // MENSAJE BIENVENIDA ESPERA 1.5 SEGUNDOS
            Console.Write(" *** BIENVENIDO A LA CALCULADORA FÍSICA *** ");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();


            do
            {
                // MENÚ DE OPCIONES

                Console.WriteLine(" ¿QUÉ CÁLCULO LINEAL FÍSICO DESEAS REALIZAR? - SELECCIONE SEGÚN CORRESPONDA ");
                Console.WriteLine("1 - VELOCIDAD ");
                Console.WriteLine("2 - TIEMPO ");
                Console.WriteLine("3 - DISTANCIA ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    // CALCULO DE VELOCIDAD
                    case 1:
                        Console.Clear();
                        Console.Write(" CALCULANDO LA VELOCIDAD ");
                        Console.Write(" ");
                        Console.Write(" ");
                        System.Threading.Thread.Sleep(1000);

                        Console.WriteLine("\n ¿Cuál es la distancia del deslplazamiento? \n");
                        digito1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\n ¿En qué tiempo se desplazó? \n");
                        digito2 = Convert.ToDouble(Console.ReadLine());

                        total = digito1 / digito2;

                        Console.WriteLine(" LA VELOCIDAD ES: " + total + "m/s² ");
                        break;

                    case 2:
                        // CÁLCULO DE TIEMPO
                        Console.WriteLine(" ¿A qué velocidad se desplazó? ");
                        digito1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(" ¿Qué distancia se desplazó? ");
                        digito2 = Convert.ToDouble(Console.ReadLine());

                        total = digito2 / digito1;

                        Console.WriteLine(" SE TARDÓ: " + total + " segundos");
                        break;

                    case 3:
                        // CALCULO DE DISTANCIA
                        Console.WriteLine(" ¿A qué velocidad se desplazó?  ");
                        digito1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(" ¿En qué tiempo se desplazó? ");
                        digito2 = Convert.ToDouble(Console.ReadLine());

                        total = digito1 * digito2;

                        Console.WriteLine(" LA DISTANCIA DE DESPLAZAMIENTO ES: " + total + " metros");
                        break;

                }

                Console.WriteLine(" GRACIAS POR UTILIZAR LA CALCULADORA FISICA ");
                si = Console.ReadLine();
                Console.Clear();
            }

            while (menu > 0 && menu < 4 );

        }
    }
}
