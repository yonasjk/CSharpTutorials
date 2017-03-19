using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicStrings
{
    class Program
    {
        /// <summary>
        /// Determines whether the string is a palindrome.
        /// </summary>
        public static bool IsPalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        static void Main()
        {
            string[] array =
    {
        "civic",
        "deleveled",
        "Hannah",
        "kayak",
        "level",
        "examiron",
        "racecar",
        "radar",
        "refer",
        "reviver",
        "easywcf",
        "rotator",
        "rotor",
        "sagas",
        "solos",
        "stats",
        "tenet",
        "Csharpstar",
        ""
    };

            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }
        }
    }
}
