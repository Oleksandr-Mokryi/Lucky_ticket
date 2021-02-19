using System;
using System.Linq;

namespace Lucky_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your ticket number");
                string text = Console.ReadLine();
                bool isInt = int.TryParse(text, out int mark);
                if (!isInt || int.Parse(text) < 0 || text.Length < 4 || text.Length > 8)
                {
                    Console.WriteLine("No ticket number is found. Please try again");
                    continue;
                }
                if (text.Length % 2 != 0)
                {
                    text = '0' + text;
                }
                int[] digits = text.Select(n => (n - '0')).ToArray();
                int half_1 = 0;
                int half_2 = 0;
                for(int i = 0; i < digits.Length / 2; i++)
                {
                    half_1 += digits[i];
                }
                for (int i = digits.Length / 2; i < digits.Length; i++) 
                {
                    half_2 += digits[i];
                }
                if (half_1 == half_2)
                {
                    Console.WriteLine("Lucky one!");
                }
                else
                {
                    Console.WriteLine("Better luck next time");
                }
            }
        }
    }
}
