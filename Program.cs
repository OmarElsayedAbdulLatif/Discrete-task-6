using System;

namespace Prime_numbers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int numbers = int.Parse(Console.ReadLine());

            int j;
            bool current = false;

            for (int i = 2; i <= numbers; i++)
            {
                for (j =2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        current = true;
                    }
                } 
                if (current == false)
                {
                    Console.WriteLine("the PrimeNumbers Are {0} ", j);
                }

                else current = false;
            }

        }
    }
}
