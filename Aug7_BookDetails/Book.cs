﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignment
{
    internal class Book : ILendable
    {
        private readonly int bookId;
        private String? title, author;
        private bool isAvailable;

        public Book(int bookId, string title, string author)
        {
            this.bookId = bookId;
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public int BookId => bookId;
        public string? Title { get => title; set => title = value; }
        public string? Author { get => author; set => author = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

        public void LentItem()
        {
            IsAvailable = false;
        }

        public void SearchBook(string title)
        {

            Console.WriteLine($"\n ID : {BookId}, TITLE : {Title}, AUTHOR : {Author}, Availability : {IsAvailable}");
        }

        public void SearchBook(int id)
        {
            Console.WriteLine($"\n ID : {BookId}, TITLE : {Title}, AUTHOR : {Author}, Availability : {IsAvailable}");
        }
    }
}
