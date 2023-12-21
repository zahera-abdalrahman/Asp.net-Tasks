using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }

        public string ManagerName { get; set; }
    }
}
