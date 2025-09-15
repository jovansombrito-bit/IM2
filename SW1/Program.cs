using System;

class Program
{
    
    static bool IsPrime(int num)
    {
        if (num <= 1) return false; 

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
                return false; 
        }
        return true;
    }

    
    static void ConvertCurrency(double dollar, out double peso, out double yen)
    {
        double ratePeso = 57.17;   
        double rateYen = 146.67;   

        peso = dollar * ratePeso;
        yen = dollar * rateYen;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int count = 1;
        foreach (string n in numbers)
        {
            int num = int.Parse(n);

            if (IsPrime(num))
                Console.WriteLine($"{count}. {num}\tPrime");
            else
                Console.WriteLine($"{count}. {num}\tComposite");

            count++;
        }

        Console.WriteLine("\n----------------------------\n");

        Console.Write("Enter currency in ($): ");
        string dollarInput = Console.ReadLine();

        string[] dollarValues = dollarInput.Split(',');

        Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen(¥)");
        foreach (string d in dollarValues)
        {
            double usd = double.Parse(d);
            ConvertCurrency(usd, out double peso, out double yen);
            Console.WriteLine($"{usd}\t\t{peso}\t{yen}");
        }
        Console.ReadKey();
    }
}
