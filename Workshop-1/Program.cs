using TobetoPairProjects.Business.Concretes;
using TobetoPairProjects.Entities;
using Workshop_1.Business.Concretes;
using Workshop_1.Business.Dtos.Requests;
using Workshop_1.DataAccess.Concretes.EntityFramework;

Product product1 = new Product(); //reference
product1.Id = 10;
product1.CategoryId = 4;
product1.Name = "Fasülye";
product1.Description = "Aşırı güçlü bir laptop";
product1.UnitPrice = 50000;
product1.DiscountRate = 10;

product1 = new Product();

//Product product2 = new Product(2, "GSM", "Samsung birşey", 70000);

ProductManager productManager = new ProductManager(new EfProductDal());
//productManager.Add(product1);

foreach (var product in productManager.GetProducts())
{
    Console.WriteLine(product.Name + product.CategoryId);
}

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
categoryManager.Add(new CreateCategoryRequest
{
    Name = "Deneme Kategorisi",
    Description = "Bu bir açıklama satırıdır."
});

foreach (var category in categoryManager.GetCategories())
{
    Console.WriteLine(category.Name + "\n" + category.Description);
}


ProductManager productManager2 = new ProductManager(new EfProductDal());
productManager2.Add(new CreateProductRequest
{
    CategoryId = 1,
    Description = "test",
    DiscountRate = 10,
    Name = "test name",
    UnitPrice = 1000
});

productManager2.Add(new CreateProductRequest
{
    CategoryId = 2,
    Description = "test",
    DiscountRate = 10,
    Name = "test name",
    UnitPrice = 1000
});

foreach (var item in productManager2.GetProducts())
{
    Console.WriteLine(item.Id);
}