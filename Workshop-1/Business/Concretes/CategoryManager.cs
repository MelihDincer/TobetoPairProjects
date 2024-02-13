using TobetoPairProjects.Entities;
using Workshop_1.Business.Abstracts;
using Workshop_1.Business.Dtos.Requests;
using Workshop_1.Business.Dtos.Responses;
using Workshop_1.DataAccess.Abstracts;

namespace Workshop_1.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(CreateCategoryRequest category)
        {
            Category categoryToCreate = new Category();
            categoryToCreate.Name = category.Name;
            categoryToCreate.Description = category.Description;
            _categoryDal.Add(categoryToCreate);
        }
        public List<GetAllCategoryResponse> GetCategories() 
        {
            List<GetAllCategoryResponse> categories = new List<GetAllCategoryResponse>();
            foreach(var item in _categoryDal.GetCategories())
            {
                GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
                getAllCategoryResponse.Name = item.Name;
                getAllCategoryResponse.Description = item.Description;
                categories.Add(getAllCategoryResponse);
            }
            return categories;
        }
    }
}
