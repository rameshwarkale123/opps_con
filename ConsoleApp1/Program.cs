using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public class calculator
        {
           public int calculatesum(int x, int y)
            {
                return x + y;
            }
        }
        static void Main(string[] args)
        {
            calculator mycal = new calculator();
            int result = mycal.calculatesum(11, 20);
            Console.WriteLine(result);
            Console.ReadLine();

            
        }
    }
}
