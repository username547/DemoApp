using System.ComponentModel.DataAnnotations;

namespace DemoApp.Models
{
    public class RoleModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<EmployeeModel>? Employees { get; set; }
    }
}
