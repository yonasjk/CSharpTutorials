using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Algorithms_LinearSearch
{
    public class Program
    {
        public static int LinearSearch(ref int[] x, int valueToFind)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (valueToFind == x[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static void DisplayElements(ref int[] xArray, char status, string sortname)
        {
            if (status == 'a')
                Console.WriteLine("After sorting using algorithm: " + sortname);
            else
                Console.WriteLine("Before sorting");
            for (int i = 0; i <= xArray.Length - 1; i++)
            {
                if ((i != 0) && (i % 10 == 0))
                    Console.Write("\n");
                Console.Write(xArray[i] + " ");
            }
            Console.ReadLine();
        }

        static void MixDataUp(ref int[] x, Random rdn)
        {
            for (int i = 0; i <= x.Length - 1; i++)
            {
                x[i] = (int)(rdn.NextDouble() * x.Length);
            }
        }

        public static void Main(string[] args)
        {
            const int nItems = 20;
            Random rdn = new Random(nItems);
            int[] xdata = new int[nItems];
            MixDataUp(ref xdata, rdn); //Randomize data to be searched
            DisplayElements(ref xdata, 'b', ""); //Display random data

            Console.WriteLine("Using LINEAR SEARCH ALGORITHM " +
                    "to look for 4th data entry in randomized list");
            //Look for the 4th data entry in the list
            int location = LinearSearch(ref xdata, xdata[4]);
            if (location == -1)
                Console.WriteLine("Value was not found in list");
            else
                Console.WriteLine("Found it at location = {0}", location);
            location = LinearSearch(ref xdata, 19); //Look for the number 19 in the list.
            if (location == -1)
                Console.WriteLine("Value of 19 was not found in list");
            else
                Console.WriteLine("Value of 19 was found at location = {0}", location);
            Console.WriteLine("\n\n");
        }
    }

}