using TobetoPairProjects.Entities;
using Workshop_1.DataAccess.Abstracts;

namespace Workshop_1.DataAccess.Concretes.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        List<Product> products = new List<Product>();
        public EfProductDal()
        {
            products.Add(new Product { Id = 1, CategoryId = 1, Name = "Elma EF", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 2, CategoryId = 4, Name = "Armut EF", UnitPrice = 20, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 3, CategoryId = 2, Name = "Üzüm EF", UnitPrice = 30, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 4, CategoryId = 3, Name = "İncir EF", UnitPrice = 40, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 5, CategoryId = 1, Name = "Kayısı EF", UnitPrice = 50, Description = "Kırmızı elma", DiscountRate = 10 });
        }
        public void Add(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
