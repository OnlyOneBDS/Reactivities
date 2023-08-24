using MediatR;
using Reactivities.Persistence;

namespace Reactivities.Application.Features.Activities.Commands.CreateActivity;

public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, Unit>
{
    private readonly ReactivitiesContext _context;

    public CreateActivityCommandHandler(ReactivitiesContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
    {
        _context.Activities.Add(request.Activity);
        await _context.SaveChangesAsync();

        return Unit.Value;
    }
}