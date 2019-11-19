using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)
        {
            String Fizz = "Fizz"; //3
            String Buzz = "Buzz"; //5
            String Bang = "Bang"; //7
            String Bong = "Bong"; //11
            String Fezz = "Fezz"; //13

            for (int i=1; i<=300; i++)
            {

                if (i % 11 == 0)
                {
                    Console.WriteLine(Bong);
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    if (i % 13 == 0)
                    {
                        string outcome = Fizz + Fezz + Buzz;
                        Console.WriteLine(outcome);
                    }
                    else                    {
                        Console.WriteLine(Fizz + Buzz);
                    }
                }
                else if (i % 3 == 0 && i % 7 == 0 )
                {
                    if (i % 13 == 0)
                    {
                        string outcome = Fizz + Fezz + Bang;
                        Console.WriteLine(outcome);
                    }
                    else
                    {
                        Console.WriteLine(Fizz + Bang);
                    }
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    if (i % 13 == 0)
                    {
                        string outcome = Fezz + Bang + Buzz;
                        Console.WriteLine(outcome);
                    }
                    else
                    {
                        Console.WriteLine(Bang + Buzz);

                    }
                }
                else if (i % 13 == 0)
                {
                    Console.WriteLine(Fezz);
                }
                
                else if (i % 3 == 0)
                {
                    Console.WriteLine(Fizz);
                }
                else if  (i % 5 == 0)
                {
                    Console.WriteLine(Buzz);
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine(Bang);
                }
              

            
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
