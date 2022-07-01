namespace KariyerClone.RequestHelpers
{
    public class JobParams : PaginationParams
    {
        public string? OrderBy { get; set; }
        public string? SearchTerm { get; set; }
        public string? Cities { get; set; }
        public string? TypeOfWorks { get; set; }
        public string? PositionLevels { get; set; }
        public string? Departments { get; set; }
        public string? CompanySectors { get; set; }
        public string? EducationLevels { get; set; }


    }
}

