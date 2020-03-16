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
                        Console.WriteLine("\nPlease enter the first number you would like to add: \n");
                        int add1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nPlease enter the second number you would like to add: \n");
                        int add2 = Int32.Parse(Console.ReadLine());
                        int sum = Add(add1, add2);
                        Console.WriteLine($"\nThe sum of {add1} and {add2} is {sum}. \n");
                        Menu();
                        break;
                    case 2:
                        Console.WriteLine("\nPlease enter the first number you would like to subtract from: \n");
                        int sub1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nPlease enter the second number you would like to subtract: \n");
                        int sub2 = Int32.Parse(Console.ReadLine());
                        int dif = Subtract(sub1, sub2);
                        Console.WriteLine($"\nThe difference of {sub2} from {sub1} is {dif}. \n");
                        Menu();
                        break;
                    case 3:
                        Console.WriteLine("\nPlease enter the first number you would like to multiply: \n");
                        int mult1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nPlease enter the second number you would like to multiply: \n");
                        int mult2 = Int32.Parse(Console.ReadLine());
                        int prod = Multiply(mult1, mult2);
                        Console.WriteLine($"\nThe product of {mult1} and {mult2} is {prod}. \n");
                        Menu();
                        break;
                    case 4:
                        Console.WriteLine("\nPlease enter the first number you would like to divide from: \n");
                        int div1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nPlease enter the second number you would like to divide by: \n");
                        int div2 = Int32.Parse(Console.ReadLine());
                        int quotient = Divide(div1, div2);
                        Console.WriteLine($"\nThe quotient of {div1} and {div2} is {quotient}. \n");
                        Menu();
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

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int sub1, int sub2)
        {
            return sub1 - sub2;
        }

        static int Multiply(int mult1, int mult2)
        {
            return mult1 * mult2;
        }

        static int Divide(int div1, int div2)
        {
            return div1 / div2;
        }
    }
}
