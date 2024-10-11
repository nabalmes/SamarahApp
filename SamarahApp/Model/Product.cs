namespace SamarahApp.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; } // Changed to decimal
        public int CategoryId { get; set; }
    }
}
