using TobetoPairProjects.Entities;

namespace Workshop_1.DataAccess.Abstracts
{
    public interface IProductDal
    {
        void Add(Product product);
        List<Product> GetProducts();
    }
}