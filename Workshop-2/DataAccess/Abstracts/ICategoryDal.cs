using Kodlama.io_Project.Entities.Concrete;

namespace Workshop_2.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
        List<Category> GetAll();
        Category GetById(int id);
    }
}
