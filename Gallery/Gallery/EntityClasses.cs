using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace Gallery
{
    public enum StatusSell { sold, cancel, progress }
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Middle_Name { get; set; }
        public int Passport_id { get; set; }
        public int Passport_series { get; set; }
        [StringLength(100)]
        public string Phone { get; set; }
    }

    public class Sell
    {
        public long Price { get; set; }
        public DateTime Date { get; set; }
        public StatusSell Status { get; set; }
    }

    public class Journal
    {
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        //доделать
    }
    public class PaintingCost
    {
        public int Cost { get; set; }
    }
}
