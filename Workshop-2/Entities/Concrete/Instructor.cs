using Kodlama.io_Project.Entities.Abstract;

namespace Kodlama.io_Project.Entities.Concrete
{
    public class Instructor : IEntity
    {
        public Instructor()
        {            
        }
        public Instructor(int id, string firstName, string lastName, string description, string imageUrl)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Description = description;
            ImageUrl = imageUrl;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<Course> Courses { get; set; }
    }
}