//using System;


//class Book
//{

//    private string ISBN { get; set; }
//    protected string Title { get; set; }
//    private string Author { get; set; }

//    // Constructor to initialize book details
//    public Book(string isbn, string title, string author)
//    {
//        ISBN = isbn;
//        Title = title;
//        Author = author;
//    }

//    // Public method to get the ISBN
//    public string GetISBN()
//    {
//        return ISBN;
//    }

//    // Public method to set the ISBN
//    public void SetISBN(string isbn)
//    {
//        ISBN = isbn;
//    }

//    // Public method to get the author name
//    public string GetAuthor()
//    {
//        return Author;
//    }

//    // Public method to set the author name
//    public void SetAuthor(string author)
//    {
//        Author = author;
//    }

//    // Method to display book details
//    public void DisplayBookDetails()
//    {
//        Console.WriteLine($"ISBN: {GetISBN()}");
//        Console.WriteLine($"Title: {Title}");
//        Console.WriteLine($"Author: {GetAuthor()}");
//    }
//}

//class EBook : Book
//{
//    // Constructor to initialize EBook details, calling base class constructor
//    public EBook(string isbn, string title, string author) : base(isbn, title, author)
//    {
//    }

//    // Method to display the ISBN and Title of the EBook
//    public void DisplayEBookDetails()
//    {
//        Console.WriteLine($"EBook ISBN: {GetISBN()}");
//        Console.WriteLine($"EBook Title: {Title}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Creating an instance of Book
//        Book book1 = new Book("978-3-16-148410-0", "C# Programming", "John Doe");
//        book1.DisplayBookDetails();

//        // Accessing and modifying         Console.WriteLine($"Author before update: {book1.GetAuthor()}");
//        book1.SetAuthor("Jane Doe"); // Modifying author
//        Console.WriteLine($"Author after update: {book1.GetAuthor()}");
//        Console.WriteLine();

//        // Creating an instance of EBook
//        EBook ebook1 = new EBook("978-1-23-456789-0", "Advanced C#", "Alice Smith");
//        ebook1.DisplayEBookDetails();
//        ebook1.DisplayBookDetails();
//        Console.ReadLine();

//    }
//}

