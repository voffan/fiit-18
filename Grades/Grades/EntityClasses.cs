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
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public int Phone { get; set; }

        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
    }

    public class Class
    {
        [Key]
        public int Id { get; set; }
        public char Symbol { get; set; }
        public int Year { get; set; }
        public int SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public School School { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Curator { get; set; }


        public virtual ICollection<Student> Students { get; set; }
    }

    public class School
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Employee> Employeers { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }

    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public int Phone { get; set; }
        
        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }

        public int SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public School School { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }

    public class Course
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }
        public int? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Subgroup { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public ICollection<Table> Tables { get; set; }
    }

    public class Group
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }

    public class Table
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        public int AcademicYearId { get; set; }
        [ForeignKey("AcademicYearId")]
        public AcademicYear AcademicYear { get; set; }
        public int CheckPointId { get; set; }
        [ForeignKey("CheckPointId")]
        public CheckPoint CheckPoint { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public int MarkId { get; set; }
        [ForeignKey("MarkId")]
        public Mark Mark { get; set; }
    }


    // Подклассы    
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public int Name { get; set; }
        [StringLength(50)]
    }

    public class Position
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }

    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }

    public class CheckPoint
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        
        public virtual ICollection<Table> Tables { get; set; }
    }
    public class AcademicYear
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public virtual ICollection<Table> Tables { get; set; }
    }
}