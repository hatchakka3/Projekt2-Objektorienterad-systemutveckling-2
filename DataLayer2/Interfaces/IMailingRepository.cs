using System.Collections.Generic;
using BusinessEntities;
using BusinessEntities.Entities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public interface IMailingRepository : IGenericRepository<MailingDto>
    {
        void UpdateMailingWithAddedAlumnus(AlumnusDto alumnus, MailingDto mailing);
    }
}