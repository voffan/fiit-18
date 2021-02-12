using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Grades
{
    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }

    public class Class
    {
        public string Symbol { get; set; }
        public int Year { get; set; }
        public string School { get; set; }
    }

    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }

    public class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        //public Position Position { get; set; }
    }

    public class Course
    {

    }

    public class Group
    {

    }

    public class AcademicYear
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
    
    public class Mark
    {
        public int Name { get; set; }
    }

    public class Position
    {
        public string Name { get; set; }
    }

    public class Subject
    {
        public string Name { get; set; }
    }

    public class CheckPoint
    {
        public string Name { get; set; }
    }

    public class Table
    {
        
    }
}
