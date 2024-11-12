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

        void DisplayAge(Dictionary<string, int> dictionary, string name)
        {

            if (dictionary.ContainsKey(name))
            {

                Console.WriteLine($"Person: {name}, Age: {dictionary[name]}");
            }
            else
            {
                Console.WriteLine($"Person {name} not found in the dictionary.");
            }
        }
        // Task 1
        DisplayAge(id, "Anna");

        // Task 2
        DisplayAge(id, "Mark");


    }
}






// if (id.ContainsKey("Anna"))
// {

//     Console.WriteLine($"Person Anna, Age: {id["Anna"]}");
// }
// else
// {

//     Console.WriteLine("Person not found in the dictionary.");
// }


// //Task 2 

// if (id.ContainsKey("Mark")){
//     Console.WriteLine($"Person Mark, Age: {id["Mark"]}");
// }else {
//     Console.WriteLine("Person not found in the dictionary.");
// }

