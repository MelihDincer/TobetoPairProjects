using TobetoPairProjects.Entities;
using Workshop_1.DataAccess.Abstracts;

namespace TobetoPairProjects.DataAccess.Concretes.InMemory;
public class ImProductDal : IProductDal
{
    List<Product> products = new List<Product>();
    public ImProductDal()
    {
        products.Add(new Product { Id = 1, CategoryId = 1, Name = "Elma", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
        products.Add(new Product { Id = 2, CategoryId = 4, Name = "Armut", UnitPrice = 20, Description = "Kırmızı elma", DiscountRate = 10 });
        products.Add(new Product { Id = 3, CategoryId = 2, Name = "Üzüm", UnitPrice = 30, Description = "Kırmızı elma", DiscountRate = 10 });
        products.Add(new Product { Id = 4, CategoryId = 3, Name = "İncir", UnitPrice = 40, Description = "Kırmızı elma", DiscountRate = 10 });
        products.Add(new Product { Id = 5, CategoryId = 1, Name = "Kayısı", UnitPrice = 50, Description = "Kırmızı elma", DiscountRate = 10 });
    }
    public void Add(Product product)
    {
        products.Add (product);
    }

    public List<Product> GetProducts()
    {
        return products;    
    }
}
