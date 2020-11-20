using System;

namespace Practica_Programacion_01
{
    class Program
    {
        public static void LaunchFibonacciMenu()
        {
            UserInterface.PrintFibonacciMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            MathsModel.FibonacciFunction(value);
            ControllerUtilities.WaitForInputToContinue("Pulse una tecla para continuar");

        }
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

        public static void LaunchFactorialMenu()
        {
            UserInterface.PrintFactorialMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            int result = MathsModel.FactorialFunction(value);
            Console.WriteLine("El resultado del factorial de " + value + " es " + result);
            ControllerUtilities.WaitForInputToContinue("Pulse una tecla para continuar");

        }

        public static void LaunchSummationMenu()
        {
            UserInterface.PrintPowerMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            int result = MathsModel.SummationFunction(value);
            Console.WriteLine("El resultado del sumatorio de " + value + " es " + result);
            ControllerUtilities.WaitForInputToContinue("Pulse una tecla para continuar");
        }

        public static void LaunchPowerMenu()
        {
            UserInterface.PrintSummationMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            int power = ControllerUtilities.ReadIntValue("Introduce su potencia: ");
            int result = MathsModel.PowerFunction(value, power);
            Console.WriteLine("El resultado de " + value + "^" + power + " es " + result);
            ControllerUtilities.WaitForInputToContinue("Pulse una tecla para continuar");
        }

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
            //Console.BackgroundColor = ConsoleColor.Red;
            //System.Console.WriteLine("Probando los colores", Console.ForegroundColor = ConsoleColor.Red);
            //Console.WriteLine("Texto en color normal", Console.ForegroundColor = ConsoleColor.White);
            //Console.WriteLine(MathsModel.Power(2, 4));
            /*
            while (true)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                MathsModel.FibonacciFunction(value);
            }
            */
            
            LaunchMainMenu();
            
            


        }
    }
}
