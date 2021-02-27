using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Sport
{
    public class Sportsmen
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
    }
    public class Judge
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        [StringLength(255)]
        public virtual List<SportKind> SportKind { get; set; }
    }
    public class Organizer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        [StringLength(255)]
        public virtual List<SportKind> SportKind { get; set; }
    }
    public class Competition
    {
        [Key]
        public string Level { get; set; }
        public string Place { get; set; }
        public DateTime OpenDate { get; set; }
        [StringLength(255)]
        public DateTime CloseDate { get; set; }
        [StringLength(255)]
        public virtual List<Results> Results { get; set; }
        public virtual List<SportKind> SportKind { get; set; }
    }
    public class Results
    {
        [Key]
        public string Place { get; set; }
        public string Sportsman { get; set; }
        public float Result { get; set; }
        [StringLength(255)]
        public virtual List<SportKind> SportKind { get; set; }
    }
    public class Administaror
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        [StringLength(255)]
        public virtual List<SportKind> SportKind { get; set; }

    }
    public class SportKind
    {
        public string Sport_Kind { get; set; }
    }
}