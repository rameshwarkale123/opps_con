using System;

namespace abstraction
{  abstract class Note
    {
        public abstract void bookSub();
    }
    class TextB : Note
    {
        public override void bookSub()
        {
            Console.WriteLine("Eng");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            TextB b = new TextB(); // create a object TextB class
            b.bookSub();
            Console.WriteLine("Hello World!");
        }
    }
}
