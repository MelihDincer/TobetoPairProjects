using Kodlama.io_Project.Entities.Concrete;

namespace Workshop_2.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(Instructor instructor);
        void Update(Instructor instructor);
        List<Instructor> GetAll();
        Instructor GetById(int id);
    }
}
