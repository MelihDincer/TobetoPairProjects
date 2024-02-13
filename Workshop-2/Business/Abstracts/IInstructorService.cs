using Workshop_2.Business.Dtos.Requests.InstructorRequests;
using Workshop_2.Business.Dtos.Responses.InstructorResponses;

namespace Workshop_2.Business.Abstracts
{
    public interface IInstructorService
    {
        void Add(CreateInstructorRequest instructor);
        void Delete(DeleteInstructorRequest instructor);
        void Update(UpdateInstructorRequest instructor);
        List<GetAllInstructorResponse> GetAll();
        GetByIdInstructorResponse GetById(int id);
    }
}