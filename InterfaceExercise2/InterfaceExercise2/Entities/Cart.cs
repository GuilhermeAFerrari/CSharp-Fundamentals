namespace InterfaceExercise2.Entities
{
    public class Cart
    {
        public string Owner { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public double TotalValue { get; set; }

        public Cart(string owner)
        {
            Owner = owner;
        }
    }
}
