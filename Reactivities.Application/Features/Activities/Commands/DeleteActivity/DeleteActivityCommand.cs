using MediatR;


namespace Reactivities.Application.Features.Activities.Commands.DeleteActivity;

public class DeleteActivityCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}