using System;
using System.Collections.Generic;
using System.Linq;

class Flowers
{

    public static void Main()
    {

        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic.Add("Rose", "Red");
        dic.Add("Tulip", "Yellow");
        dic.Add("Daisy", "White");

        if (dic.Count == 0)
        {
            Console.WriteLine("Dictionary is empty");
        }
        else
        {
            Console.WriteLine("Dictionary has  elements");
        }

        Console.WriteLine("Flowers in dictionary:");

        for (int i = 0; i < dic.Count; i++)
        {
            Console.WriteLine($"{dic.Keys.ElementAt(i)}: {dic.Values.ElementAt(i)}");
        }

    }
}






