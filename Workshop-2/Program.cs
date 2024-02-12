using Kodlama.io_Project.Entities.Concrete;
using Workshop_2.DataAccess.Concretes.InMemory;

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
    FirstName = "Abuzer",
    LastName = "Yanbattı"
});

foreach (var instructor in imInstructorDal.GetAll())
{
    Console.WriteLine(instructor.FirstName + " " + instructor.LastName + " " + instructor.Description);
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
    Title = "Test1",
    Description = "Yeni kurs"
});

imCourseDal.Add(new Course
{
    CategoryId = 1,
    InstructorId = 2,
    CourseName = "Deneme2",
    Title = "Test2",
    Description = "Yeni kurs"
});

imCourseDal.Add(new Course
{
    CategoryId = 1,
    InstructorId = 2,
    CourseName = "Deneme3",
    Title = "Test3",
    Description = "Yeni kurs"
});

imCourseDal.Add(new Course
{
    CategoryId = 10,
    InstructorId = 20,
    CourseName = "Deneme3",
    Title = "Test3",
    Description = "Yeni kurs"
});

imCourseDal.Add(new Course
{
    CategoryId = 15,
    InstructorId = 25,
    CourseName = "Deneme3",
    Title = "Test3",
    Description = "Yeni kurs"
});

foreach (var course in imCourseDal.GetAll())
{
    Console.WriteLine($"{course.CategoryId}  {course.InstructorId}   {course.CourseName}    {course.Title}     {course.Description}");
}
static void InstructorList(ImInstructorDal imInstructorDal)
{
    foreach (var instructor in imInstructorDal.GetAll())
    {
        Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
    }
}