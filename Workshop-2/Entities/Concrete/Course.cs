using Kodlama.io_Project.Entities.Abstract;

namespace Kodlama.io_Project.Entities.Concrete
{
    //Çıplak class kalmasın.
    public class Course : IEntity
    {
        public Course()
        {
        }
        public Course(int id, int categoryId, int instructorId, string courseName, string description, string imageUrl, string price)
        {
            Id = id;
            CategoryId = categoryId;
            InstructorId = instructorId;
        }
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }
        Instructor Instructor { get; set; }
        Category Category { get; set; }
    }
}