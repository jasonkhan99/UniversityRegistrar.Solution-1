using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public Course()
    {
      this.Students = new HashSet<Student>();
    }
    public string CourseName { get; set; }
    public int CourseNum { get; set; }
    public virtual ICollection<Student> Students { get; set; }
  }
}