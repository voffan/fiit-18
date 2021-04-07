using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Data.Entity;


namespace Gallery
{
    public enum StatusSell { sold, cancel, progress }
    public enum Status {active, inactive }
    public enum PaintingStatus { vault, exhibition, restoration}
    public enum Position { admin, restore, sellManager, employee}
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Departament
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }
    public class Person
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
        public Position Position { get; set; }
    }
    public class Employee:Person
    {
        public int DepId { get; set; }
        [ForeignKey("DepId")]
        public Departament Departament { get; set; }
        public Status Status { get; set; }
    }
    public class Sell
    {
        [Key]
        public int Id { get; set; }
        public long Price { get; set; }
        public DateTime Date { get; set; }
        public StatusSell Status { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public virtual List<SellPainting> Paintings { get; set; }
    }
    public class Exhibition
    {
        [Key]
        public int Id { get; set; }
        public string NameExhibition { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }

        public virtual List<Painting> Paintings { get; set; }
    }

    public class Journal
    {
        public int EmpId { get; set; }
        [ForeignKey("EmpId")]
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public int? SrcId { get; set; }
        [ForeignKey("SrcId")]
        public Departament Source { get; set; }
        public int? DstId { get; set; }
        [ForeignKey("DstId")]
        public Departament Destination { get; set; }
        public int? ExhId { get; set; }
        [ForeignKey("ExhId")]
        public Exhibition Exhibition { get; set; }
        public int PaintingId { get; set; }
        [ForeignKey("PaintingId")]
        public Painting Painting { get; set; }
    }
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string NameGenre { get; set; }
    }
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Middle_Name { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }

        public virtual List<Painting> Paintings {get;set;}
    }
    public class SellPainting
    {
        [Key]
        public int Id { get; set; }
        public int SellId { get; set; }
        [ForeignKey("SellId")]
        public Sell Sell { get; set; }
        public int PaintingId { get; set; }
        [ForeignKey("PaintingId")]
        public Painting Painting { get; set; }
        public int Cost { get; set; }
    }
    public class Painting
    {
        [Key]
        public int Id { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        public int? ExhibitionId { get; set; }
        [ForeignKey("ExhibitionId")]
        public Exhibition Exhibition { get; set; }
        public string NamePainting { get; set; }
        public int ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }
        public PaintingStatus PaintingStatus { get; set; }

    }
    public class Customer:Person
    {
        public ICollection<Sell> Sells { get; set; }
    }
    public class Auth
    {
        public int Id { get; set; }
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
