using MediatR;
using Reactivities.Domain;

namespace Reactivities.Application.Features.Activities.GetActivities.Queries;

public class GetActivitiesQuery : IRequest<List<Activity>> { }