using MediatR;

namespace BuildingBlocks.CQRS;

public interface IQuery : ICommand<Unit>
{

}
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
