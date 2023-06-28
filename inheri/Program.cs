using System;
using System.Text;
namespace inheri
{
      class A
    { 
       public void M1()
        {
            Console.WriteLine("Hii");
        }
        public void M2()
        {
            Console.WriteLine("Hello");
        }
    }
    class B:A
    {
        public void M3()
        {
            Console.WriteLine("Evryone");
        }
        static void Main(string[] args)

        {
            B myobj = new B();
            myobj.M1();
            myobj.M2();
            myobj.M3();
            Console.ReadLine();

        }
    }
   
    
}
