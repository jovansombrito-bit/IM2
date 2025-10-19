using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter row: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter col: ");
        int cols = int.Parse(Console.ReadLine());

        List<List<double>> matrix = new List<List<double>>();

        double sum = 0;
        int count = 0;

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Row {i + 1}");
            List<double> row = new List<double>();

            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter number{j + 1}: ");

                string input = Console.ReadLine();
                double num;

                // Try parsing with '.' as decimal separator
                if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out num))
                {
                    Console.WriteLine("Invalid input, setting value to 0.");
                    num = 0;
                }

                row.Add(num);
                sum += num;
                count++;
            }

            matrix.Add(row);
        }

        Console.WriteLine("\nThe numbers are:");
        foreach (var row in matrix)
        {
            foreach (var num in row)
            {
                Console.Write(num.ToString("0.0", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
        }

        double average = (count > 0) ? sum / count : 0;
        Console.WriteLine($"\nSum: {sum:0.0} ; Average: {average:0.0}");
    }
}
