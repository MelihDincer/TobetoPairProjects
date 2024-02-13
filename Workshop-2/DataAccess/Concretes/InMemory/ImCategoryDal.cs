using Kodlama.io_Project.Entities.Concrete;
using Workshop_2.DataAccess.Abstracts;

namespace Workshop_2.DataAccess.Concretes.InMemory
{
    public class ImCategoryDal : ICategoryDal
    {
        List<Category> categories = new List<Category>();
        public ImCategoryDal()
        {
            categories.Add(new Category { Id = 1, Name = "Tümü" });
            categories.Add(new Category { Id = 2, Name = "Programlama" });
        }
        public void Add(Category category)
        {
            categories.Add(category); //Yeni kategori eklendi.
        }

        public void Delete(Category category)
        {
            var value = categories.FirstOrDefault(c => c.Id == category.Id);  //Silinecek veriyi gönderilen modelin id değerinden yakaladık.
            categories.Remove(value); //Listeden ilgili id değerine sahip veriyi sildik.
        }

        public List<Category> GetAll()
        {
            return categories; //Kategorileri listele.
        }

        public Category GetById(int id)
        {
            var value = categories.FirstOrDefault(c => c.Id == id); //Id değerine göre istenilen veriyi yakaladık.
            return value; //Yakalanan veriyi döndürdük.
        }

        public void Update(Category category)
        {
            var value = categories.FirstOrDefault(c => c.Id == category.Id); //Güncellenecek veriyi yakaladık.
            value.Name = category.Name;
        }
    }
}