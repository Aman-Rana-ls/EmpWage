using System;

namespace WageCalculator
{
    internal class Program
    {
        public static int Earned(int todaysEarning, ref int HourLimit, Random rnd)
        {
            Console.WriteLine("The Employee is Present.");
            int[] arr;
            if (HourLimit < 8)
            {
                arr = new int[] { 0, 4 };
            }
            else
            {
                arr = new int[] { 0, 4, 8 };
            }
            int h = arr[rnd.Next(arr.Length)];

            switch (h)
            {
                case 0:
                    Console.WriteLine("The Employee didn't earn money today as he didn't work at all.");
                    Console.WriteLine("Todays Earning = " + todaysEarning + "\n");
                    break;

                case 4:
                    if (HourLimit >= 4)
                    {
                        Console.WriteLine("The Employee earned 80Rs today as he worked for 4 Hours Half Time.");
                        todaysEarning += 80;
                        Console.WriteLine("Todays Earning = " + todaysEarning + "\n");
                        HourLimit -= 4;
                    }
                    else
                    {
                        Console.WriteLine("\nNot enough hours left to work 4 hours today.\n");

                    }
                    break;

                case 8:
                    if (HourLimit >= 8)
                    {
                        Console.WriteLine("The Employee earned 160Rs today as he worked for 8 Hours Full Time.");
                        todaysEarning += 160;
                        Console.WriteLine("Todays Earning = " + todaysEarning + "\n");
                        HourLimit -= 8;
                    }
                    else
                    {
                        Console.WriteLine("Not enough hours left to work 8 hours today.\n");

                    }
                    break;
            }
            return todaysEarning;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Days = 20;
            int TotalEarning = 0;
            int HourLimit = 160;
            int f = 0;

            for (int Day = 1; Day <= Days; Day++)
            {


                if (HourLimit < 4)
                {
                    Console.WriteLine("The Work Hour Limit has been exceeded");
                    break;
                }
                else
                {
                    Console.WriteLine($"Day {Day}");
                    int n = rnd.Next(0, 2);
                    int DailyEarnings = 0;

                    if (n == 0)
                    {
                        Console.WriteLine("The Employee is Absent.\n");
                    }
                    else
                    {
                        DailyEarnings = Earned(DailyEarnings, ref HourLimit, rnd);
                    }

                    TotalEarning += DailyEarnings;
                }
            }

            Console.WriteLine($"Total Money earned by the employee is {TotalEarning}Rs");
            Console.ReadKey();
        }
    }
}
