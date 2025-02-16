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

                Console.Write("Enter the first number:");                
                while (!double.TryParse(Console.ReadLine(),out num1))
                {                    
                    Console.Write("Enter a valid input please for the first number : ");
                }
                Console.Write("Enter the second number:");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Enter a valid input please for the second number : ");
                }
                while (true)
                {
                    Console.Write("Enter the operator (/,+,-,*):");
                    string Operator = Console.ReadLine();

                    switch (Operator)
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
                            if (num2 == 0)
                            {
                                Console.WriteLine("cannot divide by zero (-_-).");
                                break;
                            }
                            res = num1 / num2;
                            Console.WriteLine("Division: " + res);
                            break;
                        default:
                            Console.WriteLine("Wrong input!");
                            break;
                    }
                }                
                Console.Write("Do you want to continue (y/n):");
                Answer = Console.ReadLine();
                if (Answer.ToLower() != "y" && Answer.ToLower() != "yes")
                {
                    Console.Write("Are Sure? if you want to continue enter (y/yes): ");
                    Answer = Console.ReadLine();
                }
            }
            while (Answer.ToLower() == "y" || Answer.ToLower() == "yes");
        }
    }

}
