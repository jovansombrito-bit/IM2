using System;
using System.Collections.Generic;

class PalindromeChecker
{
    static void Main()
    {
        List<string> inputs = new List<string>();
        List<string> reversedList = new List<string>();
        List<string> results = new List<string>();

        while (true)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            if (str == "*")
                break;

            string original = str;

            // Reverse manually
            string reversed = "";
            for (int i = original.Length - 1; i >= 0; i--)
            {
                reversed += original[i];
            }

            // Check palindrome (case-insensitive)
            string result = (original.ToLower() == reversed.ToLower()) ? "Yes" : "No";

            inputs.Add(original);
            reversedList.Add(reversed);
            results.Add(result);
        }

        Console.WriteLine();
        Console.WriteLine("{0,-20}{1,-20}{2,-15}", "Original String", "Reversed String", "Palindrome?");
        Console.WriteLine(new string('-', 55));

        for (int i = 0; i < inputs.Count; i++)
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-15}",
                inputs[i], reversedList[i], results[i]);
        }

        Console.WriteLine("\n//End execution");
    }
}
