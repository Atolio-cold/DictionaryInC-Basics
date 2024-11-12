using System;
using System.Collections.Generic;
class Cars
{

    public static void Main()
    {
        Dictionary<string, string> fruits = new Dictionary<string, string>();

        fruits.Add("1", "Bannana");
        fruits.Add("2", "Apple");
        fruits.Add("3", "Orange");

        foreach (var fruit in fruits){
            Console.WriteLine($"{fruit.Key} {fruit.Value}");
        }
        Console.WriteLine($"Fruits count: {fruits.Count}");

    }

}
