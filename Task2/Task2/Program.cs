using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());


            if (N == 0)
                Console.WriteLine("reqem ne cut nede tekdir");
            else if (N % 2 == 0)
                Console.WriteLine("Reqem cutdur");
            else
                Console.WriteLine("Reqem tekdir");

            }
        }
    }

