using System.Collections.Generic;
using BusinessEntities;
using DataLayer.Interfaces;
using BusinessEntities.Entities;

namespace DataLayer.Repositories
{
    public interface IAlumnusRepository: IGenericRepository<AlumnusDto>
    {
        ICollection<ActivityDto> GetAlumnusActivities(AlumnusDto alumnus);
        AlumnusDto GetAlumnusLogIn(string username, string password);
        AlumnusDto GetAlumnusPassword(AlumnusDto alumnus);
        List<AlumnusDto> SearchAlumnusByEducation(string input);
        List<AlumnusDto> SearchAlumnusByName(string input);
        void UpdateAlumnusWithMailing(AlumnusDto alumnus, MailingDto mailing);
    }
}