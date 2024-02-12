
namespace Workshop_1.Business.Dtos.Requests
{
    public class CreateProductRequest
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountRate { get; set; }
    }
}
