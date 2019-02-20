using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first Number");
                double firstNumber = InputFormatter.FormatNumber(Console.ReadLine());

                Console.WriteLine("Enter the second Number");
                double secondNumber = InputFormatter.FormatNumber(Console.ReadLine());

                Console.WriteLine("Enter the operator from the list: +, -, /, *, %, s = squ, R = squareroot, i = sin , t =tan ,c =cos ");
                string op = InputFormatter.FormatOperator(Console.ReadLine());

                double result = Calculator.Calculate(firstNumber, secondNumber, op);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception encountered while performing calculation. Error: {0}", ex.Message));
            }
            finally {
                Console.ReadKey();
            }
        }
    }
}
