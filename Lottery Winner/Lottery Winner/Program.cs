using System;

namespace Lottery_Winner
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0, 100);
            Console.WriteLine("Guess a number between 1 and 100 and see if you won the lottery?");
            string num = Console.ReadLine();
            double w = Convert.ToDouble(num);
            if (w==winNum)
                Console.WriteLine("Congratulations you won!");
            else
                Console.WriteLine("Better Luck next time!");
        }
    }
}
