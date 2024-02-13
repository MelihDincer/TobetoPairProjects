using Kodlama.io_Project.Entities.Concrete;
using Workshop_2.DataAccess.Abstracts;

namespace Workshop_2.DataAccess.Concretes.InMemory
{
    public class ImCourseDal : ICourseDal
    {
        List<Course> courses = new List<Course>();
        public ImCourseDal()
        {
            //Diğer kurs bilgileri eklenecek.

            courses.Add(new Course { Id = 1, CategoryId = 2, InstructorId = 1, CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/We86Zc3xQy6FUqhyBJJc", Price = "Ücretsiz" });
            courses.Add(new Course { Id = 2, CategoryId = 2, InstructorId = 2, CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)", Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/3nqAGqHARL6uEULbaQvr", Price = "Ücretsiz" });
            courses.Add(new Course { Id = 3, CategoryId = 2, InstructorId = 1, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", Description = "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/Cs7lHNsJSCi1mkPzo8fT", Price = "Ücretsiz" });
        }
        public void Add(Course course)
        {
            courses.Add(course); //Yeni kurs bilgileri eklendi.
        }

        public void Delete(Course course)
        {
            var value = courses.FirstOrDefault(c => c.Id == course.Id);  //Silinecek veriyi gönderilen modelin id değerinden yakaladık.
            courses.Remove(value); //Listeden ilgili id değerine sahip veriyi sildik.
        }

        public List<Course> GetAll()
        {
            return courses; //Kursları listele.
        }

        public Course GetById(int id)
        {
            var value = courses.FirstOrDefault(c => c.Id == id); //Id değerine göre istenilen veriyi yakaladık.
            return value; //Yakalanan veriyi döndürdük.
        }

        public void Update(Course course)
        {
            var value = courses.FirstOrDefault(c => c.Id == course.Id); //Güncellenecek veriyi yakaladık.
            value.CourseName = course.CourseName;
            value.CategoryId = course.CategoryId;
            value.InstructorId = course.InstructorId;
            value.Description = course.Description;
            value.ImageUrl = course.ImageUrl;
            value.Price = course.Price;
        }
    }
}