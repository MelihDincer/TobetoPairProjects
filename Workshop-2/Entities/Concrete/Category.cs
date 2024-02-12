using Kodlama.io_Project.Entities.Abstract;

namespace Kodlama.io_Project.Entities.Concrete
{
    //Çıplak class kalmasın.
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}