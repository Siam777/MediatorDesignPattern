using MediatR;

namespace CqrsWithMediatorDesignPattern.Queries
{
    public class GetProductsQuery:IRequest<IEnumerable<Product>>
    {
    }
}
