using System;
using System.Collections.Generic;

class FruitsPrice
{

    public static void Main()
    {
        Dictionary<string, int> price = new Dictionary<string, int>();

        price.Add("Apple", 10);
        price.Add("Banana", 3);
        price.Add("Melon", 2);
        price.Add("Cherry", 50);
        price.Add("Kiwi", 16);

        Console.WriteLine("What fruits you need?");
        string userInput = Console.ReadLine();
        if (price.ContainsKey(userInput))
        {
            Console.WriteLine($"You're right {userInput} ");
        }
        else
        {
            Console.WriteLine($"{userInput} is not here ");
        }



        Console.WriteLine("\nAll fruits and their prices:");
        foreach (var item in price)
        {
            Console.WriteLine($"{item.Key}: {item.Value} zł");
        }



    }
}