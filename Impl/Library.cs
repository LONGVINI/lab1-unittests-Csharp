// Library.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace Impl
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    public class Library
    {
        // Бібліотека зберігає книги як список словників
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        /// <summary>
        /// Додає книгу до бібліотеки.
        /// </summary>
        /// <param name="title">Назва книги</param>
        /// <param name="author">Автор книги</param>
        public void AddBook(string title, string author)
        {
            books.Add(new Book { Title = title, Author = author });
        }

        /// <summary>
        /// Видаляє книгу з бібліотеки за її назвою.
        /// </summary>
        /// <param name="title">Назва книги для видалення</param>
        public void RemoveBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    books.RemoveAt(i);
                    return;
                }
            }
            // Помилка: метод нічого не робить, якщо книгу не знайдено.
        }

        /// <summary>
        /// Знаходить усі книги, написані певним автором.
        /// </summary>
        /// <param name="author">Ім'я автора</param>
        /// <returns>Список назв книг, написаних автором</returns>
        public List<string> FindBooksByAuthor(string author)
        {
            // Помилка: повертає лише першу знайдену книгу, а не всі книги автора
            foreach (var book in books)
            {
                if (book.Author == author)
                {
                    return new List<string> { book.Title };
                }
            }
            return new List<string>();
        }

        /// <summary>
        /// Знаходить книги, які містять вказану назву.
        /// </summary>
        /// <param name="title">Назва або частина назви книги</param>
        /// <returns>Список книг, назви яких містять вказаний текст</returns>
        public List<Book> FindBooksByTitle(string title)
        {
            // Помилка: порівняння відбувається тільки за точним збігом
            foreach (var book in books)
            {
                if (book.Title == title)
                {
                    return new List<Book> { book };
                }
            }
            return new List<Book>();
        }
    }
}