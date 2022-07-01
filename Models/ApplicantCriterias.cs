namespace KariyerClone.Models
{
    public class ApplicantCriterias
    {
        public int Id { get; set; }
        public string? EducationLevel { get; set; }
        public string? MilitaryStatus { get; set; }
        public string? DrivingLicense { get; set; }
        public List<Job> Jobs { get; set; }

    }
}