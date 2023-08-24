using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Reactivities.Domain;

namespace Reactivities.Application.Features.Activities.Commands.UpdateActivity;

public class UpdateActivityCommand : IRequest<Unit>
{
    public Activity Activity { get; set; }
}
