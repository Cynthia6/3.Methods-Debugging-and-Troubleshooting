﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int n = int.Parse(Console.ReadLine());
            PrintSign(n);

        }

        public static void PrintSign(int n)
        {
            if (n == 0) Console.WriteLine($"The number {n} is zero.");
            else if(n > 0) Console.WriteLine($"The number {n} is positive.");
           else if(n < 0) Console.WriteLine($"The number {n} is negative.");
        }
    }
}
