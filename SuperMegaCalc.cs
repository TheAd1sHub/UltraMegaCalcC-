using Microsoft.VisualBasic.FileIO;
using System.Dynamic;
using System.Reflection.Emit;

namespace TheCalc
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the 1st number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the operator: ");
            char operation = Console.ReadLine()[0];

            Console.Write("Input the 2nd number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            double result = OperationChooser(firstNum, secondNum, operation);

            Console.WriteLine("=====================");
            Console.WriteLine($"Your answer is {result}");
        }

        public static double OperationChooser(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return Operations.Add(num1, num1);
                    break;

                case '-':
                    return Operations.Sub(num1, num1);
                    break;

                case '*':
                    return Operations.Mult(num1, num1);
                    break;

                case '/':
                    return Operations.Div(num1, num1);
                    break;

                case '^':
                    return Operations.Pow(num1, num1);
                    break;

                default:
                    Console.WriteLine($"Error! Unknown mathematical operation '{operation}'! Try again!" +
                        $"{Environment.NewLine}{Environment.NewLine}");
                    return default;
                    break;
                    
            }
        }

        public class Operations
        {
            public static double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            public static double Sub(double num1, double num2)
            {
                return num1 - num2;
            }

            public static double Mult(double num1, double num2)
            {
                return num1 * num2;
            }
            public static double Div(double num1, double num2)
            {
                return num1 / num2;
            }

            public static double Pow(double num1, double num2)
            {
                return Math.Pow(num1, num2);
            }
        };

    };
}