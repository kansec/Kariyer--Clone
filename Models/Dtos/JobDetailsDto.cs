namespace KariyerClone.Models.Dtos
{
    public class JobDetailsDto
    {
        public string Title { get; set; }
        public CompanyDto Company { get; set; }
        public string City { get; set; }
        public string TypeOfWork { get; set; }
        public string PositionLevel { get; set; }
        public string Department { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public string Description { get; set; }
        public ApplicantCriteriasDto ApplicantCriterias { get; set; }
    }
}
