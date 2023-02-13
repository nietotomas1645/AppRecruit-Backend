using System.ComponentModel.DataAnnotations;

namespace BackendApi.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string? Technology { get; set; }
        public string? Position { get; set; }
        public string? Experience { get; set; }
        public string? Company { get; set; }
        public string? Seniority { get; set; }
        public string? Workplace { get; set; }
        public string? Location { get; set; }
        public string? Studies { get; set; }
        public int? Salary { get; set; }
        public string? Aboutpos { get; set; }
        public string? Benefits { get; set; }


    }
}
