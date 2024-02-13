using Kodlama.io_Project.Entities.Concrete;
using Workshop_2.Business.Abstracts;
using Workshop_2.Business.Dtos.Requests.CategoryRequests;
using Workshop_2.Business.Dtos.Responses.CategoryResponses;
using Workshop_2.DataAccess.Abstracts;

namespace Workshop_2.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(CreateCategoryRequest category)
        {
            Category CategoryToCreate = new();
            CategoryToCreate.Name = category.Name;
            _categoryDal.Add(CategoryToCreate);
        }

        public void Delete(DeleteCategoryRequest category)
        {
            Category CategoryToDelete = new();
            CategoryToDelete.Id = category.Id;
            _categoryDal.Delete(CategoryToDelete);
        }

        public List<GetAllCategoryResponse> GetAll()
        {
            List<GetAllCategoryResponse> categories = new List<GetAllCategoryResponse>();
            foreach (var category in _categoryDal.GetAll())
            {
                GetAllCategoryResponse getAllCategoryResponse = new();
                getAllCategoryResponse.Id = category.Id;
                getAllCategoryResponse.Name = category.Name;
                categories.Add(getAllCategoryResponse);
            }
            return categories;
        }

        public GetByIdCategoryResponse GetById(int id)
        {
            GetByIdCategoryResponse category = new();
            Category categoryEntity = _categoryDal.GetById(id);
            category.Id = categoryEntity.Id;
            category.Name = categoryEntity.Name;
            return category;
        }

        public void Update(UpdateCategoryRequest category)
        {
            Category categoryToUpdate = new();
            categoryToUpdate.Id = category.Id;
            categoryToUpdate.Name = category.Name;
            _categoryDal.Update(categoryToUpdate);
        }
    }
}