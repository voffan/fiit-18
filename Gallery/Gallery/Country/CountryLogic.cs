using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class CountryLogic
    {
        public static void AddCountry(Context db, string name)
        {
            Country p = new Country
            {
                Name = name
            };

            db.Countries.Add(p);
            db.SaveChanges();
        }
        public static void DelCountry(Context db, int ident)
        {
            Country p = db.Countries.Find(ident);
            db.Countries.Remove(p);
            db.SaveChanges();
        }
        public static Country GetCountryById(Context db, int ident)
        {
            Country p = db.Countries.Find(ident);
            return p;
        }
    }
}
