using KariyerClone.Models;
using KariyerClone.RequestHelpers;
using static KariyerClone.Repositories.JobRepository;

namespace KariyerClone.Repositories
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllJobsAsync();
        Task<Job> GetJobByIdAsync(int id);
        Task<PagedList<Job>> GetAllWithParams(JobParams jobParams);
        Task<Filters> GetFilters();
    }
}


