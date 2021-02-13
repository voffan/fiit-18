using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace Sport
{
    
    public class Sportsman
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }

    public class Judge
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }

    public class Organizer
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }
    public class Administrator
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }
    public class Competition
    {
    [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }

}
