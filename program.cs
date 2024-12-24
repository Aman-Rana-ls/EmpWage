using System;

namespace WageCalculator
{
    internal class Employee
    {

        private static int TotalEarning = 0;
        private static int HourLimit = 16;
        private static Random rnd = new Random();

        public static int ComputeDailyEarnings()
        {
            Console.WriteLine("The Employee is Present.");
            int[] arr = HourLimit < 8 ? new int[] { 0, 4 } : new int[] { 0, 4, 8 };
            int h = arr[rnd.Next(arr.Length)];
            int todaysEarning = 0;

            switch (h)
            {
                case 0:
                    Console.WriteLine("The Employee didn't earn money today as he didn't work at all.");
                    Console.WriteLine($"Today's Earning = {todaysEarning}\n");
                    break;

                case 4:
                    if (HourLimit >= 4)
                    {
                        Console.WriteLine("The Employee earned 80Rs today as he worked for 4 Hours Half Time.");
                        todaysEarning += 80;
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
                        HourLimit -= 8;
                    }
                    else
                    {
                        Console.WriteLine("Not enough hours left to work 8 hours today.\n");
                    }
                    break;
            }

            Console.WriteLine($"Today's Earning = {todaysEarning}\n");
            return todaysEarning;
        }

        public static void CalculateWages(int days)
        {
            for (int day = 1; day <= days; day++)
            {
                if (HourLimit < 4)
                {
                    Console.WriteLine("The Work Hour Limit has been exceeded");
                    break;
                }

                Console.WriteLine($"Day {day}");
                int attendance = rnd.Next(0, 2); 

                if (attendance == 0)
                {
                    Console.WriteLine("The Employee is Absent.\n");
                }
                else
                {
                    TotalEarning += ComputeDailyEarnings();
                }
            }

            Console.WriteLine($"Total Money earned by the employee is {TotalEarning}Rs");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int workingDays = 20; 
            Employee.CalculateWages(workingDays); 
            Console.ReadKey();
        }
    }
}
