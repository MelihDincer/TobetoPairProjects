using Kodlama.io_Project.Entities.Concrete;
using Workshop_2.Business.Concretes;
using Workshop_2.Business.Dtos.Requests.CategoryRequests;
using Workshop_2.Business.Dtos.Requests.InstructorRequests;
using Workshop_2.DataAccess.Concretes.InMemory;

/*
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
//InstructorList(imInstructorDal);

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
static void InstructorList(ImInstructorDal imInstructorDal)
{
   foreach (var instructor in imInstructorDal.GetAll())
   {
       Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
   }
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

//GetInstructorList(instructorManager);

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
//GetInstructorList(instructorManager);

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
*/

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


static void GetCategoryList(CategoryManager categoryManager)
{
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.Name);
        Console.WriteLine("------------------------------------------------------------------------");
    }
}
