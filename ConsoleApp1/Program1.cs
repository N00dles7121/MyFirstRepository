using System;
using System.Text;
using System.IO;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;





namespace ConsoleApp1
{
    class Program1
    {
        static void Main()
        {

            bool isGoing = true;

            while (isGoing)
            {
                GetUserInputs(out int num1, out int num2);

                CheckOddEvenNumbers(num1, num2);

                System.Console.WriteLine("Do you want to continue (Y/N): ");
                isGoing = Console.ReadLine().ToUpper().Equals("Y");
                Console.Clear();
            }

            System.Console.WriteLine("Thanks for visiting. Press any key to exit.");
            Console.ReadKey();




        }

        static void GetUserInputs(out int x, out int y)
        {
            do
            {
                Console.WriteLine("Input first number:");
                int.TryParse(Console.ReadLine(), out int num1);
                Console.WriteLine("Input second number:");
                int.TryParse(Console.ReadLine(), out int num2);

                x = num1; y = num2;

                if (x > y)
                {
                    Console.WriteLine("Wrong input. First number must be less than second.");
                    System.Console.WriteLine("--------------------");
                    continue;
                }
            } while (x > y);
        }

        static void CheckOddEvenNumbers(int left, int right)
        {

            int evenNumberCount;
            int oddNumberCount;

            if ((left % 2 != 0 && right % 2 != 0) || (left % 2 == 0 && right % 2 == 0))
            {



                if (left % 2 == 0)
                {
                    evenNumberCount = (right - left + 1) / 2 + 1;
                    oddNumberCount = (right - left + 1) / 2;

                    System.Console.WriteLine("Total odd numbers: " + oddNumberCount);
                    System.Console.WriteLine("Total even numbers: " + evenNumberCount);
                }
                else
                {
                    oddNumberCount = (right - left + 1) / 2 + 1;
                    evenNumberCount = (right - left + 1) / 2;

                    System.Console.WriteLine("Total odd numbers: " + oddNumberCount);
                    System.Console.WriteLine("Total even numbers: " + evenNumberCount);
                }
            }
            else
            {
                oddNumberCount = (right - left + 1) / 2;
                evenNumberCount = oddNumberCount;

                System.Console.WriteLine("Total odd numbers: " + oddNumberCount);
                System.Console.WriteLine("Total even numbers: " + evenNumberCount);
            }
        }
    }
}
