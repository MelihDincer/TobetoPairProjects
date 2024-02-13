using Kodlama.io_Project.Entities.Concrete;
using Workshop_2.Business.Abstracts;
using Workshop_2.Business.Dtos.Requests.CourseRequests;
using Workshop_2.Business.Dtos.Responses.CourseResponses;
using Workshop_2.DataAccess.Abstracts;

namespace Workshop_2.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(CreateCourseRequest course)
        {
            Course courseToCreate = new();
            courseToCreate.CategoryId = course.CategoryId;
            courseToCreate.InstructorId = course.InstructorId;
            courseToCreate.CourseName = course.CourseName;
            courseToCreate.Description = course.Description;
            courseToCreate.ImageUrl = course.ImageUrl;
            courseToCreate.Price = course.Price;
            _courseDal.Add(courseToCreate);
        }

        public void Delete(DeleteCourseRequest course)
        {
            Course courseToDelete = new();
            courseToDelete.Id = course.Id;
            _courseDal.Delete(courseToDelete);
        }

        public List<GetAllCourseResponse> GetAll()
        {
            List<GetAllCourseResponse> courses = new List<GetAllCourseResponse>();
            foreach (var course in _courseDal.GetAll())
            {
                GetAllCourseResponse getAllCourseResponse = new();
                getAllCourseResponse.Id = course.Id;
                getAllCourseResponse.CategoryId = course.CategoryId;
                getAllCourseResponse.InstructorId = course.InstructorId;
                getAllCourseResponse.CourseName = course.CourseName;
                getAllCourseResponse.Description = course.Description;
                getAllCourseResponse.ImageUrl = course.ImageUrl;
                getAllCourseResponse.Price = course.Price;
                courses.Add(getAllCourseResponse);
            }
            return courses;
        }

        public GetByIdCourseResponse GetById(int id)
        {
            GetByIdCourseResponse course = new();
            Course courseEntity = _courseDal.GetById(id);
            course.Id = courseEntity.Id;
            course.CategoryId = courseEntity.CategoryId;
            course.InstructorId = courseEntity.InstructorId;
            course.CourseName = courseEntity.CourseName;
            course.Description = courseEntity.Description;
            course.ImageUrl = courseEntity.ImageUrl;
            course.Price = courseEntity.Price;
            return course;
        }

        public void Update(UpdateCourseRequest course)
        {
            Course courseToUpdate = new();
            courseToUpdate.Id = course.Id;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.Description = course.Description;
            courseToUpdate.ImageUrl = course.ImageUrl;
            courseToUpdate.Price = course.Price;
            _courseDal.Update(courseToUpdate);
        }
    }
}