using System;

namespace Attendence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  

            int n = rnd.Next(0,2);
            if (n == 0) {
                Console.WriteLine("The Employee is Absent");
            }
            else
            {
                Console.WriteLine("The Employee is Present");
            }
            Console.ReadKey();  

        }
    }
}
