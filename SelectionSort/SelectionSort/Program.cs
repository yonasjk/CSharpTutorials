using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmns_SelectionSort
{
    class Program
    {
        //Console program entry point
        static void Main(string[] args)
        {
            //Sample data values
            int array_size = 10;
            int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };

            
            Console.WriteLine("The Array Before Selection Sort is: ");

            //Initial array output (to console)
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine(array[i]);
            }

            //new variable initialization
            int tmp, min_key;

            //outer and inner loops (w/comparison)
            for (int j = 0; j < array_size - 1; j++)
            {
                min_key = j;

                for (int k = j + 1; k < array_size; k++)
                {
                    if (array[k] < array[min_key])
                    {
                        min_key = k;
                    }
                }

                tmp = array[min_key];
                array[min_key] = array[j];
                array[j] = tmp;
            }

            //post sort output (to console)
            Console.WriteLine("The Array After Selection Sort is: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
