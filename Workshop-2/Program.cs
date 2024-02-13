using Kodlama.io_Project.Entities.Concrete;
using Workshop_2.Business.Concretes;
using Workshop_2.Business.Dtos.Requests.CategoryRequests;
using Workshop_2.Business.Dtos.Requests.InstructorRequests;
using Workshop_2.Business.Dtos.Requests.CourseRequests;
using Workshop_2.DataAccess.Concretes.InMemory;

// -- Dal Testleri
ImInstructorDal imInstructorDal = new ImInstructorDal();

foreach(var instructor in imInstructorDal.GetAll())
{
   Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
}

imInstructorDal.Add(new Instructor
{
   Id = 3,
   FirstName = "Melih",
   LastName = "Dinçer"
});

InstructorList(imInstructorDal);
Console.WriteLine("-------------------------------------------------------");

imInstructorDal.Delete(new Instructor
{
   Id = 3
});

InstructorList(imInstructorDal);
Console.WriteLine("-------------------------------------------------------");

imInstructorDal.Update(new Instructor
{
   Id = 1,
   FirstName = "Derin",
   LastName = "Demiroğ"  
});


foreach (var instructor in imInstructorDal.GetAll())
{
   Console.WriteLine(instructor.FirstName + "\n" + instructor.LastName + "\n" + instructor.Description + "\n" + instructor.ImageUrl);
   Console.WriteLine("------------------------------------------------------------------------");
   Console.WriteLine("------------------------------------------------------------------------");
}
InstructorList(imInstructorDal);

Instructor instructor2 = imInstructorDal.GetById(2);
Console.WriteLine(instructor2.FirstName + " " + instructor2.LastName);

// *****************************************

ImCourseDal imCourseDal = new ImCourseDal();
imCourseDal.Add(new Course
{
   CategoryId = 1,
   InstructorId = 2,
   CourseName = "Deneme1",
   Description = "Yeni kurs"
});

imCourseDal.Add(new Course
{
   CategoryId = 1,
   InstructorId = 2,
   CourseName = "Deneme2",
   Description = "Yeni kurs"
});

imCourseDal.Add(new Course
{
   CategoryId = 1,
   InstructorId = 2,
   CourseName = "Deneme3",
   Description = "Yeni kurs"
});

imCourseDal.Add(new Course
{
   CategoryId = 10,
   InstructorId = 20,
   CourseName = "Deneme3",
   Description = "Yeni kurs"
});

imCourseDal.Add(new Course
{
   CategoryId = 15,
   InstructorId = 25,
   CourseName = "Deneme3",
   Description = "Yeni kurs"
});

foreach (var course in imCourseDal.GetAll())
{
   Console.WriteLine($"{course.CategoryId}  {course.InstructorId}   {course.CourseName}       {course.Description}");
}

//--Manager Testleri

InstructorManager instructorManager = new(new ImInstructorDal());
instructorManager.Add(new CreateInstructorRequest
{
   FirstName = "Melih",
   LastName = "Dinçer",
   Description = "Yeni mezun yazılım geliştirici",
   ImageUrl = "test"
});

GetInstructorList(instructorManager);

instructorManager.Delete(new DeleteInstructorRequest
{
   Id = 2
});

instructorManager.Update(new UpdateInstructorRequest
{
   Id = 1,
   FirstName = "Derin",
   LastName = "Demiroğ",
   Description = "Engin Demiroğ'un güzeller güzeli kızı..",
   ImageUrl = "test"
});

InstructorManager instructorManager2 = new(new ImInstructorDal());

var value = instructorManager2.GetById(1);
Console.WriteLine(value.FirstName + " " + value.LastName + " " + value.Description + " " + value.ImageUrl);
GetInstructorList(instructorManager);

CategoryManager categoryManager = new(new ImCategoryDal());
categoryManager.Add(new CreateCategoryRequest
{
    Name = "Yakında Gelecek Kurslar"
});

GetCategoryList(categoryManager);

categoryManager.Delete(new DeleteCategoryRequest
{
    Id = 1
});

GetCategoryList(categoryManager);

categoryManager.Update(new UpdateCategoryRequest
{
    Id = 2,
    Name = "Yazılım"
});
GetCategoryList(categoryManager);

Console.WriteLine(categoryManager.GetById(2).Name);
static void GetCategoryList(CategoryManager categoryManager)
{
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.Name);
        Console.WriteLine("------------------------------------------------------------------------");
    }
}

CourseManager courseManager = new(new ImCourseDal());
courseManager.Add(new CreateCourseRequest
{
    CategoryId = 1,
    InstructorId = 1,
    CourseName = "Swift Yazılımcı Yetiştirme Kampı",
    Description = "Yeni açılan bu kursumuza katılımınızı bekliyoruz.",
    ImageUrl = "test",
    Price = "Ücretsiz"
});

GetCourseList(courseManager);

courseManager.Delete(new DeleteCourseRequest
{
    Id = 1
});

GetCourseList(courseManager);

courseManager.Update(new UpdateCourseRequest
{
    Id = 2,
    CategoryId = 1,
    CourseName = "Güncellenen Kurs Adı",
    Description = "Güncelleme başarılı...",
    ImageUrl = "test",
    InstructorId = 1,
    Price = "150 TL"
});

GetCourseList(courseManager);

//Methods
static void GetInstructorList(InstructorManager instructorManager)
{
    InstructorManager instructorManager2 = new(new ImInstructorDal());
    foreach (var instructor in instructorManager.GetAll())
    {
        Console.WriteLine(instructor.FirstName + "\n" + instructor.LastName + "\n" + instructor.Description + "\n" + instructor.ImageUrl);
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("------------------------------------------------------------------------");
    }
}
static void InstructorList(ImInstructorDal imInstructorDal)
{
    foreach (var instructor in imInstructorDal.GetAll())
    {
        Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
    }
}
static void GetCourseList(CourseManager courseManager)
{
    foreach (var course in courseManager.GetAll())
    {
        Console.WriteLine($"Kategori id={course.CategoryId} ve Instructor id= {course.InstructorId} olan kursun adı: {course.CourseName} \n Açıklama: {course.Description} \n Image Url: {course.ImageUrl} \n Price: {course.Price}");
        Console.WriteLine("------------------------------------------------------------------------");
    }
}