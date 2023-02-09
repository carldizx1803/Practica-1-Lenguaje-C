using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_UNIDADES_TEMPERATURA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Ejercicio_10
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // DECLARACIÓN DE VARIABLES
                double celcius;
                double kelvin;
                double fahrenheit;
                double total;
                int menu;

                do
                { // MENÚ DE OPCIONES
                    Console.WriteLine(" ¿Qué conversión deseas realizar? \n");
                    Console.WriteLine("1 - CELSIUS A KELVIN \n");
                    Console.WriteLine("2 - DE CELSIUS A FARENHEIT \n");
                    Console.WriteLine("3 - DE CELSIUS A KELVIN \n");
                    Console.WriteLine("4 - DE KELVIN A FARENHEIT \n");
                    Console.WriteLine("5 - DE FARENHEIT A CELSIUS \n");
                    Console.WriteLine("6 - DE FARENHEIT A KELVIN \n");
                    menu = Convert.ToInt32(Console.ReadLine());


                    switch (menu)
                    {
                        case 1: // DE CELSIUS A KELVIN
                            Console.WriteLine(" Ingrese los grados celsius a convertir hacia Kelvin: \n");
                            celcius = Convert.ToDouble(Console.ReadLine());

                            total = (celcius + 273.15);
                            Console.WriteLine(" EQUIVALEN A: " + total, "GRADOS KELVIN");
                            break;

                        case 2: // DE CELSIUS A FARENHEIT
                            Console.WriteLine(" Ingrese los grados celsius a convertir hacia Farenheit: \n");
                            celcius = Convert.ToDouble(Console.ReadLine());


                            total = ((celcius * 1.8) + 32);
                            Console.WriteLine("EQUIVALEN A: " + total + " GRADOS FARENHEIT");
                            break;

                        case 3: // DE KELVIN A CELSIUS
                            Console.WriteLine(" Ingrese los grados Kelvin a grados Celsius: ");
                            kelvin = Convert.ToDouble(Console.ReadLine());


                            total = (kelvin - 273.15);
                            Console.WriteLine("EQUIVALEN A " + total + "GRADOS CELSIUS");
                            break;

                        case 4: // DE KELVIN A FARENHEIT
                            Console.WriteLine("Ingrese los grados Kelvin: \n");
                            kelvin = Convert.ToDouble(Console.ReadLine());


                            total = ((kelvin - 273.15) * 9 / 5 + 32);
                            Console.WriteLine("EQUIVALEN A: " + total+" GRADOS FARENHEIT \n");
                            break;

                        case 5: // DE FARENHEIT A CELSIUS
                            Console.WriteLine("Ingrese los grados fahrenheit");
                            fahrenheit = Convert.ToDouble(Console.ReadLine());

                            total = ((fahrenheit - 32) / 1.8);
                            Console.WriteLine("EQUIVALEN A: " + total+ " GRADOS CELSIUS");
                            break;

                        case 6:// DE FARENHEIT A KELVIN
                            Console.WriteLine(" Ingrese los grados farenheit: \n");
                            fahrenheit = Convert.ToDouble(Console.ReadLine());

                            total = ((fahrenheit - 32) * 5 / 9 + 273.15);
                            Console.WriteLine("EQUIVALEN A: " + total+ " GRADOS KELVIN ");
                            break;

                    }
                    Console.WriteLine(" GRACIAS POR UTILIZAR LA CALCULADORA CONVERSORA DE UNIDADES DE TEMPERATURA ");
                    Console.Clear();
                }

                while (menu > 0 && menu < 7 );
            }
        }
    }
}
