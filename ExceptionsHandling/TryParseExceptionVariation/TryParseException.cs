using System;

namespace TryParseExceptionVariation
{
    class TryParseException
    {
        static void Main(string[] args)
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                try
                {
                    double result = DivideNumbers(a, b);
                    Console.WriteLine($"{result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");

                }

            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid numbers!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Thank you!");
            }
        }

        static double DivideNumbers(double a, double b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            else
            {
                return a / b;
            }
        }
    }
}
