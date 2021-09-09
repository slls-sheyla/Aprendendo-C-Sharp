using System;

namespace ConsoleApp8
{
    class Programa8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For");
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(i);

            }

            Console.WriteLine();
            Console.WriteLine("While");

            int j = 0;

            while (j < 5)
            {

                Console.WriteLine(j);
                ++j;

            }

            Console.WriteLine();
            Console.WriteLine("Do While");

            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
                
            } while (k < 5);


            Console.ReadKey();

        }
    }
}
