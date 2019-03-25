using System;
namespace Pattern
{
    class patternExample
    {
        public static void Main()
        {
            int i, j;
            for (j = 1; j < 5; j++)
            {
                for (i = 1; i <= j; i++)
                    Console.Write(i + " ");
                Console.WriteLine();
            }
        }
    }
}