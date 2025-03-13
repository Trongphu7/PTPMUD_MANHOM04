namespace MvcNew.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }  // Thêm dấu ? để cho phép null
        public decimal Price { get; set; }
    }
}
