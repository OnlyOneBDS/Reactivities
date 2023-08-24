using AutoMapper;
using Reactivities.Domain;

namespace Reactivities.Application.MappingProfiles;

public class ActivityProfile : Profile
{
    public ActivityProfile()
    {
        CreateMap<Activity, Activity>();
    }
}