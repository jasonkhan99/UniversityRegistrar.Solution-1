using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    // public Student()
    // {
    //   this.Courses = new HashSet<Course>();
    // }
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public System.DateTime EnrolmentDate { get; set; }
    // public ICollection<Course> Courses { get; set; }
  }
}