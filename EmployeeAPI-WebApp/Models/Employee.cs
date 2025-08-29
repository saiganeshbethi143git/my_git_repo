using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI_WebApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required] public string Name { get; set; } = string.Empty;
        [Required] public int Age { get; set; }
        [Required] public string Email { get; set; } = string.Empty;
        [Required] public string Phone { get; set; } = string.Empty;
        [Required] public string Department { get; set; } = string.Empty;
    }
}
