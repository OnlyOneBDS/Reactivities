using MediatR;
using Reactivities.Domain;

namespace Reactivities.Application.Features.Activities.Commands.CreateActivity;

public class CreateActivityCommand : IRequest<Unit>
{
    public Activity Activity { get; set; }
}
