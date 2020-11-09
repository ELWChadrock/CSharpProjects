using System;

namespace Assignment159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int person1rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours worked per week?");
            int person1hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int person2rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours worked per week?");
            int person2hours = Convert.ToInt32(Console.ReadLine());
            int product = person1rate * person1hours;
            int product2 = person2rate * person2hours;
            Console.WriteLine("Annual Salary of Person 1:" + product * 52);
            Console.WriteLine("Annual Salary of Person 2:" + product2 * 52);
            Console.WriteLine("Does Person 1 make more money then Person 2?");
            bool person1 = person1rate > person2rate;
            Console.WriteLine(person1);


        }
    }
}
