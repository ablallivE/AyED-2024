using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Villalba_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = 0;
            while (num < 100)
            {
                num++;

                if (num % 3 != 0 && num % 5 != 0)
                {
                    Console.WriteLine(num);
                }
 
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }

                if (num % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                if (num % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }              
                Console.ReadKey();


           
            }
        }
    }
