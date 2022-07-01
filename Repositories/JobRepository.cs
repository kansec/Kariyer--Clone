using KariyerClone.Data;
using KariyerClone.Models;
using KariyerClone.RequestHelpers;
using Microsoft.EntityFrameworkCore;

namespace KariyerClone.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext _context;
        public JobRepository(AppDbContext context)
        {
            _context = context;

        }
        public async Task<List<Job>> GetAllJobsAsync()
        {
            var jobs = await _context.Jobs.Include(x => x.Company).ToListAsync();

            return jobs;
        }

        public async Task<PagedList<Job>> GetAllWithParams(JobParams jobParams)
        {
            var query = _context.Jobs.Include(j => j.Company).AsQueryable();

            //Sort
            if (!string.IsNullOrEmpty(jobParams.OrderBy))
            {
                query = jobParams.OrderBy switch
                {
                    "date" => query.OrderBy(j => j.PostingDate),
                    "dateDesc" => query.OrderByDescending(j => j.PostingDate),
                    _ => query.OrderBy(j => j.Title)
                };
            }

            query = query.OrderBy(j => j.Title);


            //Search

            if (!string.IsNullOrEmpty(jobParams.SearchTerm))
            {
                var lowerCaseSearchTerm = jobParams.SearchTerm.Trim().ToLower();

                query = query.Where(j => j.Title.ToLower().Contains(lowerCaseSearchTerm));
            }

            //filters

            var cityList = new List<string>();
            var typeOfWorkList = new List<string>();
            var positionLevelList = new List<string>();
            var departmentList = new List<string>();
            var companySectorList = new List<string>();
            var educationLevelList = new List<string>();

            if (!string.IsNullOrEmpty(jobParams.Cities))
            {
                cityList.AddRange(jobParams.Cities.ToLower().Split(",").ToList());
            }
            if (!string.IsNullOrEmpty(jobParams.TypeOfWorks))
            {
                typeOfWorkList.AddRange(jobParams.TypeOfWorks.ToLower().Split(",").ToList());
            }
            if (!string.IsNullOrEmpty(jobParams.PositionLevels))
            {
                positionLevelList.AddRange(jobParams.PositionLevels.ToLower().Split(",").ToList());
            }
            if (!string.IsNullOrEmpty(jobParams.PositionLevels))
            {
                departmentList.AddRange(jobParams.PositionLevels.ToLower().Split(",").ToList());
            }
            if (!string.IsNullOrEmpty(jobParams.CompanySectors))
            {
                companySectorList.AddRange(jobParams.CompanySectors.ToLower().Split(",").ToList());
            }
            if (!string.IsNullOrEmpty(jobParams.EducationLevels))
            {
                educationLevelList.AddRange(jobParams.EducationLevels.ToLower().Split(",").ToList());
            }



            query = query.Where(j => cityList.Count == 0 || cityList.Contains(j.City.ToLower()));
            query = query.Where(j => typeOfWorkList.Count == 0 || typeOfWorkList.Contains(j.TypeOfWork.ToLower()));
            query = query.Where(j => positionLevelList.Count == 0 || positionLevelList.Contains(j.PositionLevel.ToLower()));
            query = query.Where(j => departmentList.Count == 0 || departmentList.Contains(j.Department.ToLower()));
            query = query.Where(j => companySectorList.Count == 0 || companySectorList.Contains(j.Company.Sector.ToLower()));
            query = query.Where(j => educationLevelList.Count == 0 || educationLevelList.Contains(j.ApplicantCriterias.EducationLevel.ToLower()));


            var jobs = await PagedList<Job>.ToPagedList(query, jobParams.PageNumber, jobParams.PageSize);


            return jobs;
        }

        public async Task<Job> GetJobByIdAsync(int id )
        {
            var job = await _context.Jobs.Include(j => j.Company)
                .Include(x => x.ApplicantCriterias)
                .SingleOrDefaultAsync(x => x.Id == id);
            if(job == null)
            {
                return null;
            }

            return job;
        }

        public async Task<Filters> GetFilters()
        {
            var cities = await _context.Jobs.Select(j => j.City).Distinct().ToListAsync();
            var typeOfWorks = await _context.Jobs.Select(j => j.TypeOfWork).Distinct().ToListAsync();
            var positionLevels = await _context.Jobs.Select(j => j.PositionLevel).Distinct().ToListAsync();
            var departments = await _context.Jobs.Select(j => j.Department).Distinct().ToListAsync();
            var companySectors = await _context.Jobs.Select(j => j.Company.Sector).Distinct().ToListAsync();
            var educationLevels = await _context.Jobs.Select(j => j.ApplicantCriterias.EducationLevel).Distinct().ToListAsync();

            var filters = new Filters()
            {
                Cities = cities,
                TypeOfWorks = typeOfWorks,
                PositionLevels = positionLevels,
                Departments = departments,
                CompanySectors = companySectors,
                EducationLevels = educationLevels
            };

            return filters;

        }

        public class Filters
        {
            public List<string> Cities { get; set; }
            public List<string> TypeOfWorks { get; set; }
            public List<string> PositionLevels { get; set; }
            public List<string> Departments { get; set; }
            public List<string> CompanySectors { get; set; }
            public List<string> EducationLevels { get; set; }


        }
    }
}
