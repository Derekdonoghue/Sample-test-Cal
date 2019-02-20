using System;

namespace SimpleCalculator
{
    public class Calculator
    {
        public static double Calculate(double firstNum, double secondNum, string op)
        {
            double result;
            switch (op)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "s":
                    result = (int)Math.Pow(firstNum, 2);
                    break;
                case "r":
                    result = Math.Sqrt(firstNum);
                    break;
                case "%":
                    result = firstNum % secondNum;
                    break;
                case "c":
                    result = Math.Round(Math.Cos(firstNum));
                    break;
                case "t":
                    result = Math.Round(Math.Tan(firstNum));
                    break;
                case "i":
                    result = Math.Round(Math.Sin(firstNum));
                    break;

                default:
                    throw new NotSupportedException("Specified operation is not supported");
            }
            return result;
        }
    }
}
