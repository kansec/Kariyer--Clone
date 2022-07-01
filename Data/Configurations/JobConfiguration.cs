using KariyerClone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KariyerClone.Data.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        private readonly List<int> companies = new List<int>() { 1, 2, 3, 4, 5 };
        private readonly List<string> titles = new List<string> { "Developer", "Marketer", "Salesman", "Finance Specialist", "Human Resource Specialist" };
        private readonly List<string> typeOfWorks = new List<string> { "Part-time", "Full-time", "Contract-Based" };
        private readonly List<string> positionLevels = new List<string> { "Junior", "Senior", "Principal", "Manager" };
        private readonly List<string> cities = new List<string> { "Adana", "Los Angeles", "Bangkok", "Wuhan", "Dubai", "Tokyo", "Istanbul" };
        private readonly List<string> departments = new List<string> { "IT", "Marketing","Sales","Finance","Human Resources"};

        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(JobGenerator(35));

        }

        public List<Job> JobGenerator(int amount)
        {
            var jobs = new List<Job>();
            var random = new Random();
            for(int i = 0; i < amount; i++)
            {
                var randomIndexForDepartment = random.Next(titles.Count);
                jobs.Add(new Job()
                {
                    Id = i + 1,
                    Title = titles[randomIndexForDepartment],
                    CompanyId = companies[random.Next(companies.Count)],
                    TypeOfWork = typeOfWorks[random.Next(typeOfWorks.Count)],
                    ApplicantCriteriasId = random.Next(1,5),
                    City = cities[random.Next(cities.Count)],
                    PostingDate = DateTime.Now,
                    ClosingDate = (DateTime.Now).AddDays(random.Next(5, 60)),
                    Department = departments[randomIndexForDepartment],
                    Description = "Job Description" + $"{i + 1}",
                    PositionLevel = positionLevels[random.Next(positionLevels.Count)]
                    
                });
            
            }

            return jobs;

        }
    }
}
