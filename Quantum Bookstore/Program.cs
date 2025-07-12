using static System.Console;

namespace Quantum_Bookstore
{
    static class QuantumBookstoreTests
    {
        static PaperBook paperBook = new("978-0123456789", "Java", "Fathy", 2025, 150, 10);
        static EBook eBook = new("978-0987654321", "Design Patterns", "Ahmed", 2025, "Pdf", 100);
        static ShowcaseBook showcaseBook = new("978-0555555555", "Clean Code", "Sarah", 2025);
        public static void TestAddBooks()
        {
            try
            {
                QuantumBookstore.AddBook(paperBook);
                QuantumBookstore.AddBook(eBook);
                QuantumBookstore.AddBook(showcaseBook);
            }
            catch (Exception e) { WriteLine(e.Message); }
            
        }
        public static void TestBuyBooks()
        {
            try
            {
                var totalPaid = QuantumBookstore.BuyBook("978-0123456789", 2, "customer@email.com", "123 Main St");
                WriteLine($"Total paid: {totalPaid:C}");

                totalPaid = QuantumBookstore.BuyBook("978-0987654321", 1, "customer@email.com", "123 Main St");
                WriteLine($"Total paid: {totalPaid:C}");
            }
            catch (Exception e) { WriteLine(e.Message); }
            
        }
        public static void TestBuyShowcaseBook()
        {
            try
            {
                QuantumBookstore.BuyBook("978-0555555555", 1, "customer@email.com", "123 Main St");
            }
            catch (Exception e) { WriteLine(e.Message); }
            
        }
        public static void TestBuyMoreThanAvailableStock()
        {
            try
            {
                QuantumBookstore.BuyBook("978-0123456789", 20, "customer@email.com", "123 Main St");
            }
            catch (Exception e) { WriteLine(e.Message); }
            
        }
        public static void TestRemoveOutdatedBooks()
        {
            try
            {
                var outdatedBooks = QuantumBookstore.RemoveOutdatedBooks(15); // Books older than 15 years
                WriteLine($"Removed {outdatedBooks.Count} outdated books");
            }
            catch (Exception e) { WriteLine(e.Message); }
            
        }
        public static void TestBuyRemovedBook()
        {
            try
            {
                QuantumBookstore.BuyBook("978-0987654321", 1, "customer@email.com", "123 Main St");
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("*** TestAddBooks ***");
                QuantumBookstoreTests.TestAddBooks();
                WriteLine();
                WriteLine("*** TestBuyBooks ***");
                QuantumBookstoreTests.TestBuyBooks();
                WriteLine();
                WriteLine("*** TestBuyShowcaseBook ***");
                QuantumBookstoreTests.TestBuyShowcaseBook();
                WriteLine();
                WriteLine("*** TestBuyMoreThanAvailableStock ***");
                QuantumBookstoreTests.TestBuyMoreThanAvailableStock();
                WriteLine();
                WriteLine("*** TestRemoveOutdatedBooks ***");
                QuantumBookstoreTests.TestRemoveOutdatedBooks();
                WriteLine();
                WriteLine("*** TestBuyRemovedBook ***");
                QuantumBookstoreTests.TestBuyRemovedBook();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            finally
            {
                WriteLine("\n*** Thank you to use my store ***");
            }
        }
    }
}
