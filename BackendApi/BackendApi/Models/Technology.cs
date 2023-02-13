using System.ComponentModel.DataAnnotations;

namespace BackendApi.Models
{
    public class Technology
    {

        [Key]
        public int TechnologyId { get; set; }
        public string? TechnologyName { get; set; }
    }
}
