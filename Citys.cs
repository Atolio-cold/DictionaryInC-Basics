using System;
using System.Collections.Generic;

class Citys
{

    public static void Main()
    {

        Dictionary<string, string> map = new Dictionary<string, string>();

        map.Add("Alan", "York");
        map.Add("Mick", "London");
        map.Add("Tom", "Paris");
        map.Add("Brajan", "Warsaw");
        map.Add("Vit", "New York");

        map.Remove("Vit");
        map.Remove("Alan");

        foreach (var item in map)
        {
            Console.WriteLine($"Name: {item.Key}, City: {item.Value}");
        }
    }

}