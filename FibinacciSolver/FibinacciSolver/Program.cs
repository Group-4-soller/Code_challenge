using System;

namespace FibinacciCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anotherFib = true;
            while (anotherFib)
            {
                // need to Create a Fibinacci sequence for iterative, recursive and array
                Console.WriteLine("To what element do you want to derive the Fibinacci sequence: ");
                string input = Console.ReadLine();
                int element = 0;

                try // trying to parse the string as an int
                {
                    element = Int32.Parse(input);
                    Console.Write("using arrays: ");
                    printInts(arrayFib(element));
                    Console.Write("using loops: ");
                    iterativeFib(element);
                    Console.Write("using recursion: ");
                    recursiveController(element);
                    Console.WriteLine();
                }
                catch (FormatException) // the input given cannot be an int so invalid input
                {
                    Console.WriteLine($"This is not an integer '{input}'\n");
                }

                Console.WriteLine("Do you want to try another element? (y/n) ");
                string cont = Console.ReadLine();
                if (cont != "y")
                {
                    anotherFib = false;
                }
            }
        }

        // prints the fib sequence up to the point of elementNum
        public static void recursiveController(int elementNum)
        {
            if (elementNum > 1)
            {
                recursiveController(elementNum - 1);
            }
            Console.Write(recursiveEleFinder(elementNum - 1) + " ");
        }

        // returns the x spot in the fib sequence
        public static int recursiveEleFinder(int x)
        {
            if (x == 0 || x == 1)
            {
                return x;
            } else
            {
                return recursiveEleFinder(x - 1) + recursiveEleFinder(x - 2);
            }
        }

        // returns an array with the fib sequence to the specified element using a for loop
        public static int[] arrayFib(int ele)
        {
            int[] storageArray = new int[ele]; // creating our storage array for the fib of length to the specified element

            for (int x = 0; x < ele; x++) // creating a loop to loop through all needed elements
            {
                if (x == 0 || x == 1) // first two elements are one so this protects array out of bounds
                {
                    storageArray[x] = x;
                } else
                {
                    storageArray[x] = storageArray[x - 1] + storageArray[x - 2]; // the x - 1 element
                }
            }

            return storageArray;
        }

        // prints a fib sequence to the specified element using an array
        public static void iterativeFib(int ele)
        {
            int tempA = 1; // setting temp variables to store previous values
            int tempB = 0;
            int value = 0;

            for (int i = 0; i < ele; i++)
            {
                if (i > 0)
                {
                    value = tempA + tempB;
                    tempA = tempB;
                    tempB = value;
                }
                Console.Write(value + " "); // printing the value and a space to improve readability
            }

            Console.WriteLine(); // creating a space between the end of this function and the next print
        }

        // prints the integers contained with the array
        public static void printInts(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num);
                Console.Write(' ');
            }
            Console.WriteLine("");
        }
    }
}
