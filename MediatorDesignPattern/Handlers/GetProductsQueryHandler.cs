using CqrsWithMediatorDesignPattern.Queries;
using MediatR;

namespace CqrsWithMediatorDesignPattern.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataSource _fakeDataSource;

        public GetProductsQueryHandler(FakeDataSource fakeDataSource)
        {
            _fakeDataSource = fakeDataSource;
        }
        public Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return _fakeDataSource.GetAllProducts();
        }
    }
}
