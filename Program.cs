using System;

namespace C_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            // for a method to exectue we must call it by name.
            MyMethod();

            // Let's try an array!
            int[] myarray = new int[5] {3,4,5,6,7};
            myarray[0] = 2; // Update value by index. // ARRAY START AT INDEX ZERO!
            Console.WriteLine(myarray[0]); // Output a value by index.

            // // For Loop!
            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine("Array Index:"+i+"| Array Value:" + myarray[i] );
            }

            // While Loop!
            int n = 0;
            while ( n < 5 ) 
            {
                Console.WriteLine("Array Index:"+n+"| Array Value:" + myarray[n] );
                // n += 2;
                n = n + 2;
            }

            // Foreach Loop! // They stop themselves at the end of the collection.
            foreach (int e in myarray) // Assignment in Collection.
            {
                Console.WriteLine("Current Foreach Vaule is:" + e);
            }
        }
        
        // Let's try making a method.
        static void MyMethod()
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

            Console.WriteLine("Test!");
        }
    }
}
