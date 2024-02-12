using TobetoPairProjects.Entities;
using Workshop_1.Business.Dtos.Requests;
using Workshop_1.Business.Dtos.Responses;

namespace Workshop_1.Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(CreateCategoryRequest createCategoryRequest);
        List<GetAllCategoryResponse> GetCategories();
    }
}
