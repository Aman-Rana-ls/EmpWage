using System;

namespace WageCalculator
{
    internal class Program
    {
        public static int Earned(int todaysEarning)
        {
            Random rnd = new Random();
            Console.WriteLine("The Employee is Present.");
            int[] arr = { 0, 4, 8 };
            int h = arr[rnd.Next(arr.Length)];

            switch (h)
            {
                case 0:
                    Console.WriteLine("The Employee didn't earn money today as he didn't work at all.");
                    Console.WriteLine("Todays Earning=\t" + todaysEarning + "\n");
                    break;

                case 4:
                    Console.WriteLine("The Employee earned 80Rs today as he worked for 4 Hours Half Time.");
                    todaysEarning += 80;
                    Console.WriteLine("Todays Earning=\t" + todaysEarning + "\n");
                    break;

                case 8:
                    Console.WriteLine("The Employee earned 160Rs today as he worked for 8 Hours Full Time.");
                    todaysEarning += 160;
                    Console.WriteLine("Todays Earning=\t" + todaysEarning + "\n");

                    break;
            }
            return todaysEarning;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Days = 20;
            int TotalEarning = 0;
            for (int Day = 1; Day <= Days; Day++)
            {
                {
                    int DailyEarnings = 0;
                    int n = rnd.Next(0, 2);
                    if (n == 0)
                    {
                        Console.WriteLine("Day" + Day);
                        Console.WriteLine("The Employee is Absent.\n");
                    }
                    else
                    {

                        Console.WriteLine("Day" + Day);
                        DailyEarnings = Earned(DailyEarnings);
                    }
                    TotalEarning += DailyEarnings;
                }
            }
                Console.WriteLine("Total Money earned by the employee is\t" + TotalEarning + "Rs");

                Console.ReadKey();
            }
        }
    }

