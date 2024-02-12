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

foreach (var instructor in imInstructorDal.GetAll())
{
    Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
}
imInstructorDal.Delete(new Instructor
{
    Id = 3
});

foreach (var instructor in imInstructorDal.GetAll())
{
    Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
}

