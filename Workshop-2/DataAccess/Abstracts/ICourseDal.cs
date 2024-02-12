using Kodlama.io_Project.Entities.Concrete;

namespace Workshop_2.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
        List<Course> GetAll();
        Course GetById(int id);
    }
}