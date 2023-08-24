using MediatR;
using Reactivities.Domain;

namespace Reactivities.Application.Features.Activities.Queries.GetActivityDetails;

public class GetActivityDetailsQuery : IRequest<Activity>
{
    public Guid Id { get; set; }
}
