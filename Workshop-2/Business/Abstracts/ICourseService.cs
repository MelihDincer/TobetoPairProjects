using Workshop_2.Business.Dtos.Requests.CourseRequests;
using Workshop_2.Business.Dtos.Responses.CourseResponses;

namespace Workshop_2.Business.Abstracts
{
    public interface ICourseService
    {
        void Add(CreateCourseRequest course);
        void Delete(DeleteCourseRequest course);
        void Update(UpdateCourseRequest course);
        List<GetAllCourseResponse> GetAll();
        GetByIdCourseResponse GetById(int id);
    }
}