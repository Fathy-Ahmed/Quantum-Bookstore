namespace Quantum_Bookstore
{
    public abstract class Book
    {
        public Book(string iSBN, string title, string author, int publishedYear)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            PublishedYear = publishedYear;
        }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
    }
}
