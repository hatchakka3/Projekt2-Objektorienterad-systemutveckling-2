using System.Collections.Generic;
using BusinessEntities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public interface IActivityRepository: IGenericRepository<ActivityDto>
    {
        ICollection<AlumnusDto> GetActivitiesAlumni(ActivityDto activity);
    }
}