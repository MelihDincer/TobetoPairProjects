namespace TobetoPairProjects.Entities;

public class Category
{
    public Category()
    {

    }
    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public List<Product> Products { get; set; }
}
