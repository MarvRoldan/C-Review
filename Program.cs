using System;

namespace C_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 35;
            Console.WriteLine("Hello World!" + x);

            if ( x < 30)
            {
                Console.WriteLine("X is less than thirty!");
            }
            else if (x == 30) 
            {
                Console.WriteLine("X is thirty!");
            }
            else
            {
                Console.WriteLine("X is greater than thirty!");
            }

            int a = 3;
            switch (a)
            {
                case 1:
                    Console.WriteLine("Value is 1!");
                    break;
                case 2: 
                    Console.WriteLine("Value is 2!");
                    break;
                case 3:
                    Console.WriteLine("Value is 3!");
                    break;
                default:
                    Console.WriteLine("Uh oh, it is another value!");
                    break;
            }

            // for a method to exectue we must call it by name.
            MyMethod();
        }
        
        // Let's try making a method.
        static void MyMethod()
        {
            Console.WriteLine("Test!");
        }
    }
}
