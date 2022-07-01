using System.Text.Json.Serialization;

namespace KariyerClone.Models.Dtos
{
    public class ApplicantCriteriasDto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EducationLevel { get; set; }
        public string? MilitaryStatus { get; set; }
        public string? DrivingLicense { get; set; }

    }
}
