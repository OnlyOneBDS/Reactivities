using MediatR;
using Reactivities.Domain;
using Reactivities.Persistence;

namespace Reactivities.Application.Features.Activities.Queries.GetActivityDetails;

public class GetActivityDetailsQueryHandler : IRequestHandler<GetActivityDetailsQuery, Activity>
{
    private readonly ReactivitiesContext _context;
    public GetActivityDetailsQueryHandler(ReactivitiesContext context)
    {
        _context = context;
    }

    public async Task<Activity> Handle(GetActivityDetailsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Activities.FindAsync(request.Id);
    }
}