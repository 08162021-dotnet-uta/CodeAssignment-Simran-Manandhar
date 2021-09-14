using System;

namespace SweetnSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            //looping from 1 to 1000
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 5 == 0 && i % 3 == 0) //checking whether the number is divisible by 3 and 5
                {
                    Console.Write("sweet'nSalty" + " ");
                }
                else if (i % 3 == 0) //checking whether the number is divisible by 3
                {
                    Console.Write("sweet" + " ");
                }
                else if (i % 5 == 0) //checking whether the number is divisible by 5
                {
                    Console.Write("salty" + " ");
                }
                else
                {
                    Console.Write(i + " "); //printing just the number
                }
                if (i % 10 == 0) // taking 10 data at a time and going to next line
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
