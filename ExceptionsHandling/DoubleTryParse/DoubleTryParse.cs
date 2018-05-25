using System;

namespace DoubleTryParse
{
    class DoubleTryParse
    {
        static void Main(string[] args)
        {
            double number;
            double a;
            double b;
            if (Double.TryParse(Console.ReadLine(), out number))
            {
                a = number;
                if (Double.TryParse(Console.ReadLine(), out number))
                {
                    b = number;
                    try
                    {
                        double result = DivideNumbers(a, b);
                        Console.WriteLine($"{result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                    }
                    finally
                    {
                        Console.WriteLine($"Thank yoou!");
                    }
                }
                else
                {
                    Console.WriteLine($"Give me invalid number!");
                };
            }
            else
            {
                Console.WriteLine($"Give me invalid number!");
            };
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
