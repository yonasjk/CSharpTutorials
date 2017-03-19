using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Algorithmns_CockTailSort
{

    public class Program
    {
        public static void CocktailSort(ref int[] x)
        {
            for (int k = x.Length - 1; k > 0; k--)
            {
                bool swapped = false;
                for (int i = k; i > 0; i--)
                    if (x[i] < x[i - 1])
                    {
                        // swap
                        int temp = x[i];
                        x[i] = x[i - 1];
                        x[i - 1] = temp;
                        swapped = true;
                    }

                for (int i = 0; i < k; i++)
                    if (x[i] > x[i + 1])
                    {
                        // swap
                        int temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        swapped = true;
                    }

                if (!swapped)
                    break;
            }
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

            const int nItems = 50;
            Random rdn = new Random(nItems);
            int[] xdata = new int[nItems];
            MixDataUp(ref xdata, rdn);
            Console.WriteLine();
            DisplayElements(ref xdata, 'b', "");
            Console.WriteLine();
            CocktailSort(ref xdata);
            DisplayElements(ref xdata, 'a', "CocktailSort");
            Console.WriteLine("\n\n");
        }


    }

}