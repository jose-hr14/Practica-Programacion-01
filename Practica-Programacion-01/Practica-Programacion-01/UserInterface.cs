using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Programacion_01
{
    class UserInterface
    {
        /// <summary>
        /// Esta función imprime por pantalla el
        /// menú de la potencia de un número en 
        /// base 2.
        /// </summary>
        public static void PrintPowerMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menu de potencias", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número y su potencia, y posteriormente imprimirá por pantalla el resultado \n");

        }

        /// <summary>
        /// Esta función el prime un menú del
        /// sumatorio de un número.
        /// </summary>
        public static void PrintSummationMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menú del sumatorio", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla el resultado del sumatorio \n");
        }

        /// <summary>
        /// Este función imprime el menú del
        /// factorial de un número.
        /// </summary>
        public static void PrintFactorialMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menú del factorial", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla el resultado del factorial \n");
        }

        /// <summary>
        /// Esta función imprime por pantalle el
        /// menú de si un número es primo.
        /// </summary>
        public static void PrintIsPrimeMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menú de números primos", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla si es primo o no \n");
        }

        /// <summary>
        /// Esta función imprime por pantalla el menú
        /// de la serie de Fibonacci.
        /// </summary>
        public static void PrintFibonacciMenu()
        {
            System.Console.WriteLine("----------------");
            PrintTittleWithColor("Menú de la serie de Fibonacci", ConsoleColor.Red);
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("A través de este menú, el programa pedirá la entrada de un número e imprimirá por pantalla esa cantidad de números de la serie \n");
        }

        /// <summary>
        /// Esta función imprime un título de un color concreto.
        /// El título que se imprima y el color elegido, son 
        /// aquellos que se toman como parámetro.
        /// </summary>
        /// <param name="title">
        /// Es el título que se va a imprimir.
        /// </param>
        /// <param name="Color">
        /// Es el color con el que se imprimirá el título.
        /// </param>
        public static void PrintTittleWithColor(string title, ConsoleColor Color)
        {            
            
            Console.ForegroundColor = Color;
            Console.WriteLine(title);
            Console.ResetColor();
        }
        
        /// <summary>
        /// Esta función imprimirá por pantalla el menú principal. El menú
        /// que aparecerá por pantalla nada más se inicie la aplicación. 
        /// </summary>
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
