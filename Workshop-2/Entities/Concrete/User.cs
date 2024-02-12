using Kodlama.io_Project.Entities.Abstract;

namespace Kodlama.io_Project.Entities.Concrete
{
    //Çıplak class kalmasın.
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
    }
}
