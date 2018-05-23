using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 *  @author: Namyoon Kim    j4yn3rd@gmail.com
 * 
 *  The Rube Goldberg Array Reverser without any bugs.
 **/

namespace RubeGoldbergArrayReverser
{
    // This program reverses an order of the pre-defined array.
    class Program
    {
        static void Main(string[] args)
        {
            // Original array.
            object[] targetArray = new object[] { 1, "B", 3, "D", 5 };

            // Instantiating a reverser object.
            Reverser reverser = new Reverser(targetArray);

            // Receiving a reversed version of the original array.
            object[] reversedArray = reverser.ReverseArray();

            // Printing original elements in the array.
            Console.WriteLine("Original Array:");
            foreach (object element in targetArray)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("");

            // Printing reversed elements in the array.
            Console.WriteLine("Reversed Array:");
            foreach (object element in reversedArray)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("End of the process.");
            Console.ReadKey();
        }
    }
}
