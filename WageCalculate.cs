using System;

namespace WageCalculator
{
    internal class Program
    {
        public static int Earned(int c)
        {
            Random rnd = new Random();
            Console.WriteLine("The Employee is Present.");
            int[] arr = { 0, 4, 8 };
            int h = arr[rnd.Next(arr.Length)];

            switch (h)
            {
                case 0:
                    Console.WriteLine("The Employee didn't earn money today as he didn't work at all.");
                    Console.WriteLine("Todays Earning=\t" + c + "\n");
                    break;

                case 4:
                    Console.WriteLine("The Employee earned 80Rs today as he worked for 4 Hours Half Time.");
                    c += 80;
                    Console.WriteLine("Todays Earning=\t" + c + "\n");
                    break;

                case 8:
                    Console.WriteLine("The Employee earned 160Rs today as he worked for 8 Hours Full Time.");
                    c += 160;
                    Console.WriteLine("Todays Earning=\t" + c + "\n");

                    break;
            }
            return c;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int t = 21;
            int sum = 0;
            for (int i = 1; i < t; i++)
            {
                {
                    int c = 0;
                    int n = rnd.Next(0, 2);
                    if (n == 0)
                    {
                        Console.WriteLine("Day" + i);
                        Console.WriteLine("The Employee is Absent.\n");
                    }
                    else
                    {

                        Console.WriteLine("Day" + i);
                        c = Earned(c);
                    }
                    sum += c;
                }
            }
                Console.WriteLine("Total Money earned by the employee is\t" + sum + "Rs");

                Console.ReadKey();
            }
        }
    }

