using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class PaintLogic
    {
        public static void AddPaint(Context db, string name, int country, string city, DateTime date)
        {

            Painting p = new Painting
            {
                
            };

            db.Paintings.Add(p);
            db.SaveChanges();
        }

        public static void DelPaint(Context db, int ident)
        {
            Painting p = db.Paintings.Find(ident);
            db.Paintings.Remove(p);
            db.SaveChanges();
        }
        public static Painting GetExById(Context db, int ident)
        {

            Painting p = db.Paintings.Find(ident);

            return p;
        }
        public static void SaveEditPaint(Context db, int id, string name, int country, string city, DateTime date)
        {

            Painting p = GetExById(db, id);

            p.NamePainting = name;

            db.Entry(p).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }
    }
}
