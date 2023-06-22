using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;

namespace Reactivities.Persistence;

public class ReactivitiesContext : DbContext
{
  public ReactivitiesContext(DbContextOptions<ReactivitiesContext> options) : base(options)  { }

  public DbSet<Activity> Activities { get; set; }
}