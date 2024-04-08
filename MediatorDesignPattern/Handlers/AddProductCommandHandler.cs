using CqrsWithMediatorDesignPattern.Commands;
using MediatR;

namespace CqrsWithMediatorDesignPattern.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly FakeDataSource _fakeDataSource;

        public AddProductCommandHandler(FakeDataSource fakeDataSource)
        {
            _fakeDataSource = fakeDataSource;   
        }
        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataSource.AddProduct(request);
            return Unit.Value;
        }
    }
}
