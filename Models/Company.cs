namespace KariyerClone.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int FoundationYear { get; set; }
        public string Logo { get; set; }
        public List<Job> Jobs { get; set; }

    }
}
