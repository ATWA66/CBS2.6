using System;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine(Book.Notes.AddNote("lll"));
        }
        class Book
        {
            public static class Notes
            {
                public static string notes { get; set; } = "notes:";
                public static string AddNote(string note)
                {
                    notes += note;
                    return notes;
                }
            }
        }
    }
}
