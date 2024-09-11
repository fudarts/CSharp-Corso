using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Library
        {
            // Da modificare se si cambia computer
            string folderPath = "F:\\Codes\\VS_COMPILER\\CSharpCorso\\BookStore\\Library";
            //string folderPath = "..\\CSharpCorso\\BookStore\\Library";
            string nomeFile = "Catalog.txt";
            internal Library()
            {
                // Crea la cartella Library
                Directory.CreateDirectory(folderPath);
                // Crea il file catalog.txt nella cartella Library se non esiste
                if (File.Exists(folderPath + "\\" + nomeFile) == false)
                {
                    File.Create(folderPath + "\\" + nomeFile);
                }
                ReadFromCatalog(); // Inizializzazione della collezione di libri della biblioteca
            }
            internal List<Book> Books { get; private set; }

            // Aggiungere un libro alla collezione Books
            internal void AddBook(string title, string author, int year)
            {
                // Istanziare un oggetto di tipo Book
                Book book = new Book(title, author, year);
                // Aggiungo l'oggetto alla collezione
                Books.Add(book);
                string[] contents = new string[1];
                contents[0] = title + ";" + author + ";" + year;
                File.AppendAllLines(folderPath + "\\" + nomeFile, contents);
            }

            // Rimuove tutti i libri con Title = title assegnato
            internal int RemoveBooks(string title)
            {
                var elements = Books.FindAll(b => b.Title == title);
                foreach (Book book in elements)
                {
                    Books.Remove(book);
                }
                return elements.Count;
            }

            // Restituisce l'elenco di tutti i libri contenenti una parola nel titolo
            internal List<Book> FindByTitle(string keyword)
            {
                var elements = Books.FindAll(b => b.Title.Contains(keyword, StringComparison.InvariantCultureIgnoreCase));
                return elements;
            }
            internal List<Book> FindByYear(int year)
            {
                var elements = Books.FindAll(b => b.Year == year);
                return elements;
            }
            internal List<Book> FindByAuthor(string author)
            {
                var elements = Books.FindAll(b => b.Author.Contains(author, StringComparison.InvariantCultureIgnoreCase));
                return elements;
            }

            void ReadFromCatalog()
            {
                Books = new List<Book>();
                string[] books = File.ReadAllLines(folderPath + "\\" + nomeFile);
                foreach (string book in books)
                {
                    string[] line = book.Split(';');
                    Book book1 = new Book(line[0], line[1], int.Parse(line[2]));
                    Books.Add(book1);
                }
            }
        }
    }
