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
            PrintTittleWithColor("Menu de potencias", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número y su potencia, y posteriormente imprimirá por pantalla el resultado \n");

        }

        public static void PrintSummationMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menú del sumatorio", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla el resultado del sumatorio \n");
        }

        public static void PrintFactorialMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menú del factorial", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla el resultado del factorial \n");
        }

        public static void PrintIsPrimeMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menú de números primos", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla si es primo o no \n");
        }

        public static void PrintFibonacciMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menú de la serie de Fibonacci", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla esa cantidad de números de la serie \n");
        }

        public static void PrintTittleWithColor(string title, ConsoleColor Color)
        {            
            
            Console.ForegroundColor = Color;
            Console.WriteLine(title);
            Console.ResetColor();
        }
        

        public static void PrintMainMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menú principal", ConsoleColor.Red);
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
