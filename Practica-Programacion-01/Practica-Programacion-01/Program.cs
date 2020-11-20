using System;

namespace Practica_Programacion_01
{
    class Program
    {
        public static void LaunchFibonacciMenu()
        {

        }
        public static void LaunchIsPrimelMenu()
        {

        }

        public static void LaunchFactorialMenu()
        {
            UserInterface.PrintFactorialMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            int result = MathsModel.FactorialFunction(value);


        }

        public static void LaunchSummationMenu()
        {
            UserInterface.PrintPowerMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            int result = MathsModel.SummationFunction(value);
            Console.WriteLine("El resultado del sumatorio de " + value + " es " + result);
            ControllerUtilities.WaitForInputToContinue();
        }

        public static void LaunchPowerMenu()
        {
            UserInterface.PrintSummationMenu();
            int value = ControllerUtilities.ReadIntValue("Introduce un valor: ");
            int power = ControllerUtilities.ReadIntValue("Introduce una potencia: ");
            int result = MathsModel.PowerFunction(value, power);
            Console.WriteLine("El resultado de " + value + "^" + power + " es " + result);
            ControllerUtilities.WaitForInputToContinue();
        }

        public static void LaunchMainMenu()
        {
            UserInterface.PrintMainMenu();
            switch (ControllerUtilities.ReadMenuOptionValue(0, 5))
            {
                case 0:
                    break;
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
