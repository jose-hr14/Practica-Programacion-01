using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Programacion_01
{
    class UserInterface
    {
        public static void PrintPotenciaMenu()
        {
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Menñu de potencias");
            System.Console.WriteLine("----------------");

        }

        public static void PrintSumatoryMenu()
        {
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Menú del sumatorio");
            System.Console.WriteLine("----------------");
        }

        public static void PrintFactorialMenu()
        {
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Menú del factorial");
            System.Console.WriteLine("----------------");
        }

        public static void PrintPrimeMenu()
        {
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Menú de números primos");
            System.Console.WriteLine("----------------");
        }

        public static void PrintFibonacciMenu()
        {
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Menú de la serie de Fibonacci");
            System.Console.WriteLine("----------------");
        }

        public static void PrintTittleInRed(string tittle)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(tittle);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public static void PrintMainMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleInRed("Menú principal");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("  1) Potencia en base 2");
            System.Console.WriteLine("  2) Sumatorio de un número");
            System.Console.WriteLine("  3) Calcular el factorial de un número");
            System.Console.WriteLine("  4) Saber si un número es primo");
            System.Console.WriteLine("  5) Imprimir la serie de Fibonacci");
            System.Console.WriteLine("  0) Salir del programa");

        }
    }
}
