using System.ComponentModel.DataAnnotations;

namespace CRUD.Models.User
{
    public class Students
    {
        public int Id { get; set; }
        [Required]
        public int Regno { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? FatherName { get; set; }
      
        [Required]
        public long Mobile { get; set; }
        [EmailAddress]
        [Required]
        public string? Email { get; set;}
        [Required]
        public string? Department { get; set; }

    }
}
