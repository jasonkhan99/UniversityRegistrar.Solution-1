using System.Collections.Generic;

namespace Registrar.Models
{
  public class Department
  {
    public Department()
    {
      this.Students = new HashSet<DepartmentStudent>();
      this.Courses = new HashSet<Course>();
    }
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public ICollection<DepartmentStudent> Students { get; set; }
    public ICollection<Course> Courses { get; set; }
  }
}