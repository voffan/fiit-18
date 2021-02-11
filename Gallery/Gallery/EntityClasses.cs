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
    public enum Status {active, inactive }
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

        public List<SellPainting> Paintings { get; set; }
    }
    public class Exhibition
    {
        [Key]
        public int Id { get; set; }
        public string NameExhibition { get; set; }
        public Country Country { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
    }

    public class Journal
    {
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public Departament Source { get; set; }
        public Departament Destination { get; set; }
        public Exhibition Exhibition { get; set; }

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
        public int DeathYera { get; set; }

        public List<Painting> Paintings {get;set;}
    }
    public class SellPainting
    {
        SellId
        []
        public Sell Sell { get; set; }
        PaintingId
        []
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
        public int IdExhibition { get; set; }
        [ForeignKey("IdExhibition")]
        public Exhibition Exhibition { get; set; }
        public string NamePainting { get; set; }
        public int IdArtist { get; set; }
        [ForeignKey("IdArtist")]
        public Artist Artist { get; set; }

    }
    public class Customer:Person
    {
        [Key]
        public int Id { get; set;  }
        public int IdSell { get; set; }
        [ForeignKey("IdSell")]
        public Sell Sell { get; set; }
    }
}
