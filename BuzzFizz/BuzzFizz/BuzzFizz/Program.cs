﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzFizz
{
    class Program
    {

        static void Main(string[] args)
        {
            int i = 0;
             
            for (i = 1; i < 101; i++)
            {
                decimal remainder3 = i % 3;
                decimal remainder5 = i % 5;

                if (remainder3 == 0 && remainder5 != 0)
                {
                   
                    Console.WriteLine("i=" + i + " Buzz");
                    
                }
                else if (remainder3 == 0 && remainder5 == 0)
                {
                    Console.WriteLine("i=" + i + " BuzzFizz");
                    
                }
                else if (remainder5 == 0)
                {
                    Console.WriteLine("i=" + i + " Fizz");
                    
                }
         


            }
            Console.ReadLine();
        }
    }
}

