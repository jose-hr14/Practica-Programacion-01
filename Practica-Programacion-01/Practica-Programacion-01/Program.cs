using System;

namespace Practica_Programacion_01
{
    class Program
    {
        /// <summary>
        /// Esta función lanzará el controlador del submenú
        /// de la serie de Fibonacci. Pedirá al usuario un
        /// número, y se imprimirán una cantidad concreta de 
        /// números de la serie, determinada por el número que
        /// ha introducido el usuario. 
        /// Cuando el controlador cumple su función, espera input 
        /// del usuario para regresar al menú principal.
        /// </summary>
        public static void LaunchFibonacciMenu()
        {
            UserInterface.PrintFibonacciMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            MathsModel.FibonacciFunction(value);
            ControllerUtilities.WaitForInputToContinue("Pulse una tecla para continuar");

        }

        /// <summary>
        /// Esta función lanzará el controlador del submenú
        /// de números primos. Pedirá un número al usuario e
        /// imprimirá por pantalla si el número introducido
        /// es primo o no.
        /// Cuando el controlador cumple su función, espera input 
        /// del usuario para regresar al menú principal.
        /// </summary>
        public static void LaunchIsPrimelMenu()
        {
            UserInterface.PrintIsPrimeMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            if (MathsModel.IsPrimeFunction(value))
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
            ControllerUtilities.WaitForInputToContinue("Pulse una tecla para continuar");
        }

        /// <summary>
        /// Esta función lanzará el controlador del submenú de
        /// factoriales. Pedirá al usuario un número e 
        /// imprimirá por pantalla su factorial.
        /// Cuando el controlador cumple su función, espera input 
        /// del usuario para regresar al menú principal.
        /// </summary>
        public static void LaunchFactorialMenu()
        {
            UserInterface.PrintFactorialMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            int result = MathsModel.FactorialFunction(value);
            Console.WriteLine("El resultado del factorial de " + value + " es " + result);
            ControllerUtilities.WaitForInputToContinue("Pulse una tecla para continuar");

        }

        /// <summary>
        /// Esta función lanzará el controlador del submenú de
        /// sumatorios. Pedirá al usuario un número e imprimirá
        /// por pantalla el resultado de su sumatorio.
        /// Cuando el controlador cumple su función, espera input 
        /// del usuario para regresar al menú principal.
        /// </summary>
        public static void LaunchSummationMenu()
        {
            UserInterface.PrintPowerMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            int result = MathsModel.SummationFunction(value);
            Console.WriteLine("El resultado del sumatorio de " + value + " es " + result);
            ControllerUtilities.WaitForInputToContinue("Pulse una tecla para continuar");
        }

        /// <summary>
        /// Esta función lanzará el controlador del submenú de potencias
        /// en base 2. Pedirá un número al usuario, e imprimirá por
        /// pantalla su potencia en base 2.
        /// Cuando el controlador cumple su función, espera input 
        /// del usuario para regresar al menú principal.
        /// </summary>
        public static void LaunchPowerMenu()
        {
            UserInterface.PrintSummationMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");            
            int result = MathsModel.PowerFunction(value);
            Console.WriteLine("El resultado de la potencia en base 2 de " + value + " es " + result); // modificar
            ControllerUtilities.WaitForInputToContinue("Pulse una tecla para continuar");
        }

        /// <summary>
        /// Esta función lanzará el controlador del menú principal.
        /// A raíz del mismo, el usuario puede seleccionar distintas
        /// opciones para acceder a cada uno de los submenús o salir 
        /// del programa. Los submenús desempeñarán una función concreta 
        /// y cuando acaben, regresarán al menú principal.
        /// </summary>
        public static void LaunchMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                switch (ControllerUtilities.ReadMenuOption(0, 5))
                {
                    case 0:
                        return;                        
                    case 1:
                        System.Console.Clear();
                        LaunchPowerMenu();
                        System.Console.Clear();
                        break;
                    case 2:
                        System.Console.Clear();
                        LaunchSummationMenu();
                        System.Console.Clear();
                        break;
                    case 3:
                        System.Console.Clear();
                        LaunchFactorialMenu();
                        System.Console.Clear();
                        break;
                    case 4:
                        System.Console.Clear();
                        LaunchIsPrimelMenu();
                        System.Console.Clear();
                        break;
                    case 5:
                        System.Console.Clear();
                        LaunchFibonacciMenu();
                        System.Console.Clear();
                        break;
                }
            }                        
        }

        static void Main(string[] args)
        {            
            LaunchMainMenu();                        
        }
    }
}
