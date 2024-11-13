using System.Collections.Generic;
using System;
class Books
{

    public static void Main()
    {

        Dictionary<string, int> books = new Dictionary<string, int>();

        books.Add("Harry Potter", 20);
        books.Add("Drragons", 30);
        books.Add("Baby Yoda", 40);
        books.Add("Max and team", 45);
        books.Add("Kung Fu Bum", 98);

        Console.WriteLine("Podaj nazwe ksiazki by zobaczyc ile jest egzeplarzy:");
        string bookinfo = Console.ReadLine();

        if (books.ContainsKey(bookinfo)) { 
            Console.WriteLine($"Book: {bookinfo} has {books[bookinfo]} copy");
            
            books[bookinfo] -= 1;
            Console.WriteLine($"Update book {bookinfo} minus 1: {books[bookinfo]}  ");

        }else {
            Console.WriteLine($"Book {bookinfo} is not found");
        }

        Console.WriteLine("\nLiczba wszystkich egzemplarzy:");
        foreach (var book in books) {
            Console.WriteLine($"Book: {book.Value}, amount: {book.Key}");

        }
    }
}