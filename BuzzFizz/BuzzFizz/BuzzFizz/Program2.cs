using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzFizz2
{
    class Program2
    {

        static void Main(string[] args)
        {
            int i = 0;
            
           for (i = 1; i < 101; i++)
            {
                decimal remainder3 = i % 3;
                decimal remainder5 = i % 5;

                if (remainder3==0)
                {
                    
                    Console.WriteLine("i=" + i + " Buzz");
                    
                }
                if (remainder5 == 0)
                {
                    
                    
                    Console.WriteLine("i=" + i + " BuzzFizz");
                    
                }
                
               
                


            }
            Console.ReadLine();
        }
    }
}

