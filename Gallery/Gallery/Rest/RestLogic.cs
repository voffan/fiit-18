using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class RestLogic
    {
        public static Painting GetPaintById(Context db, int ident)
        {

            Painting ex = db.Paintings.Find(ident);

            return ex;
        }
        public static void SaveEditPaint(Context db, int id)
        {

            Painting p = GetPaintById(db, id);

            p.PaintingStatus = (PaintingStatus)0;

            db.Entry(p).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }
    }
}
