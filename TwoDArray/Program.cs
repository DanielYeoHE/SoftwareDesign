//
// ICT2106 Software Design - 2D array example
//
// Main program.
//
// Author: Nicholas Sheppard
//
using System;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and fill a 3 x 3 array of integers
            ITwoDArray<String> array = new TwoDArrayGeneric<String>(3, 3);
            // array.Set(0, 0, 9); 
            // array.Set(0, 1, 4); 
            // array.Set(0, 2, 1);
            // array.Set(1, 0, 2); 
            // array.Set(1, 1, 5); 
            // array.Set(1, 2, 3);

            // [ "Sarah", null, "Yixin"  ]
            // [  null , null, "Faizal"  ]
            // [ "Daniel", null, "Peter" ]

            array.Set(0, 0,"Sarah");
            array.Set(0, 1, null);
            array.Set(0, 2, "Yixin");
            array.Set(1, 0, null);
            array.Set(1, 1, null);
            array.Set(1, 2, "Faizal");
            array.Set(2, 0, "Daniel");
            array.Set(2, 1, "Peter");
            array.Set(2, 2, null);

            // display the array in row major order
            ITwoDIterator<String> rowIter = array.CreateRowMajorIterator();
            ITwoDIterator<String> reverseIter = array.CreateReverseIterator();

            // print the output to console
            Console.WriteLine("Reverse traverse iteration: ");
            while (!reverseIter.IsDone())
            {  
                var currentValue = reverseIter.Current();
                Console.Write(currentValue + " ");
                reverseIter.Next();
            }

            Console.WriteLine("\n===========================\n");
            Console.WriteLine("Row major iteration: ");

            while (!rowIter.IsDone())
            {
                var currentValue = rowIter.Current();
                Console.Write(currentValue + " ");
                rowIter.Next();
            }

            // pause the console.
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
