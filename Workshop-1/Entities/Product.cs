namespace TobetoPairProjects.Entities;
public class Product
{
    //overloading
    public Product()
    {
        
    }
    //constructor class ile aynı isimde olur
    public Product(int id, int categoryId, string name, string description, double unitPrice, double discountRate)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        Description = description;
        UnitPrice = unitPrice;
        DiscountRate = discountRate;
    }

    //property
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double UnitPrice { get; set; }
    public double DiscountRate { get; set; }
    public double DiscountedPrice => UnitPrice - (UnitPrice * DiscountRate / 100);
    public Category Category { get; set; }
}
