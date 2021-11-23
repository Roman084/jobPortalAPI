using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using jobPortalAPI.Data.Entities;

namespace jobPortalAPI.Domain.Services
{
    public interface IJobService
    {
        Task<List<JobPost>> GetAll();
        Task<JobPost> GetById(Guid id);
        Task Import();
    }
}