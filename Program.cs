using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {

        static Dictionary<char, int> GetCharFrequency(string input)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c != ' ' && c != ',')
                {
                    if (freq.ContainsKey(c))
                        freq[c]++;
                    else
                        freq[c] = 1;
                }
            }

            return freq;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            Dictionary<char, int> result = GetCharFrequency(str);


            foreach (KeyValuePair<char, int> pair in result)
            {
                Console.Write($"{pair.Key}={pair.Value}, ");
            }

            Console.WriteLine();

            Console.ReadKey();

        }

    
}
}
