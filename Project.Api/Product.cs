using Project.Generators;

namespace Project.Api
{
    [GenerateService]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
