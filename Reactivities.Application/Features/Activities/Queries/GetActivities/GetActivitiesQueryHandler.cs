using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;
using Reactivities.Persistence;

namespace Reactivities.Application.Features.Activities.GetActivities.Queries;

public class GetActivitiesQueryHandler : IRequestHandler<GetActivitiesQuery, List<Activity>>
{
    private readonly ReactivitiesContext _context;

    public GetActivitiesQueryHandler(ReactivitiesContext context)
    {
        _context = context;
    }

    public async Task<List<Activity>> Handle(GetActivitiesQuery request, CancellationToken cancellationToken)
    {
        return await _context.Activities.ToListAsync();
    }
}