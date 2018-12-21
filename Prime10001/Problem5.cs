using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem5
{

    //Smallest multiple
    //Problem 5
    //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

    //  What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

    public class Problem5
    {
      
        static void Main5()//change to main to run seperate of other classes
        {

            // count iter
          
             for (int number = 1; number <=10; number++)
                {
                    bool divisable = IsDivisable(number);

                    if (divisable == true)
                    {
                        Console.WriteLine("The number" + number + "is divisable");
                    }

                }

            //} 

            Console.Read();

        } //End Main

        private static bool IsDivisable(int numbertocheck)
        {
            for (int denominator = 2; denominator <= 10; denominator++)
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


