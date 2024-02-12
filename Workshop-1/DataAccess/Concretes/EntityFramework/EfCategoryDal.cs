using TobetoPairProjects.Entities;
using Workshop_1.DataAccess.Abstracts;
using Workshop_1.DataAccess.Concretes.InMemory;

namespace Workshop_1.DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        //List<Category> categories = new List<Category>();
        List<Category> categories;
        public EfCategoryDal()
        {
            categories = new List<Category>
            {
                new Category(1, "Meyve"),
                new Category(2, "Sebze"),
                new Category(3, "Atıştırmalık"),
            };
            //categories.Add(new Category(1, "Meyve"));
            //categories.Add(new Category(2, "Sebze"));
            //categories.Add(new Category(3, "Atıştırmalık"));
            //categories.Add(new Category(4, "Bakliyat"));
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
