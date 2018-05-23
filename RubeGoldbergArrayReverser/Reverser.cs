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
    // This class manages the business logic of the Rube Goldberg
    // Array Reverser which was intended to process a simple array
    // reversing task through a more complex version of the logic.
    class Reverser
    {
        private readonly object[] targetArray;

        public Reverser(object[] targetArray)
        {
            this.targetArray = targetArray;
        }

        public object[] ReverseArray()
        {
            // Making a dictionary of the target array. The keys will
            // have an iterative index value.
            Dictionary<string, object> arrayDict = new Dictionary<string, object>();
            for (int i = 0; i < targetArray.Length; i++)
            {
                arrayDict.Add(i.ToString(), targetArray[i]);
            }

            // Instantiating a reversedArray to refer the reversed
            // version of the targetArray.
            object[] reversedArray = new object[arrayDict.Count];
            for (int i = 0; i < reversedArray.Length / 2; i++)
            {
                object tempObj = arrayDict[i.ToString()];
                arrayDict[i.ToString()] = arrayDict[(reversedArray.Length - i - 1).ToString()];
                arrayDict[(reversedArray.Length - i - 1).ToString()] = tempObj;
            }

            // Store reversed values of array dictionary to a reversed array.
            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[i] = arrayDict[i.ToString()];
            }

            return reversedArray;
        }
    }
}
