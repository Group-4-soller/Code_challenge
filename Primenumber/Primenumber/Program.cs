using System;
using System.Globalization;

namespace Primenumber
{
    class Primenumber
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter The Start Number: ");
                int startNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the End Number : ");
                int endNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The Prime Numbers between {startNumber} and {endNumber} are : ");
                for (int i = startNumber; i <= endNumber; i++)
                {
                    int counter = 0;

                    int j = 2;

                    while (j <= i / 2)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                           
                            break;
                        }
                        j++;
                    }

                    if (counter == 0 && i != 1)
                    {
                        Console.Write("{0} ", i);
                    }
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
