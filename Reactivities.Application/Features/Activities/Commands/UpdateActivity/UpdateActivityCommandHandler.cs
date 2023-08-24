using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Persistence;

namespace Reactivities.Application.Features.Activities.Commands.UpdateActivity;

public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommand, Unit>
{
    private readonly ReactivitiesContext _context;
    private readonly IMapper _mapper;

    public UpdateActivityCommandHandler(ReactivitiesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
    {
        // Get the activity to be updated
        var activity = await _context.Activities.FindAsync(request.Activity.Id);

        // Update activity
        _mapper.Map(request.Activity, activity);

        // Save changes
        await _context.SaveChangesAsync();

        return Unit.Value;

        //_context.Entry(request).State = EntityState.Modified;
        //await _context.SaveChangesAsync();

        //return Unit.Value;
    }
}