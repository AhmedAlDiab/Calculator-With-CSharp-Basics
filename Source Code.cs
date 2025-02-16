using System;

namespace CalculatorWithCSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer;
            do
            {
                double res,num1,num2;
                again1:
                try
                {
                    Console.Write("Enter the first number:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a valid input please");
                    goto again1;
                    throw;
                }
                again2:
                try
                {
                    Console.Write("Enter the second number:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a valid input please");
                    goto again2;
                    throw;
                }
            symbol:
                Console.Write("Enter the operator (/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition: " + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction: " + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication: " + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division: " + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        goto symbol;
                }                
                Console.Write("Do you want to continue (y/n):");
                Answer = Console.ReadLine();
            }
            while (Answer == "y" || Answer == "Y" || Answer == "Yes" || Answer == "YES" || Answer == "yes");
        }
    }

}
