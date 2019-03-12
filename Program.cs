using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            //Calling a method to retrieve prime numbers between 5 and 15
            int a = 5, b = 15;
            printPrimeNumbers(a, b);
            Console.WriteLine(" ");


            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.WriteLine(" ");

            //Calling a method to create a triangle of five rows
            int n4 = 5;
            printTriangle(n4);

            //Calling a method to calculate frequency of numbers in array
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
                {
                    //Initializing z integer
                    int z= 0;

                    //The following lines of comments were used for debugging purposes
                    //Console.Write("Enter lower range of prime number list: ");
                    //x = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("Enter upper range of prime number list: ");
                    //y = Convert.ToInt32(Console.ReadLine());

                    //Displays the low and high value of input
                    Console.WriteLine("Prime numbers between {0} and {1} are: ", x, y);

                    //Incrementing low value by 1 until it equals the high value of input
                    for (int i = x; i < y; i++)
                    {

                    //Setting int z to 0
                        z = 0;

                    //Check that i is greater than 1 since 1 is not a prime number
                        if (i > 1)
                        {

                        //Loop to check for prime number
                        //Starts at 2 because a prime number is divisible by itself and
                        //greater than 1
                        for (int c = 2; c < i; c++)
                            {

                         //Get remainder of 'i' divided by 'c'
                         //If remainder is equal to 0 then, it is not a prime number
                         //due to it being evenly divisible by a number other than itself
                                if (i % c == 0)
                                {
                         //Set z to 1 and exit loop
                                    z = 1;
                                    break;
                                }
                            }
                         //If z is equal to 1, it is a Prime number
                         //Write to console
                            if (z == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    Console.ReadKey();
            }
            //Catches any exceptions
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
         }

               

        public static double getSeriesResult(int n)
        {
            double x;
            double result = 0.00;
            double e;
            double fact = n;
            double ans = 0;
            try
            {
                //calculation to determine factorial
                for (e = n - 1; e >= 1; e--)
                {
                    fact = fact * e;

                }
                ans = fact;
                //calculation to determine series at 'n'
                x = (Math.Pow(-1, (n + 1))) * ((double)(ans / (n + 1)));
                result = x;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return result;
        }

        public static void printTriangle(int n)
        {
            try
            {
                //The following lines of comments were used for debugging purposes
                //Console.WriteLine("Enter number of lines for triangle: ");
                //n = Int32.Parse(Console.ReadLine());

                //Loop to handle number of rows for triangle
                for(int i = 0; i < n; i++)
                {
                        //Inner loop to handle spaces to center triangle
                        for (int x = n - i; x > 1; x--)
                        {
                            //Write a space to console
                            Console.Write(" ");
                        }

                    //Inner loop to handle asterisks of triangle
                    for (int z = 0; z <= i; z++)
                    {
                        //For first row, write 1 asterisk only
                        if (z == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("**");
                        }
                    }

                        //After spaces and asterisk has been written to console, write new line
                        Console.WriteLine();
                    }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {

            try
            {
                //Calculating the frequency in array using LINQ method syntax
                var f = a.ToLookup(x => x)
                      .Select(x => new { Value = x.Key, Count = x.Count() })
                      .ToList();


                Console.WriteLine("Number  " + "Frequency ");
                //Lists the number and frequency of array 

                foreach (var occur in f)
                {
                    Console.WriteLine("{0}    -    {1}", occur.Value, occur.Count);
                    Console.ReadLine();

                } 
            }

            // Write your code here
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

