using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models
{
    public class Department
    {
        public Department()
        {
            Pools = new HashSet<Pool>();
            Projects = new HashSet<Project>();
            DrivesUnderDepartment = new HashSet<Drive>();
        }
        [Key]
        public int DepartmentId{get; set;}
        [Required]
        [StringLength(30)]
        public string? DepartmentName{get;set;}
        public bool IsActive { get; set; } = true;
        public int? AddedBy { get; set; }
        public DateTime? AddedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        [InverseProperty("department")]
        public ICollection<Pool> Pools{get;set; }

        [InverseProperty("department")]
        public ICollection<Project>? Projects { get; set; }
        [InverseProperty("Department")]
        public ICollection<Employee> ?EmployeesUnderDepartment{get;set;}

        [InverseProperty("Department")]
        public ICollection<Drive>? DrivesUnderDepartment { get; set; }
        

        
    }
}

