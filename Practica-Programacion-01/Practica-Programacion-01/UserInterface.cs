using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Programacion_01
{
    class UserInterface
    {
        public static void PrintPowerMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleInRed("Menu de potencias");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número y su potencia, y posteriormente imprimirá por pantalla el resultado");

        }

        public static void PrintSummationMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleInRed("Menú del sumatorio");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla el resultado del sumatorio");
        }

        public static void PrintFactorialMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleInRed("Menú del factorial");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla el resultado del factorial");
        }

        public static void PrintPrimeMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleInRed("Menú de números primos");
            System.Console.WriteLine("----------------");
        }

        public static void PrintFibonacciMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleInRed("Menú de la serie de Fibonacci");
            System.Console.WriteLine("----------------");
        }

        public static void PrintTittleInRed(string title)
        {            
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ResetColor();
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
