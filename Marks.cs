using System;
using System.Collections.Generic;

class Marks
{
    public static void Main()
    {
        // Tworzenie słownika z imieniem ucznia i jego oceną
        Dictionary<string, int> StudentGrades = new Dictionary<string, int>();

        // Dodawanie uczniów i ich ocen
        StudentGrades.Add("Tom", 96);
        StudentGrades.Add("Max", 45);
        StudentGrades.Add("Joe", 85);
        StudentGrades.Add("Jack", 69);
        StudentGrades.Add("Jule", 59);

        // Sprawdzanie oceny ucznia
        Console.WriteLine("Podaj imię ucznia, którego chcesz sprawdzić:");
        string name = Console.ReadLine();

        if (StudentGrades.ContainsKey(name))
        {
            Console.WriteLine($"Ocena ucznia {name}: {StudentGrades[name]}");
        }
        else
        {
            Console.WriteLine($"Uczeń {name} nie został znaleziony.");
        }

        // Aktualizacja oceny ucznia "Tom"
        StudentGrades["Tom"] = 30;
        Console.WriteLine($"Zaktualizowana ocena Toma: {StudentGrades["Tom"]}");

        // Usunięcie ucznia "Joe"
        StudentGrades.Remove("Joe");

        // Wyświetlenie pozostałych uczniów i ich ocen
        Console.WriteLine("\nPozostali uczniowie i ich oceny:");
        foreach (var student in StudentGrades)
        {
            Console.WriteLine($"Uczeń: {student.Key}, Ocena: {student.Value}");
        }
    }
}
