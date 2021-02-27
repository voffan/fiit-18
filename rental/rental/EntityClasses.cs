using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Data.Entity;

namespace Rental
{
    public enum ClientStatus { normal, blacklist }
    public enum OrderStatus { Active, Inactive }
    public enum DiscStatus { status1,status2}
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
    public class PositionEmployee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
    public class Employee : Person
    {
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        public int PositionEmployeeId { get; set; }
        public PositionEmployee PositionEmployee { get; set; }

    }
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
    }
    public class Client : Person
    {
        public int PhoneNumber { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public ClientStatus Status { get; set; }

    }
    public class Order
    {
        [Key]
        public int Ordernumber { get; set; }
        public float Cost { get; set; }
        public DateTime Date { get; set; }
        public DateTime ReturnDate { get; set; }
        [StringLength(255)]
        public string Pledgetype { get; set; }
        public OrderStatus Status { get; set; }
        public virtual List<Disc> Discs { get; set; }
    }
    public class Disc
    {
        [Key]
        public int Id { get; set; }
        public DiscStatus Status { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        public int Year { get; set;}
        public Country Country { get; set; }
        [StringLength(12)]
        public string AgeLimit { get; set; }
        public float Rating { get; set; }

        public virtual List<Disc> Dicsc { get; set; }
    }
    public class Blacklist
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        [StringLength(255)]
        public string Reason { get; set; }
    }
    public class Rental
    {
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public DateTime OpenTime { get; set; }
        public int CloseTime { get; set; }
    }
}
