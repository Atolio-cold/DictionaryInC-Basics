using System;
using System.Collections.Generic;
using System.Linq;

class Autor
{

    public static void Main()
    {

        Dictionary<string, string> books = new Dictionary<string, string>();

        books.Add("1984", "George Orwell");
        books.Add("To Kill a Mockingbird", "Harper Lee");
        books.Add("The Great Gatsby", "F. Scott Fitzgerald");
        books.Add("Moby Dick", "Herman Melville");
        books.Add("Pride and Prejudice", "Jane Austen");

       string bookToFind = "1984";
        if (books.ContainsKey(bookToFind))
        {
            string author = books[bookToFind];
            Console.WriteLine($"Author of '{bookToFind}' is {author}");
        }
        else
        {
            Console.WriteLine("Book not found");
        }

        Console.WriteLine("\nAll books:");
        foreach (var book in books)
        {
            Console.WriteLine($"Book: {book.Key}, Author: {book.Value},");
        }



    }
}