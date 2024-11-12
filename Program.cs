using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tworzenie słownika o kluczach typu string i wartościach typu string
        Dictionary<string, string> owoce = new Dictionary<string, string>();

        // Dodawanie par klucz-wartość do słownika
        owoce.Add("jabłko", "czerwone");
        owoce.Add("banan", "żółty");
        owoce.Add("wiśnia", "czerwony");

        // Uzyskanie dostępu do wartości na podstawie klucza
        Console.WriteLine("Kolor jabłka to: " + owoce["jabłko"]); // wynik: czerwone

        // Sprawdzanie, czy klucz istnieje
        if (owoce.ContainsKey("banan"))
        {
            Console.WriteLine("Kolor banana to: " + owoce["banan"]); // wynik: żółty
        }

        // Iteracja po wszystkich elementach słownika
        foreach (var owoc in owoce)
        {
            Console.WriteLine($"{owoc.Key}: {owoc.Value}");
        }
    }
}
