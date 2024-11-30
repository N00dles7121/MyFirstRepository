using System;
using System.Text;
using System.IO;
using System.Globalization;





namespace ConsoleApp1
{
    class Program1
    {
        static void Main()
        {
            System.Console.WriteLine(Sqrt(5));



            Console.ReadKey();

        }
        static public float Sqrt (float num) {
            if (num < 0) return 0;
            if (num == 0 || num == 1) return num;

            float result = 0;

            while (result * result < num) {
                result += 0.000001f;
            }


            return result - 0.000001f;
        }
    }
}
