using static System.Console;

namespace Quantum_Bookstore
{
    public class EBook : Book, IBuyable
    {
        public EBook(string iSBN, string title, string author, int publishedYear, string fileType, decimal price)
            : base(iSBN, title, author, publishedYear)
        {
            FileType = fileType;
            Price = price;
        }

        public string FileType { get; set; }
        public decimal Price { get; set; }

        public void Buy(int quantity, string email, string address)
        {
            WriteLine($"Quantum book store: Sendindg via email {quantity} of {Title} book as {FileType} to {email}");
            // MailService
        }
    }
}
