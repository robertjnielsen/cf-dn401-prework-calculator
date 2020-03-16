using System;

namespace cf_dotnet_prework_calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Code Fellows 401 .NET Calculator Lab!");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("\nPlease choose a calculator application below:");
            Console.WriteLine("1.) Add \n2.) Subtract \n3.) Multiply \n4.) Divide \n5.) Exit Application \n");
            int menuOption;
            bool numberSelected = Int32.TryParse(Console.ReadLine(), out menuOption);
            if (numberSelected)
            {
                switch (menuOption)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Multiply();
                        break;
                    case 4:
                        Divide();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Menu();
                        break;
                }
            }
            else
            {
                Menu();
            }
        }

        static void Add()
        {

        }

        static void Subtract()
        {

        }

        static void Multiply()
        {

        }

        static void Divide()
        {

        }
    }
}
