using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)
        {

            string Fizz = "Fizz"; //3
            string Buzz = "Buzz"; //5
            string Bang = "Bang"; //7
            string Bong = "Bong"; //11
            string Fezz = "Fezz"; //13

            string outcome = null;





            for (int i = 1; i <= 300; i++)
            {


                if (i % 11 == 0 && i % 13 == 0)
                {

                    Rules.AddRule("Fezz", "Bong");

                }
                else if (i % 11 == 0)
                {
                    outcome = Bong;
                    Console.WriteLine(outcome);
                }

                else if (i % 3 == 0 && i % 5 == 0)
                {

                    if (i % 13 == 0)
                    {
                        Rules.AddFezz("Fizz", "Fezz", "Buzz");


                    }
                    else
                    {
                        Rules.AddRule("Fizz", "Buzz");

                    }
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Rules.AddFezz("Fizz", "Fezz", "Bang");


                    }
                    else
                    {
                        Rules.AddRule("Fizz", "Bang");

                    }
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Rules.AddFezz("Fezz", "Bang", "Buzz");


                    }
                    else
                    {
                        Rules.AddRule("Bang", "Buzz");


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
                else if (i % 5 == 0)
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

            Console.ReadLine();
        }

    }
    class Rules
    {

        public string outcome { get; set; }
        public static void AddFezz(string Rule1, string Rule2, string Rule3)
        {
            string outcome = Rule1 + Rule2 + Rule3;
            Console.WriteLine(outcome);
        }
        public static void AddRule(string Rule1, string Rule2)
        {
            string outcome = Rule1 + Rule2;
            Console.WriteLine(outcome);
        }

    }

}

