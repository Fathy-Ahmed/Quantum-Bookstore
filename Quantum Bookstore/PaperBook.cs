using static System.Console;

namespace Quantum_Bookstore
{
    class PaperBook : Book, IBuyable
    {
        public PaperBook(string iSBN, string title, string author, int publishedYear, decimal price, int stock)
            : base(iSBN, title, author, publishedYear)
        {
            Price = price;
            Stock = stock;
        }

        public decimal Price { get; set; }
        public int Stock { get; set; }

        public bool IsInStock(int quantity) => Stock >= quantity;
        public void ReducesQuantity(int quantity) { Stock -= quantity; }
        public void Buy(int quantity, string email, string address)
        {
            WriteLine($"Quantum book store: Sendindg {quantity} of {Title} book to shipping service");
            // ShippingService
        }

    }
}
