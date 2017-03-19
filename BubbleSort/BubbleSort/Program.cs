using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Algorithms_BubbleSort
{

    public class Program
    {
        public static void bubbleSort1(ref int[] x)
        {
            bool exchanges;
            do
            {
                exchanges = false;
                for (int i = 0; i < x.Length - 1; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        // Exchange elements
                        int temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        exchanges = true;
                    }
                }
            } while (exchanges);
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
            Console.WriteLine("Sorting Algorithms Demo Code\n\n");

            const int nItems = 20;
            Random rdn = new Random(nItems);
            int[] xdata = new int[nItems];
            MixDataUp(ref xdata, rdn);
            DisplayElements(ref xdata, 'b', "");
            Console.WriteLine();
            bubbleSort1(ref xdata);
            DisplayElements(ref xdata, 'a', "bubbleSort1");
            Console.WriteLine("\n\n");
            Console.WriteLine("Press Enter to Exit...");
        }
    }

}