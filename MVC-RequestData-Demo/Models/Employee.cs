using System.ComponentModel.DataAnnotations;

namespace MVC_RequestData_Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Email { get; set; }

        public string Department { get; set; }
    }
}