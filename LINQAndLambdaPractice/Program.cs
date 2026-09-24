using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQAndLambdaPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ and Lambda are related, but they are not the same thing.

            //LINQ = a way to query / filter / sort data.
            //Lambda = a short function you can pass into LINQ methods.

            List<int> numbers = new List<int>()
            {
                1,2,3,4,5,6,7
            };

            // Using foreach and if-else

            var evenNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if(number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            Console.WriteLine("Foreach and If-else version");
            foreach (var even in evenNumbers)
            {
                Console.WriteLine(even);
            }




            // Using LINQ query syntax
            var linqEvenNumbers = from number in numbers where number % 2 == 0 select number;
            Console.WriteLine("*****************");
            Console.WriteLine("LINQ Version syntax: ");
            foreach (var even in evenNumbers)
            {
                Console.WriteLine(even + " ");
            }

            // Using Lambda
            Console.WriteLine("*****************");
            var lambdaEvenNumbers = numbers.Where(number => number % 2 == 0);
            Console.WriteLine("Lambda Version syntax: ");
            foreach (var even in lambdaEvenNumbers)
            {
                Console.WriteLine(even);
            }
        }
    }
}
