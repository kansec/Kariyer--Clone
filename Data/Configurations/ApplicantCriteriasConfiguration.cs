using KariyerClone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KariyerClone.Data.Configurations
{
    public class ApplicantCriteriasConfiguration : IEntityTypeConfiguration<Models.ApplicantCriterias>
    {
        public void Configure(EntityTypeBuilder<ApplicantCriterias> builder)
        {
            builder.HasData(
                new ApplicantCriterias
                {
                    Id = 1,
                    MilitaryStatus = "Done",
                    DrivingLicense = "B",
                    EducationLevel = "Bachelor"
                },
                new ApplicantCriterias
                {
                    Id = 2,
                    DrivingLicense = "B",
                    EducationLevel = "Master"
                },
                new ApplicantCriterias
                {
                    Id = 3,
                    MilitaryStatus = "Done",
                    DrivingLicense = "B",
                    EducationLevel = "PHD"
                },
                new ApplicantCriterias
                {
                    Id = 4,
                    EducationLevel = "Master"
                },
                new ApplicantCriterias
                {
                    Id = 5,
                    MilitaryStatus = "Done",
                }
                );


        }
    }
}
