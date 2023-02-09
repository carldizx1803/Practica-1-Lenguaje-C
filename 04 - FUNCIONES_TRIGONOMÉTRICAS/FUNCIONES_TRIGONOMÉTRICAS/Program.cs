using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCIONES_TRIGONOMETRICAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            double angulo;
            double radianes;
            double total = 0;

            // MENÚ DE OCIONES
            Console.Write(" CALCULADORA DE FUNCIONES TRIGONOMÉTRICAS, SELECCIONE UNA OPCIÓN: ");
            Console.Write(" CÁLCULO DEL AREA DE UN CIRCULO ");
            Console.Write(" ");
            Console.Write(" ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\n 1 - FUNCIÓN SENO ");
            Console.Write("\n 2 - FUNCIÓN COSENO ");
            Console.Write("\n 3 - FUNCIÓN SECANTE ");
            Console.Write("\n 4 - FUNCIÓN COSECANTE ");
            Console.Write("\n 5 - FUNCIÓN TANGENTE ");
            Console.Write("\n 6 - FUNCIÓN COTANGENTE \n");

            do
            {
                menu = int.Parse(Console.ReadLine());

                do
                {
                    // ÁNGULO DE LA FIGURA 
                    Console.Write(" ¿Qué ángulo tiene la figura? \n *INGRESE UN NÚMERO ENTERO Y POSITIVO VÁLIDO \n ");
                    angulo = double.Parse(Console.ReadLine());


                    if (angulo < 0)
                    {
                        Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO, NO ES VÁLIDO \n");
                    }

                } while (angulo < 0);
                // CONVERSIÓN A RADIANES PARA PODER OPERAR 
                radianes = angulo * Math.PI / 180.0;
                switch (menu)
                {
                    // FUNCIÓN SENO
                    case 1:
                        total = Math.Sin(radianes);
                        break;


                    // FUNCIÓN COSENO
                    case 2:
                        total = Math.Cos(radianes);
                        break;


                    // FUNCIÓN SECANTE
                    case 3:
                        total = 1 / Math.Cos(radianes);
                        break;


                    // FUNCIÓN COSECANTE
                    case 4:
                        total = 1 / Math.Tan(radianes);
                        break;


                    // FUNCIÓN TANGENTE
                    case 5:
                        total = Math.Tan(radianes);
                        break;


                    // FUNCIÓN COTANGENTE
                    case 6:
                        total = 2 * Math.Atan(1) - Math.Atan(radianes);
                        break;
                }

                if (menu < 1 || menu > 6)
                {
                    Console.Write("\n ESTA OPCIÓN NO EXISTE, FAVOR REINTENTAR \n");
                }
                else
                {
                    Console.Write($"\n LA FUNCIÓN {total}");
                }

            } while (menu < 1 || menu > 6);

            Console.ReadKey();
        }
    }
}
