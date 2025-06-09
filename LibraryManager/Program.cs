using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_7_Library_system
{
    public class LibraryItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }

        public LibraryItem(int id, string title, int yearPublished)
        {
            ID = id;
            Title = title;
            YearPublished = yearPublished;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Title: {Title}, Year: {YearPublished}";
        }


        public class Book : LibraryItem
        {
            public string Author { get; set; }
            public string Genre { get; set; }

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
        class Magazine : LibraryItem //Defines a Magazine class that inherit stuff from 
        {
            public string IssueNumber { get; set; }
            public int Month { get; set; }

            public Magazine(int id, string title, int yearPublished, string issueNumber, int month)
                : base(id, title, yearPublished)
            {
                IssueNumber = issueNumber;
                Month = month;
            }
            public override string ToString() // Overrides the ToString() method to provide a string representation of the Book
            {
                return $"{base.ToString()}, Author: {IssueNumber}, Genre: {Month}"; // Returns a string with all Book details, including those from LibraryItem
            }

        }








    }
}