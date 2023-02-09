using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMBINACIONES
{
    internal class Program
    {   // FUNCION PARA LIMITAR LAS COMBINACIONES 
        static int fct(int cont)
        {
            int prm = 1;
            int sgd = 1;

            while (sgd <= cont)
            {
                prm *= sgd;
                sgd++;
            }
            return prm;
        }
        // DEFINICION FUNCION SIN REPETICIONES
        static int cSinRPT(int cont, int combinacion)
        {
            int factorial1 = fct(cont);
            int factorial2 = fct(combinacion);
            int factorial3 = fct(cont - combinacion);

            return factorial1 / (factorial2 * factorial3);
        }
        static void Main(string[] args)
        {
            int menu;

            // MENSAJE BIENVENIDA
            Console.WriteLine("BIENVENIDO A LA CALCULADORA DE COMBINACIONES \n");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
             
            // MENU SELECCION SIN REPETICIONES O CON REPETICIONES

            Console.Write(" SELECCIONE SEGÚN CORRESPONDA \n");
            Console.Write("\n 1- COMBINACIONES SIN REPETICIONES \n");
            Console.WriteLine("\n 2- COMBINACIONES CON REPETICIONES \n");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            switch (menu)
            {
                case 1:
                    int numA;
                    int numB;

                    // COMBINACIONES SIN REPETICION
                    Console.WriteLine(" VAMOSA A ESTABLECER EL RANGO DE NÚMEROS ENTRE EL CUÁL CALCULAREMOS LAS COMBINACIONES POSIBLES \n");
                    Console.WriteLine(" \n SIN REPETICIONES \n");
                    Console.WriteLine("  ");
                    Console.WriteLine("  ");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();

                    Console.WriteLine(" Desde el número: \n");
                    numA = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Hasta el número: \n");
                    numB = Convert.ToInt32(Console.ReadLine());

                    // LLAMADO A LA FUNCION NRPT DANDOLE LOS PARAMETROS DEL RANGO DE NUMEROS
                    int nrpt = cSinRPT(numA, numB);
                    Console.WriteLine(" Las posibles combinaciones son: " + nrpt);
                    Console.Read();
                    break;

            }

        }
    }
}
