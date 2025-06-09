using System;

namespace LibraryManager
{
    public class LibraryItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }

        // Constructor
        public LibraryItem(int id, string title, int yearPublished)
        {
            ID = id;
            Title = title;
            YearPublished = yearPublished;
        }

        public override string ToString()
        {
            return $"{ID}: {Title} ({YearPublished})";
        }
    }

    // Separate classes - NOT nested!
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        // Constructor that calls base constructor
        public Book(int id, string title, int yearPublished, string author, string genre)
            : base(id, title, yearPublished)
        {
            Author = author;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Author: {Author}, Genre: {Genre}";
        }
    }

    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string Month { get; set; }

        // Constructor that calls base constructor
        public Magazine(int id, string title, int yearPublished, int issueNumber, string month)
            : base(id, title, yearPublished)
        {
            IssueNumber = issueNumber;
            Month = month;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Issue: {IssueNumber}, Month: {Month}";
        }
    }

    public class DVD : LibraryItem
    {
        public string Director { get; set; }
        public int Duration { get; set; }

        // Constructor that calls base constructor
        public DVD(int id, string title, int yearPublished, string director, int duration)
            : base(id, title, yearPublished)
        {
            Director = director;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Director: {Director}, Duration: {Duration} mins";
        }
    }
}