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
            double digito1;
            double digito2;

            // MENSAJE BIENVENIDA ESPERA 1.5 SEGUNDOS
            Console.Write(" *** BIENVENIDO A LA CALCULADORA DEL ÁREA DE LAS FIGURAS GEOMÉTRICAS *** ");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            // MENÚ DE OPCIONES

            Console.Write(" SELECCIONE SEGÚN CORRESPONDA \n ");
            Console.Write("\n 1- ÁREA DEL CUADRADO ");
            Console.Write("\n 2- ÁREA DEL CIRCULO ");
            Console.Write("\n 3 - ÁREA DEL TRIÁNGULO ");
            Console.Write("\n 4 - ÁREA DEL PENTÁGONO ");
            Console.Write("\n 5 - ÁREA DEL HEXÁGONO \n");
            System.Threading.Thread.Sleep(1000);

            do
            {
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    // AREA DEL CUADRADO
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.Write(" CÁLCULO DEL AREA DEL CUADRADO ");
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);

                            Console.Write(" \n ¿Cuánto mide la cara del cuadrado? \n");
                            digito1 = double.Parse(Console.ReadLine());


                            if (menu < 0)
                            {
                                Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO \n");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                            }

                        } while (digito1 < 0);

                        Console.Write($"\n EL ÁREA DEL CUADRADO ES: {Math.Pow(digito1, 2)}" + " cm² \n" );
                        break;


                        // ÁREA DE LA CIRCUNFERENCIA
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.Write(" CÁLCULO DEL AREA DE UN CIRCULO ");
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);

                            Console.Write(" \n ¿Cuál es el radio de la circunferencia del círculo en cuestión? \n ");
                            digito1 = double.Parse(Console.ReadLine());

                            if (digito1 < 0)
                            {
                                Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO \n");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                            }

                        } while (digito1 < 0);

                        Console.Write($"\n EL ÁREA DEL CÍRCULO ES: {Math.PI * (Math.Pow(digito1, 2))}" + " cm² \n ");
                        break;


                        // ÁREA DE UN TRIÁNGULO
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.Write(" CÁLCULO DEL AREA DE UN TRÍANGULO");
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);

                            Console.Write(" \n ¿Cuál es la base del tríangulo? \n ");
                            digito1 = double.Parse(Console.ReadLine());


                            if (digito1 < 0)
                            {
                                Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO \n");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                            }

                        } while (digito1 < 0);

                        do
                        {
                            Console.Write("\n ¿Qué altura tiene el triángulo? \n");
                            digito2 = double.Parse(Console.ReadLine());

                            if (digito2 < 0)
                            {
                                Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO \n");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                            }

                        } while (digito2 < 0);

                        Console.Write($"\n EL ÁREA DEL TRIÁNGULO ES: {(digito1 * digito2) / 2}" + " cm² \n ");
                        break;


                        // ÁREA DE UN PENTÁGONO
                    case 4:
                        do
                        {
                            Console.Clear();
                            Console.Write(" CÁLCULO DEL AREA DE UN PENTÁGONO ");
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);

                            Console.Write(" \n ¿Cuál es el perímetro de un pentágono? \n ");
                            digito1 = double.Parse(Console.ReadLine());

                            if (digito1 < 0)
                            {
                                Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO \n");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                            }

                        } while (digito1 < 0);

                        do
                        {
                            Console.Write(" \n ¿Cuál es la apotema del pentágono en cuestión? \n ");
                            digito2 = double.Parse(Console.ReadLine());


                            if (digito2 < 0)
                            {
                                Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO \n");
                            }

                        } while (digito2 < 0);

                        Console.Write($"\n EL ÁREA DEL PENTÁGONO ES: {digito1 * digito2 * 1 / 2}" + " cm² \n ");
                        break;

                        // ÁREA DE UN HEXÁGONO
                    case 5:
                        do
                        {
                            Console.Clear();
                            Console.Write(" CÁLCULO DEL AREA DE UN HEXÁGONO ");
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);

                            Console.Write("\n ¿Cuál es el perímetro del hexágono en cuestión? \n");
                            digito1 = double.Parse(Console.ReadLine());

                            if (digito1 < 0)
                            {
                                Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO \n");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                            }

                        } while (digito1 < 0);

                        do
                        {
                            Console.Write(" \n ¿Cuál es la apotema del hexágono en cuestión? \n");
                            digito2 = double.Parse(Console.ReadLine());


                            if (digito2 < 0)
                            {
                                Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO \n");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                            }

                        } while (digito2 < 0);

                        Console.Write($"\n EL ÁREA DEL HEXÁGONO ES: {(digito1 * digito2) / 2}" + " cm² \n ");
                        break;
                }

                if (menu < 1 || menu > 5)
                {
                    Console.Write("\n ESTA OPCIÓN NO EXISTE, REINTENTAR \n");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();

                }

            } while (menu < 1 || menu > 5);
            Console.ReadKey();
            
        }
    }
}

