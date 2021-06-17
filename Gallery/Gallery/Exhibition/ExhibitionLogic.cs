using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    public class ExhibitionLogic
    {

        public static void AddEx(Context db, string name, int country, string city, DateTime date)
        {

            Exhibition ex = new Exhibition
            {
                NameExhibition = name,
                Date = date,
                City = city,
                CountryId = country
            };

            db.Exhibitions.Add(ex);
            db.SaveChanges();
        }

        public static void DelEx(Context db, int ident)
        {
            Exhibition ex = db.Exhibitions.Find(ident);
            db.Exhibitions.Remove(ex);
            db.SaveChanges();
        }
        public static Exhibition GetExById(Context db, int ident)
        {
            
            Exhibition ex = db.Exhibitions.Find(ident);

            return ex;
        }
        public static void SaveEditEx(Context db, int id, string name, int country, string city, DateTime date)
        {

            Exhibition ex = GetExById(db, id);

            ex.NameExhibition = name;
            ex.Date = date;
            ex.City = city;
            ex.CountryId = country;

            db.Entry(ex).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }
        public static List<Exhibition> GetOrderedExhibName(Context Db)
        {
            return Db.Exhibitions.OrderBy(e => e.NameExhibition).ToList();
        }
        public static List<Exhibition> GetOrderedExhibCountry(Context Db)
        {
            return Db.Exhibitions.OrderBy(e => e.CountryId).ToList();
        }
        public static List<Exhibition> GetOrderedExhibCity(Context Db)
        {
            return Db.Exhibitions.OrderBy(e => e.City).ToList();
        }
        public static List<Exhibition> GetOrderedExhibDate(Context Db)
        {
            return Db.Exhibitions.OrderBy(e => e.Date).ToList();
        }

    }
}
