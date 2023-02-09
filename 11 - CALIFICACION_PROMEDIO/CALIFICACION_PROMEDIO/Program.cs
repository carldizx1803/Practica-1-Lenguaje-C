using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALIFICACION_PROMEDIO
{
    internal class Program
{
    static void Main(string[] args)
    {
        double rpt;
        double pp1;
        double pp2;
        double ef;
        double np;
        double ppp;
        double nf;


        do
        {
            Console.Write(" BIENVENIDO A LA CALCULADORA DE NOTA FINAL UNPHU ");
            Console.Write(" ");
            Console.Write(" ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            // PRIMER PARCIAL
            Console.WriteLine(" ¿CUÁL FUE SU CALIFICACIÓN EN EL PRIMER PARCIAL PP1? \n");
            pp1 = Convert.ToDouble(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            // SEGUNDO PARCIAL
            Console.WriteLine(" ¿CUÁL FUE SU CALIFICACIÓN EN SEGUNDO PARCIAL PP2? \n");
            pp2 = Convert.ToDouble(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            // EXAMEN FINAL
            Console.WriteLine(" ¿CUÁL FUE SU CALIFICACIÓN EN EL EXÁMEN FINAL EF? \n");
            ef = Convert.ToDouble(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            // NOTA PRÁCTICA
            Console.WriteLine(" ¿QUÉ CALIFICACIÓN OBTUVISTE EN NOTA PRACTICA? \n");
            np = Convert.ToDouble(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            //FORMULA PROMEDIO PARCIALES
            ppp = (pp1 + pp2) / 2;
            // FORMULA NOTA FINAL
            nf = (ppp + np + ef) / 3;

            // CONDICIONES SEGÚN CALIFICACIÓN
            if (np <= 69 || ef <= 54)
                {
                Console.WriteLine(" SUS CALIFICACIONES FUERON: \n" + "PRIMER PARCIAL: " + pp1 + " \n SEGUNDO PARCIAL: " + pp2 + "\n EXAMEN FINAL: " + ef + "\n NOTA PRÁCTICA: " + np );
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("\n ESTÁ REPROBADO AUTOMÁTICAMENTE \n");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                }
            else if (nf >= 90)
            {
                Console.WriteLine(" SUS CALIFICACIONES FUERON: \n" + "PRIMER PARCIAL: " + pp1 + " \n SEGUNDO PARCIAL: " + pp2 + "\n EXAMEN FINAL: " + ef + "\n NOTA PRÁCTICA: " + np);
                Console.WriteLine("\n APROBADO CON: " + Math.Round(nf, 2) + " PUNTOS. NOTA LITERAL A \n");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                }
            else if (nf >= 80)
            {
                Console.WriteLine(" SUS CALIFICACIONES FUERON: \n" + "PRIMER PARCIAL: " + pp1 + " \n SEGUNDO PARCIAL: " + pp2 + "\n EXAMEN FINAL: " + ef + "\n NOTA PRÁCTICA: " + np);
                Console.WriteLine("\n APROBADO CON: " + Math.Round(nf, 2) + " PUNTOS. NOTA LITERAL B \n");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                }
            else if (nf >= 70)
            {
                Console.WriteLine(" SUS CALIFICACIONES FUERON: \n" + "PRIMER PARCIAL: " + pp1 + " \n SEGUNDO PARCIAL: " + pp2 + "\n EXAMEN FINAL: " + ef + "\n NOTA PRÁCTICA: " + np);
                Console.WriteLine("\n APROBADO CON: " + Math.Round(nf, 2) + " PUNTOS. NOTA LITERAL C \n");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                }
            else if (nf >= 60)
            {
                Console.WriteLine(" SUS CALIFICACIONES FUERON: \n" + "PRIMER PARCIAL: " + pp1 + " \n SEGUNDO PARCIAL: " + pp2 + "\n EXAMEN FINAL: " + ef + "\n NOTA PRÁCTICA: " + np);
                Console.WriteLine("\n REPROBADO PERO APLAZADO CON: " + Math.Round(nf, 2) + " PUNTOS. NOTA LITERAL D \n");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                }
            else if (nf >= 50)
            {
                Console.WriteLine(" SUS CALIFICACIONES FUERON: \n" + "PRIMER PARCIAL: " + pp1 + " \n SEGUNDO PARCIAL: " + pp2 + "\n EXAMEN FINAL: " + ef + "\n NOTA PRÁCTICA: " + np);
                Console.WriteLine("\n REPROBADO CON: " + Math.Round(nf, 2) + " PUNTOS. NOTA LITERAL F \n");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                }

            // ¿REPETIR PROCESO?
            Console.WriteLine(" ¿DESEA CALCULAR NUEVA VEZ OTRA CALIFICACIÓN Y REINICIAR EL PROGRAMA? \n INGRESE 1: ");
            rpt = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
        }

        while (rpt == 1);
    }
}
}

