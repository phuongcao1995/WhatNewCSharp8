using System;

namespace StaticLocalFunctions
{
    class Program
    {
        static int M()
        {
            int y;
            LocalFunction();
            return y;

            void LocalFunction() => y = 0;
        }

        static void CheckNumber()
        {
            int x = 2;
            Increase(x);
            if (x % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            static void Increase(int y)
            {
                y++;
                Console.WriteLine($"Number after increase: {y}");
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(M());
            CheckNumber();
            Console.ReadLine();
        }
    }
}
