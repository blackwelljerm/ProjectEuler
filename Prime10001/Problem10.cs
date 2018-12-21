using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem10
{

    //10001st prime
    //Problem 7
    //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

    //What is the 10 001st prime number?

    public class Problem10
    {
      
        static void Main()//change to main to run seperate of other classes
        {

            // count iter
            int count = 1;
            
             //There's a probably a quicker way to do this using odd numbers only
                for (int number = 2; count <=10001; number++)
                {
                    bool prime = IsPrime(number);

                    if (prime == true)
                    {
                        Console.WriteLine("The " + count + "th prime is " + number);
                        count++;
                    }

                }

            //} 

            Console.Read();

        } //End Main

        private static bool IsPrime(int numbertocheck)
        {
            for (int denominator = 2; denominator < numbertocheck; denominator++)
            {
                if (numbertocheck % denominator == 0)
                {
                    return false;

                }
            }  
            return true;
                   
        }


                   
    }  // End class

    // The answer is 104743.  For future - It would make sense to write this into an array so any iteration could be found.
}  

// end namespace


