using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using Grades;

namespace Grades
{

    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(40)]
        public string UserName { get; set; }
        [StringLength(40)]
        public string Password { get; set; }
        public string Role { get; set; }

    }
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }

        public int? ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
        public override string ToString()
        {
            return Surname +" "+ Name +" " +MiddleName;
        }
    }

    public class Class
    {
        [Key]
        public int Id { get; set; }
        public char Symbol { get; set; }
        public int? Year { get; set; }
        public int? SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public virtual School School { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public override string ToString()
        {
            return Year.ToString() + Symbol;
        }
    }

    public class School
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Employee> Employeers { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }

    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }

        public int? PositionId { get; set; }
        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        public int? SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public virtual School School { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public override string ToString()
        {
            return Surname + " " + Name + " " + MiddleName;
        }
    }

    public class Course
    {
        [Key]
        public int Id { get; set; }
        public int? SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        public int? ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }
        public int? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Group Subgroup { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public virtual ICollection<Table> Tables { get; set; }
    }

    public class Group
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
        public int? ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }

    public class Table
    {
        [Key]
        public int Id { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        public int? AcademicYearId { get; set; }
        [ForeignKey("AcademicYearId")]
        public virtual AcademicYear AcademicYear { get; set; }
        public int? CheckPointId { get; set; }
        [ForeignKey("CheckPointId")]
        public virtual CheckPoint CheckPoint { get; set; }
        public int? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        public int? MarkId { get; set; }
        [ForeignKey("MarkId")]
        public virtual Mark Mark { get; set; }
    }


    // Подклассы    
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public String Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }

    public class Position
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }

    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }

    public class CheckPoint
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        
        public virtual ICollection<Table> Tables { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
    public class AcademicYear
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }

        public virtual ICollection<Table> Tables { get; set; }
        public override string ToString()
        {
            return Start.ToString() + End.ToString();
        }
    }
}