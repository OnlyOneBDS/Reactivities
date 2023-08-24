using MediatR;
using Reactivities.Persistence;


namespace Reactivities.Application.Features.Activities.Commands.DeleteActivity;

public class DeleteActivityCommandHandler : IRequestHandler<DeleteActivityCommand, Unit>
{
    private readonly ReactivitiesContext _context;

    public DeleteActivityCommandHandler(ReactivitiesContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
    {
        // Get the activity to be deleted
        var activity = await _context.Activities.FindAsync(request.Id);

        _context.Remove(activity);
        await _context.SaveChangesAsync();

        return Unit.Value;
    }
}