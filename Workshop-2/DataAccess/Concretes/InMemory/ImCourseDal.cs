using Kodlama.io_Project.Entities.Concrete;
using Workshop_2.DataAccess.Abstracts;

namespace Workshop_2.DataAccess.Concretes.InMemory
{
    public class ImCourseDal : ICourseDal
    {
        List<Course> courses = new List<Course>();
        public ImCourseDal()
        {
            courses.Add(new Course { Id = 1, CategoryId = 2, InstructorId = 1, CourseName = "2024 - Yazılım Geliştirici Yetiştirme Kampı C#", Title = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız." });
            courses.Add(new Course { Id = 2, CategoryId = 2, InstructorId = 2, CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)", Title = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)", Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız." });
            courses.Add(new Course { Id = 3, CategoryId = 2, InstructorId = 1, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", Title = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", Description = "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz." });
        }
        public void Add(Course course)
        {
            courses.Add(course); //Yeni kurs bilgileri eklendi.
        }

        public void Delete(Course course)
        {
            var value = courses.Where(c => c.Id == course.Id).FirstOrDefault();  //Silinecek veriyi gönderilen modelin id değerinden yakaladık.
            courses.Remove(value); //Listeden ilgili id değerine sahip veriyi sildik.
        }

        public List<Course> GetAll()
        {
            return courses; //Kursları listele.
        }

        public Course GetById(int id)
        {
            var value = courses.Where(c => c.Id == id).FirstOrDefault(); //Id değerine göre istenilen veriyi yakaladık.
            return value; //Yakalanan veriyi döndürdük.
        }

        public void Update(Course course)
        {
            var value = courses.Where(c => c.Id == course.Id).FirstOrDefault(); //Güncellenecek veriyi yakaladık.
            value.CourseName = course.CourseName;
            value.Title = course.Title;
            value.CategoryId = course.CategoryId;
            value.InstructorId = course.InstructorId;
            value.Description = course.Description;
        }
    }
}