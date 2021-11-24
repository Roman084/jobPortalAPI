using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using jobPortalAPI.Data.Entities;
using jobPortalAPI.Domain.Models.Result;

namespace jobPortalAPI.Domain.Services
{
    public interface IJobService
    {
        Task<List<JobPost>> GetAll();
        Task<Result<JobPost>> GetById(Guid id);
        Task Import();
    }
}