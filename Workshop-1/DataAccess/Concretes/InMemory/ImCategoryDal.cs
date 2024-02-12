
using TobetoPairProjects.Entities;

namespace Workshop_1.DataAccess.Concretes.InMemory
{
    public class ImCategoryDal
    {
        List<Category> categories = new List<Category>();
        public ImCategoryDal()
        {
            categories.Add(new Category(1,"Meyve"));
            categories.Add(new Category(2,"Sebze"));
            categories.Add(new Category(3,"Atıştırmalık"));
            categories.Add(new Category(4,"Bakliyat"));
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
