namespace Quantum_Bookstore
{
    public interface IBuyable
    {
        public decimal Price { get; set; }
        public void Buy(int quantity, string email, string address);
    }
}
