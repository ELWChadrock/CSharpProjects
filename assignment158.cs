using System;

namespace Assignment158
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is a cool number?");
            int answerWith = Convert.ToInt32(Console.ReadLine());
            int product = answerWith * 50;
            Console.WriteLine(product);
            int total = answerWith + 25;
            Console.WriteLine(total);
            int quotient = (int)(answerWith / 12.5);
            Console.WriteLine(quotient);
            bool isOver = answerWith > 50;
            Console.WriteLine(isOver);
            int remainder = answerWith % 7;
            Console.WriteLine(remainder);

        }
    }
}
