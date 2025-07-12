using static System.Console;

namespace Quantum_Bookstore
{
    public static class QuantumBookstore
    {
        static QuantumBookstore()
        {
            inventory = new();
        }

        private static Dictionary<string, Book> inventory;

        public static void AddBook(Book book)
        {
            // if book exsit increase the stock only
            if(inventory.ContainsKey(book.ISBN) && inventory[book.ISBN] is PaperBook existPaperBook && book is PaperBook newPaperBook)
            {
                existPaperBook.Stock += newPaperBook.Stock;
                WriteLine($"Quantum book store: {book.Title} is added new coies");
            }
            else
            {
                inventory[book.ISBN] = book;
                WriteLine($"Quantum book store:  {book.Title} is added");
            }
        }

        public static List<Book> RemoveOutdatedBooks(int years)
        {
            int curYear = DateTime.Now.Year;
            List<string> outdatedBooksKey = new();
            var outdatedBooks = new List<Book>();
            foreach (var item in inventory)
            {
                if (curYear - item.Value.PublishedYear > years)
                {
                    outdatedBooksKey.Add(item.Key);
                    outdatedBooks.Add(item.Value);
                }
            }

            foreach (var key in outdatedBooksKey) inventory.Remove(key);
            WriteLine($"Quantum book store: {outdatedBooksKey.Count} book is removed because them out dated");
            return outdatedBooks;
        }

        public static decimal BuyBook(string iSBN, int quantity, string email, string address)
        {
            if (!inventory.ContainsKey(iSBN)) throw new ArgumentException("This Book Not Founded");

            var book = inventory[iSBN];

            if (book is not IBuyable buyableBook) throw new ArgumentException("This Book Not for sale");

            if(book is PaperBook paperBook)
            {
                if(!paperBook.IsInStock(quantity))
                    throw new ArgumentException("there is not enugh stock");

                paperBook.ReducesQuantity(quantity);
            }

            buyableBook.Buy(quantity, email, address);
            decimal totalPrice = quantity * buyableBook.Price;

            WriteLine($"Quantum book store: Successful the total paid amount is {totalPrice:C}");

            return totalPrice;
        }

    }
}
