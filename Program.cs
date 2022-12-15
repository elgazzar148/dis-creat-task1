using System;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pleas inter the n1");
            double N1 = double.Parse(Console.ReadLine());

            Console.WriteLine("pleas inter the n2");
            double N2 = double.Parse(Console.ReadLine());

            bool prime;

            for (double i = N1; i < N2; i++)
            {
                prime = true;

                if (i == 1)
                {
                    prime = false;

                }

                for (double j = 2; j < N1; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine(i);

                }
            }
            }
    }
}
