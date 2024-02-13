using Kodlama.io_Project.Entities.Concrete;
using Workshop_2.DataAccess.Abstracts;

namespace Workshop_2.DataAccess.Concretes.InMemory
{
    public class ImInstructorDal : IInstructorDal
    {
        string instructorDescription1 = "Yazılım geliştirmeye lisede yazılım bölümünde okurken başladım.Üniversite hayatıma ÖSS 2003 Türkiye derecesiyle başladım. Sırasıyla Başkent ve ODTÜ'de Yönetim Bilişim Sistemleri (Lisans-Burslu) ve Tıp Bilişimi(Yüksek Lisans) okudum. Profesyonel iş hayatıma ise henüz üniversite birinci sınıftayken başladım.Ağırlıklı olarak Savunma Sanayisi, Bankacılık sektörlerine kurumsal yazılım geliştirme süreçleri konusunda danışmanlık veriyorum.Microsoft Certified Trainer (MCT) ,PMP ve ITIL sertifikalarına sahibim. Engin Demiroğ YouTube kanalımda ücretsiz eğitim videoları ve içerikleri paylaşmaktayım.Danışmanlık yaptığım kurumların bazıları : Merkez Bankası,TAI, Birleşmiş Milletler,NATO,İş Bankası, Akbank, Halkbank, Vakıfbank, Yapı Kredi Bankası, Ziraat Bankası, Emniyet, Başbakanlık, Cumhurbaşkanlığı, Hazine Müsteşarlığı, Maliye Bakanlığı, Tarım Bakanlığı, Tübitak.Danışmanlık veya eğitim verdiğim kurum sayısı son 10 yılda 300'ü geçmiştir.DevFramework ismiyle geliştirdiğim altyapı projem birçok kurum ve firmada yazılım geliştirme altyapısı olarak kullanılmaktadır.";

        string instructorDescription2 = "Yazılım geliştirme sürecine lise sonuncu sınıfta başladım.rnrnSakarya Üniversitesi Yönetim Bilişim Sistemleri programından mezun oldum. rnrnProfesyonel iş hayatım üniversite 3. sınıfta başladı.rnrnKariyerime kodlama.io'da Yazılım Eğitmeni ve Danışmanı olarak devam ediyorum.rnrnEğitim ve danışmanlık verdiğim kurumların bazıları; Esbaş, Etiya, KDK, Turkcell, Bosch. rnrnkodlama.io olarak geliştirdiğimiz 'nArch' projesinde aktif geliştirici olarak rol almaktayım."; 

        List<Instructor> instructors = new List<Instructor>();
        public ImInstructorDal()
        {
            instructors.Add(new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ", ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:30,height:30/https://www.filepicker.io/api/file/GsqiGFGCRmuBuel0qqF3", Description = instructorDescription1 });
            instructors.Add(new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı", ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:30,height:30/https://cdn.filestackcontent.com/XwoZsQ1LTaOU9ke59grx", Description = instructorDescription2 });
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor); //Yeni eğitmen bilgisi eklendi.
        }

        public void Delete(Instructor instructor)
        {
            var value = instructors.FirstOrDefault(c => c.Id == instructor.Id);  //Silinecek veriyi gönderilen modelin id değerinden yakaladık.
            instructors.Remove(value); //Listeden ilgili id değerine sahip veriyi sildik.
        }

        public List<Instructor> GetAll()
        {
            return instructors; //Eğitmenleri listele.
        }

        public Instructor GetById(int id)
        {
            var value = instructors.FirstOrDefault(c => c.Id == id); //Id değerine göre istenilen veriyi yakaladık.
            return value; //Yakalanan veriyi döndürdük.
        }

        public void Update(Instructor instructor)
        {
            var value = instructors.FirstOrDefault(c => c.Id == instructor.Id); //Güncellenecek veriyi yakaladık.
            value.FirstName = instructor.FirstName;
            value.LastName = instructor.LastName;
            value.ImageUrl = instructor.ImageUrl;
            value.Description = instructor.Description;
        }
    }
}