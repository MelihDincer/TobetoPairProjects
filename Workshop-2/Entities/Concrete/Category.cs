using Kodlama.io_Project.Entities.Abstract;

namespace Kodlama.io_Project.Entities.Concrete
{
    //Çıplak class kalmasın.
    public class Category : IEntity
    {
        public Category()
        {          
        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}