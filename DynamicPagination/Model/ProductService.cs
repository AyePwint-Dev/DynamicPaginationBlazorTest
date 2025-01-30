namespace DynamicPagination.Model
{
    //sample dummy data
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            // Sample data
            return Enumerable.Range(1, 100).Select(i => new Product
            {
                Id = i,
                Name = $"Product {i}",
                Price = i * 10
            }).ToList();
        }
    }
}
