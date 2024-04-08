using MediatR;

namespace CqrsWithMediatorDesignPattern.Commands
{
    public class AddProductCommand: IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    };
}
