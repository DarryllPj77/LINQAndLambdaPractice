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
            Console.WriteLine("LINQ Method Practice Simulation");

            List<int> numbers = new List<int>()
            {
                1,23,22,44,55,9,10,9
            };

            Console.Write("\nInitial values for the Numbers List: ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

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
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            // Selects numbers greater than 10.
            var bigNumbers = numbers.Where(number => number > 10);
            Console.WriteLine("\nNumber Greater than 10:");
            foreach (var item in bigNumbers)
            {
                Console.WriteLine(item);
            }

            // Selects student names that start with the letter D, ignoring letter casing.
            var namesWithD = students.Where(students => students.ToLower().StartsWith("d"));
            Console.WriteLine("\nStudents with names that start with 'D'");
            foreach (var item in namesWithD)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n*********************************************************");

            // Lists are reference types, so both variables point to the same list.
            List<string> list1 = new() { "Darryll" };

            List<string> list2 = list1;

            list2.Add("John");

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
            foreach (var item in multiplierToTwo)
            {
                Console.WriteLine(item);
            }

            // Squares every number by multiplying it by itself.
            var multiplyToItself = numbers.Select(numbers => numbers * numbers);
            Console.WriteLine("\nMultiply each values to itself");
            foreach (var item in multiplyToItself)
            {
                Console.WriteLine(item);
            }

            // Converts every student name to uppercase.
            var capitalCases = students.Select(students => students.ToUpper());
            Console.WriteLine("\nConvert All students names to capital cases");
            foreach (var item in capitalCases)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Simulation for using OrderBy() Method");

            // OrderBy() sorts items in ascending order based on a selected value.
            var ascendingNum = numbers.OrderBy(numbers => numbers);
            Console.WriteLine("Ascending of numbers in the list");
            foreach (var item in ascendingNum)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Sorts student names alphabetically in ascending order.
            var ascendingStudent = students.OrderBy(students => students);
            Console.WriteLine("Ascending of student name");
            foreach (var item in ascendingStudent)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Simulation for using OrderByDescending() Method");

            // OrderByDescending() sorts items from the highest value to the lowest.
            Console.WriteLine("\nDescending order for the numbers on the list");
            var descendingNum = numbers.OrderByDescending(numbers => numbers);
            foreach (var item in descendingNum)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDescending order for the student on the list");
            var descendingStudent = students.OrderByDescending(students => students);
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
            var checkEven = numbers.Any(numbers => numbers % 2 == 0);
            Console.WriteLine(checkEven); // True

            Console.WriteLine("\nChecking if their are Any number less than 20");
            var checkLessThan20 = numberNoLessThan20.Any(numbers => numbers < 20);
            Console.WriteLine(checkLessThan20); // False

            Console.WriteLine("\nChecking if their are Any student starts with J");
            bool startsWithJ = students.Any(student => student.StartsWith("J"));
            Console.WriteLine(startsWithJ);

            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Simulation for using All() Method");


            // All() returns true only when every item matches the condition.
            Console.WriteLine("\nChecking if all values is greater than 0");
            bool numberCheckerGreaterThan0 = numbers.All(n => n > 0);
            Console.WriteLine(numberCheckerGreaterThan0);

            Console.WriteLine("\nChecking if all student's length is greater than 2");
            bool studentLengthGreaterThan2 = students.All(student => student.Length > 2);
            Console.WriteLine(studentLengthGreaterThan2);

            Console.WriteLine("\nChecking if all student's name starts with letter D");
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

        }
    }
}
