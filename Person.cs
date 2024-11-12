using System;
using System.Collections.Generic;

class Person
{

    public static void Main()
    {
        //Task 1
        Dictionary<string, int> id = new Dictionary<string, int>();

        id.Add("Anna", 50);
        id.Add("Tom", 45);
        id.Add("Marcus", 38);
        id.Add("Joe", 24);

        if (id.ContainsKey("Anna"))
        {

            Console.WriteLine($"Person Anna, Age: {id["Anna"]}");
        }
        else
        {

            Console.WriteLine("Person  not found in the dictionary.");
        }

    }
}