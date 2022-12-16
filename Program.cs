using System;

using static System.Console;

    class Program

    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]); // Console.ReadLine()은tring 형식이기때문에변환필요
            int B = int.Parse(input[1]);

            if (A > B)
            {
                Console.WriteLine(">");
            }

            else if (A < B)
            {
                Console.WriteLine("<");
            }

            else
            {
                Console.WriteLine("==");
            }

        }

    }