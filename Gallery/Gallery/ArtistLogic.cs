using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class ArtistLogic
    {
        public static void AddArt(Context db, string name, string middle_name, string surname, string birth, string death)
        {
            Artist art = new Artist
            {
                Name = name,
                Middle_Name = middle_name,
                Surname = surname,
                BirthYear = birth,
                DeathYear = death
            };
            db.Artists.Add(art);
            db.SaveChanges();
        }
        public static void DelArt(Context db, int ident)
        {
            Artist art = db.Artists.Find(ident);
            db.Artists.Remove(art);
            db.SaveChanges();
        }

        public static Artist GetArtById(Context db, int ident)
        {

            Artist art = db.Artists.Find(ident);

            return art;
        }
        public static void SaveEditArt(Context db, string name, string middle_name, string surname, string birth, string death, int id)
        {

            Artist ex = GetArtById(db, id);

            ex.Name = name;
            ex.Surname = surname;
            ex.Middle_Name = middle_name;
            ex.BirthYear = birth;
            ex.DeathYear = death;
            
            db.Entry(ex).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }

        public static List<Artist> GetOrderedEmployeesName(Context Db)
        {
            return Db.Artists.OrderBy(e => e.Name).ToList();
        }
        public static List<Artist> GetOrderedEmployeesMiddleName(Context Db)
        {
            return Db.Artists.OrderBy(e => e.Middle_Name).ToList();
        }
        public static List<Artist> GetOrderedEmployeesSurname(Context Db)
        {
            return Db.Artists.OrderBy(e => e.Surname).ToList();
        }
    }
}
