using System.ComponentModel.DataAnnotations.Schema;

namespace KariyerClone.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Company Company { get; set; }
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        public string City { get; set; }
        public string TypeOfWork { get; set; }
        public string PositionLevel { get; set; }
        public string Department { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public string Description { get; set; }
        public ApplicantCriterias ApplicantCriterias { get; set; }
        [ForeignKey("ApplicantCriteriasId")]
        public int ApplicantCriteriasId { get; set; }

    }
}
