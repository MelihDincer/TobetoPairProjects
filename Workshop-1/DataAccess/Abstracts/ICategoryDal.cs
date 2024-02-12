using TobetoPairProjects.Entities;

namespace Workshop_1.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        List<Category> GetCategories();
    }
}
