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
                1,2,3,4,5,6,7,11,23,15,27
            };

            // Using foreach and if-else

            var evenNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
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

            // Get OddNumbers 
            var oddNumber = numbers.Where(number => number % 2 != 0);
            Console.WriteLine("\nUsing Lambda for Getting odd numbers");
            foreach (var odd in oddNumber)
            {
                Console.WriteLine(odd);
            }

            // Get numbers greater than 10

            var numberGreaterThanTen = numbers.Where(number => number > 10);
            Console.WriteLine("\nUsing Lambda for getting numbers greater than 10");
            foreach (var num in numberGreaterThanTen)
            {
                Console.WriteLine(num);
            }

            // Get Students name that start with "D"

            List<string> students = new List<string>()
            {
                "Darryll",
                "Janssen",
                "Hanz",
                "Dani",
                "Kurohama"
            };

            var studentsWithD = students.Where(student => student.StartsWith("D"));
            //var studentsWithD = students.Where(student => student.Contains("D"));
            Console.WriteLine("\nUsing Lambda for getting Students name that start with 'D' ");
            foreach (var name in studentsWithD)
            {
                Console.WriteLine(name);
            }

            var testStudent = n
        }
    }
}
