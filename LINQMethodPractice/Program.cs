namespace LINQMethodPractice
{
    internal class Program
    {
        /// <summary>
        /// Demonstrates common LINQ methods for filtering, transforming, sorting,
        /// checking, and retrieving values from collections.
        /// </summary>
        static void Main(string[] args)
        {
            // Displays the title for this LINQ practice program.
            Console.WriteLine("LINQ Method Practice Simulation");

            // Creates a list of numbers to use in the LINQ examples.
            List<int> numbers = new List<int>()
            {
                1,23,22,44,55,9,10,9
            };

            // Displays the original values before applying any LINQ methods.
            Console.Write("\nInitial values for the Numbers List: ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            // Creates a list of student names for the string-based examples.
            List<string> students = new List<string>()
            {
                "Darryll",
                "Janssen",
                "Hanz",
                "Dani",
                "Kurohama",
                "dona",
                "dino"
            };

            // Displays the original student names.
            Console.Write("\nInitial values for the Student List: ");
            foreach (var item in students)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("\n\nSimulation for using Where() Method");
            // Where() filters a collection and returns only the items that match a condition.

            // Selects only the even numbers from the numbers list.
            var evenNumbers = numbers.Where(number => number % 2 == 0);
            Console.WriteLine("Even Numbers: ");
            // Prints each number returned by the Where() query.
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            // Selects numbers greater than 10.
            var bigNumbers = numbers.Where(number => number > 10);
            Console.WriteLine("\nNumber Greater than 10:");
            // Prints each number greater than 10.
            foreach (var item in bigNumbers)
            {
                Console.WriteLine(item);
            }

            // Selects student names that start with the letter D, ignoring letter casing.
            var namesWithD = students.Where(students => students.ToLower().StartsWith("d"));
            Console.WriteLine("\nStudents with names that start with 'D'");
            // Prints each student name returned by the filtering query.
            foreach (var item in namesWithD)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n*********************************************************");

            // Lists are reference types, so both variables point to the same list.
            List<string> list1 = new() { "Darryll" };

            List<string> list2 = list1;

            // Adding through list2 also changes list1 because both variables reference the same list.
            list2.Add("John");

            // Count returns the number of items currently in the list.
            Console.WriteLine(list1.Count); // 2

            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Simulation for using Select() Method");

            Console.Write("\nInitial values for the Numbers List: ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            // Select() transforms every item and returns the transformed results.
            // Multiplies each number by two.
            var multiplierToTwo = numbers.Select(number => number * 2);
            Console.WriteLine("Multiply each values to 2");
            // Prints the transformed values returned by Select().
            foreach (var item in multiplierToTwo)
            {
                Console.WriteLine(item);
            }

            // Squares every number by multiplying it by itself.
            var multiplyToItself = numbers.Select(numbers => numbers * numbers);
            Console.WriteLine("\nMultiply each values to itself");
            // Prints each squared number.
            foreach (var item in multiplyToItself)
            {
                Console.WriteLine(item);
            }

            // Converts every student name to uppercase.
            var capitalCases = students.Select(students => students.ToUpper());
            Console.WriteLine("\nConvert All students names to capital cases");
            // Prints each transformed uppercase name.
            foreach (var item in capitalCases)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Simulation for using OrderBy() Method");

            // OrderBy() sorts items in ascending order based on a selected value.
            var ascendingNum = numbers.OrderBy(numbers => numbers);
            Console.WriteLine("Ascending of numbers in the list");
            // Prints the numbers in ascending order.
            foreach (var item in ascendingNum)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Sorts student names alphabetically in ascending order.
            var ascendingStudent = students.OrderBy(students => students);
            Console.WriteLine("Ascending of student name");
            // Prints the student names in alphabetical order.
            foreach (var item in ascendingStudent)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Simulation for using OrderByDescending() Method");

            // OrderByDescending() sorts items from the highest value to the lowest.
            Console.WriteLine("\nDescending order for the numbers on the list");
            var descendingNum = numbers.OrderByDescending(numbers => numbers);
            // Prints the numbers in descending order.
            foreach (var item in descendingNum)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDescending order for the student on the list");
            // Sorts student names alphabetically from highest to lowest.
            var descendingStudent = students.OrderByDescending(students => students);
            // Prints the student names in descending order.
            foreach (var item in descendingStudent)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Simulation for using Any() Method");

            List<int> numberNoLessThan20 = new List<int>()
            {
                21,23,40,100,75,89,94
            };

            // Any() returns true when at least one item matches the condition.
            Console.WriteLine("\nChecking if their is an even number on the list");
            // Checks whether at least one number is even.
            var checkEven = numbers.Any(numbers => numbers % 2 == 0);
            Console.WriteLine(checkEven); // True

            Console.WriteLine("\nChecking if their are Any number less than 20");
            // Checks whether at least one number is less than 20.
            var checkLessThan20 = numberNoLessThan20.Any(numbers => numbers < 20);
            Console.WriteLine(checkLessThan20); // False

            Console.WriteLine("\nChecking if their are Any student starts with J");
            // Checks whether at least one student name starts with J.
            bool startsWithJ = students.Any(student => student.StartsWith("J"));
            Console.WriteLine(startsWithJ);

            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Simulation for using All() Method");


            // All() returns true only when every item matches the condition.
            Console.WriteLine("\nChecking if all values is greater than 0");
            // Checks whether every number is greater than zero.
            bool numberCheckerGreaterThan0 = numbers.All(n => n > 0);
            Console.WriteLine(numberCheckerGreaterThan0);

            Console.WriteLine("\nChecking if all student's length is greater than 2");
            // Checks whether every student name contains more than two characters.
            bool studentLengthGreaterThan2 = students.All(student => student.Length > 2);
            Console.WriteLine(studentLengthGreaterThan2);

            Console.WriteLine("\nChecking if all student's name starts with letter D");
            // Checks whether every student name starts with D.
            bool studentIfNameStartWithD = students.All(names => names.StartsWith("D"));
            Console.WriteLine(studentIfNameStartWithD);


            Console.WriteLine("\n*********************************************************");

            Console.WriteLine("Simulation for using First() and FirstOrDefault() methods");

            // First() returns the first item that matches a condition.
            // It throws an exception if no matching item is found.
            Console.WriteLine("\nGetting the first number that divisible to 2");

            var firstNumIfDivTo2 = numbers.First(numbers => numbers % 2 == 0);
            Console.WriteLine(firstNumIfDivTo2);

            Console.WriteLine("\nGetting the first student that name starts with D");
            string firstStudentWithD = students.First(s => s.StartsWith("D"));
            Console.WriteLine(firstStudentWithD);


            Console.WriteLine("\nSimulating FirstOrDefault Method");
            // FirstOrDefault() returns the first match or the default value when no match exists.
            int firstNotDefault = numbers.FirstOrDefault(number => number > 50);
            Console.WriteLine(firstNotDefault); // 55

            Console.WriteLine("\nSimulating FirstOrDefault Method with Default");
            List<int> test1 = new List<int>()
            {
                101,102,103,400,500
            };

            // No value is less than 100, so FirstOrDefault() returns 0 for an integer list.
            int firstDefault = test1.FirstOrDefault(number => number < 100);
            Console.WriteLine(firstDefault); //0

            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Simulation for using Count() Dethod");

            // Creates a separate list for demonstrating Count() and another Where() query.
            List<int> list3 = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };


            Console.WriteLine("\nGetting the numbers of value that divisible by 2");
            // Count() returns how many numbers satisfy the condition.
            int numberOfDivBy2 = list3.Count(number => number % 2 == 0);
            Console.WriteLine(numberOfDivBy2);


            Console.WriteLine("\nGetting the values on the list that divisible by 2");
            // Where() returns the actual even values instead of only their total count.
            var numberOfDivBy2ByValues = list3.Where(n => n % 2 == 0);
            // Prints each even value returned by the Where() query.
            foreach (var item in numberOfDivBy2ByValues)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nGetting the values on the list of the students that start with D");
            // Counts how many student names start with the letter D.
            int numberOfStudentWithD = students.Count(student => student.StartsWith("D"));
            Console.WriteLine(numberOfStudentWithD);


        }
    }
}
