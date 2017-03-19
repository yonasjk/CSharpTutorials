using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearchTest
    {
        static void Main(string[] args)
        {
            int searchInt; // seach key
            int position; // location of search key in array

            // create array and output it
            BinaryArray searchArray = new BinaryArray(15);
            Console.WriteLine(searchArray);

            // prompt and input first int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // repeatedly input an integer; -1 terminates the application
            while (searchInt != -1)
            {
                // use binary search to try to find integer
                position = searchArray.BinarySearch(searchInt);

                // return value of -1 indicates integer was not found
                if (position == -1)
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);

                // Prompt and input next int from user 
                Console.WriteLine("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            }
        }
    }
}
