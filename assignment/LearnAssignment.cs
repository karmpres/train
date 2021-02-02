using System;
namespace assignment
{
    public class LearnAssignment
    {
        public LearnAssignment()
        {

        }

        public void calculation(double a, double b, double c, double d)
        {
            double result = a + b + c + d;
            Console.WriteLine("Result: " + result);
        }

        public void calculation(double a, double b)
        {
            double result = Math.Abs(a - b);
            Console.WriteLine("Result: " + result);

        }

        public void calculation(double a, double b, double c)
        {
            double result = a * b * c;
            Console.WriteLine("Result: " + result);
        }

        public void calculation(double a, double b, string opt = "Please do input 0")
        {
            if (b != 0)
            {
                double result = a / b;
                Console.WriteLine("Result: " + result);

            }
            else
            {
                Console.WriteLine(opt);
            }

        }
    }
}
