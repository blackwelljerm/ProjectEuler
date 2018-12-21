using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem7
{

    //Summation of primes
    //Problem 10
    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

    //Find the sum of all the primes below two million.

    public class Problem7
    {
        
        static void Main7()//change to main to run seperate of other classes
        {

            long number = 1;
            long sum = 0;
            do
            {
                number = number+1;
                bool prime = IsPrime(number);

                if (prime == true)
                {
                    sum = sum + number;
                    Console.WriteLine(number + " is prime and the sum is " + sum);
                    
                }
            } while (number <2000000);
            

            Console.Read();

        } //End Main

        private static bool IsPrime(long numbertocheck)
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

    // The answer is 142913828922.
} // end namespace


