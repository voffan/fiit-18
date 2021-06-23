using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class GenreLogic
    {
        public static void AddGenre(Context db, string name)
        {
            Genre p = new Genre
            {
                NameGenre = name
            };

            db.Genres.Add(p);
            db.SaveChanges();
        }
        public static void DelGenre(Context db, int ident)
        {
            Genre p = db.Genres.Find(ident);
            db.Genres.Remove(p);
            db.SaveChanges();
        }
        public static Genre GetGenreById(Context db, int ident)
        {
            Genre p = db.Genres.Find(ident);
            return p;
        }
    }
}
