using System.Net.Http.Headers;

namespace FilesExercise.Entities
{
    public class Itens
    {
        public string Product { get; init; }
        public double Price { get; init; }
        public int Quantity { get; init; }
        public double TotalValue => (Price* Quantity);

        public Itens()
        {
        }

        public Itens(string product, double price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }
    }
}
