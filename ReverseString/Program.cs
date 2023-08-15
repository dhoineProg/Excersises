using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        static string ProcessString(string inputS)
        {
            if (inputS.Length % 2 == 0)
            {
                int hLength = inputS.Length / 2;
                string subString1 = ReverseString(inputS.Substring(0, hLength));
                string subString2 = ReverseString(inputS.Substring(hLength));
                return subString1 + subString2;
            }
            else
            {
                string reversedString = ReverseString(inputS);
                return reversedString + inputS;
            }

        }

        static string ReverseString(string inputS)
        {
            char[] charArray = inputS.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string inputS = Console.ReadLine();

            string procesString = ProcessString(inputS);

            Console.WriteLine(procesString);

            Console.ReadLine();
        }
    }
}
