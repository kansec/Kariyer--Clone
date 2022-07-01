using System.ComponentModel;
using System.Runtime.Serialization;

namespace KariyerClone.Models.Dtos
{
    public class JobDto
    {
        public string Title { get; set; }
        public CompanyForJobDto Company { get; set; }
        public string City { get; set; }
        public string TypeOfWork { get; set; }

        [Browsable(false)]
        public DateTime PostingDate { get; set; }
        public string WhenPosted => $"{(DateTime.Now - PostingDate).Days} days ago";
            



    }
}
