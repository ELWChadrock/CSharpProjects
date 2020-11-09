using System;

namespace Assignment168
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool duiResponse = false;
            string duiAnswer = Convert.ToString(duiResponse);
            Console.WriteLine("How many Speeding Tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            if (age > 15 || duiResponse || false || tickets > 3) 
            {
                Console.WriteLine("You are qualified!");
            }
            else
            {
                Console.WriteLine("You are not qualified!");
            }
        }
    }
}
