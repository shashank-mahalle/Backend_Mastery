using System;

class Generics
{




    public static void Main(string[] args)
    {
        /// Dictionary
        // ✅ Safe — always use this
        if (exchangeRates.TryGetValue("XYZ", out decimal rate))
            Console.WriteLine(rate);
        else
            Console.WriteLine("Key not found");

    }


}