using System;

namespace WageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n = rnd.Next(0, 2);
            if (n == 0)
            {
                Console.WriteLine("The Employee is Absent.");
            }
            else
            {

                Console.WriteLine("The Employee is Present.");
                int[] arr = { 0, 4, 8 };
                int h = arr[rnd.Next(arr.Length)];
                switch (h)
                {
                    case 0: Console.WriteLine("The Employee doesn't earned money today as he didn't worked at all."); break;

                    case 4: Console.WriteLine("The Employee earned 80Rs today as he worked for 4 Hours Half Time."); break;

                    case 8: Console.WriteLine("The Employee earned 160Rs today as he worked for 8 Hours Full Time."); break;

                }


            }
            Console.ReadKey();

        }
    }
}
