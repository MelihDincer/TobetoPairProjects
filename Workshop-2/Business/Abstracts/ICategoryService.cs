using Workshop_2.Business.Dtos.Requests.CategoryRequests;
using Workshop_2.Business.Dtos.Responses.CategoryResponses;

namespace Workshop_2.Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(CreateCategoryRequest category);
        void Delete(DeleteCategoryRequest category);
        void Update(UpdateCategoryRequest category);
        List<GetAllCategoryResponse> GetAll();
        GetByIdCategoryResponse GetById(int id);
    }
}