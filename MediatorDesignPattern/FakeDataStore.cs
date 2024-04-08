using CqrsWithMediatorDesignPattern.Commands;

namespace CqrsWithMediatorDesignPattern
{
    public class FakeDataSource
    {
        private static List<Product> _products;

        public FakeDataSource()
        {
            _products = new List<Product>()
            {
                new Product { Id = 1, Name = "Test Product 1"},
                new Product { Id = 2, Name = "Test Product 2"},
                new Product { Id = 3, Name = "Test Product 3"}
            };
        }

        public async Task AddProduct(AddProductCommand command)
        {
            var product = new Product();
            product.Id = command.Id;
            product.Name = command.Name;
            _products.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await Task.FromResult(_products);
        }
    }
}
