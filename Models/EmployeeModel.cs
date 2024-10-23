using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string Login { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        public RoleModel? Role { get; set; }

        public ICollection<ServiceModel>? Services { get; set; }
    }
}
