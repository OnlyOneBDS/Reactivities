using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Features.Activities.Commands.CreateActivity;
using Reactivities.Application.Features.Activities.Commands.DeleteActivity;
using Reactivities.Application.Features.Activities.Commands.UpdateActivity;
using Reactivities.Application.Features.Activities.GetActivities.Queries;
using Reactivities.Application.Features.Activities.Queries.GetActivityDetails;
using Reactivities.Domain;

namespace Reactivities.Api.Controllers;

public class ActivitiesController : BaseApiController
{
  [HttpGet]
  public async Task<ActionResult<List<Activity>>> GetActivities()
  {
    return await Mediator.Send(new GetActivitiesQuery());
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<Activity>> GetActivity(Guid id)
  {
    return await Mediator.Send(new GetActivityDetailsQuery { Id = id });
  }

  [HttpPost]
  public async Task<IActionResult> CreateActivity(Activity activity)
  {
    return Ok(await Mediator.Send(new CreateActivityCommand { Activity = activity }));
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> UpdateActivity(Guid id, Activity activity)
  {
    activity.Id = id;
    return Ok(await Mediator.Send(new UpdateActivityCommand { Activity = activity }));
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteActivity(Guid id)
  {
    return Ok(await Mediator.Send(new DeleteActivityCommand { Id = id }));
  }
}