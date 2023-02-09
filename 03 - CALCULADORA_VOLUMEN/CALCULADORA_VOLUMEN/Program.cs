using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_VOLUMEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            double digito1;
            double digito2;

            // MENSAJE BIENVENIDA ESPERA 1.5 SEGUNDOS
            Console.Write(" *** BIENVENIDO A LA CALCULADORA DE VOLÚMEN PARA LAS FIGURAS GEOMÉTRICAS *** ");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            // MENÚ DE OPCIONES

            Console.Write(" SELECCIONE SEGÚN CORRESPONDA \n ");
            Console.Write("\n 1- VOLÚMEN DE UN CUBO ");
            Console.Write("\n 2- VOLÚMEN DE UNA ESFERA ");
            Console.Write("\n 3 - VOLÚMEN DE UN CON0 ");
            Console.Write("\n 4 - VOLÚMEN DE UNA PIRÁMIDE ");
            System.Threading.Thread.Sleep(1000);

            do
            {
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    // VOLUMEN DE UN CUBO
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.Write(" CÁLCULO VOLÚMEN DE UN CUBO ");
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);

                            Console.Write(" \n INGRESE LA LONGITUD DE UNO DE LOS LADOS: \n");
                            digito1 = double.Parse(Console.ReadLine());


                            if (digito1 < 0)
                            {
                                Console.Write("\n EL NÚMERO INGRESADO ES NEGATIVO Y POR TANTO ES INVÁLIDO \n");
                            }

                        } while (digito1 < 0);

                        Console.Write($"\n EL VOLÚMEN DEL CUBO ES: {Math.Pow(digito1, 3)}" + "cm²");
                        break;

                    // VOLÚMEN DE UNA ESFERA
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.Write(" CÁLCULO VOLÚMEN DE UNA ESFERA ");
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write(" INGRESE LA LONGITUD DEL RADIO DE LA ESFERA EN CUESTIÓN ");
                            digito1 = double.Parse(Console.ReadLine());


                            if (digito1 < 0)
                            {
                                Console.Write("\n EL NUMERO INGRESADO ES NEGATIVO, POR TANTO ES INVÁLIDO \n");
                            }

                        } while (digito1 < 0);

                        Console.Write($"\n EL VOLÚMEN DE LA ESFERA ES: {4 / 3 * Math.PI * (Math.Pow(digito1, 3))}" + "cm²");
                        break;
                    // VOLÚMEN DE UN CONO
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.Write(" CÁLCULO VOLÚMEN DE UN CONO");
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write(" INGRESE LA LONGITUD RADIO DEL CONO EN CUESTÍÓN: ");
                            digito1 = double.Parse(Console.ReadLine());
                            if (digito1 < 0)
                            {
                                Console.Write("\n EL NUMERO INGRESADO ES NEGATIVO, POR TANTO ES INVÁLIDO \n");
                            }

                        } while (digito1 < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write(" INGRESE LA LONGITUD ALTURA DEL CONO EN CUESTIÓN ");
                            digito2 = double.Parse(Console.ReadLine());


                            if (digito2 < 0)
                            {
                                Console.Write("\n EL NUMERO INGRESADO ES NEGATIVO, POR TANTO ES INVÁLIDO \n");
                            }

                        } while (digito2 < 0);

                        Console.Write($"\n EL VOLÚMEN DEL CONO ES: {(Math.PI * Math.Pow(digito1, 2) * digito2) / 3}" + "cm²");
                        break;

                        // VOLÚMEN DE UNA PIRÁMIDE
                    case 4:
                        do
                        {
                            Console.Clear();
                            Console.Write(" CÁLCULO VOLÚMEN DE UNA PIRÁMIDE)");
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("  INGRESE LA ALTURA DE LA PIRÁMIDE ");
                            digito1 = double.Parse(Console.ReadLine());


                            if (digito1 < 0)
                            {
                                Console.Write("\n EL NUMERO INGRESADO ES NEGATIVO, POR TANTO ES INVÁLIDO \n");
                            }

                        } while (digito1 < 0);
                        do
                        {
                            Console.Write(" ");
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("  INGRESE LA LONGITUD DE UNO DE LOS LADOS DE LA PIRÁMIDE "); 
                            digito2 = double.Parse(Console.ReadLine());


                            if (digito2 < 0)
                            {
                                Console.Write("\n EL NUMERO INGRESADO ES NEGATIVO, POR TANTO ES INVÁLIDO \n");
                            }

                        } while (digito2 < 0);
                        Console.Write($"\n EL VOLÚMEN DE LA PIRÁMIDE ES: {(digito1 * digito2 * digito2) / 3}" + "cm²");
                        break;
                }

                if (menu < 1 || menu > 4)
                {
                    Console.Write("\n LA OPCIÓN SELECCIONADA NO ES VÁLIDA, FAVOR REINTENTAR \n");
                }

            } while (menu < 1 || menu > 4);

            Console.ReadKey();
        }
    }
}

