using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class PaintLogic
    {
        public static void AddPaint(Context db, int genre_id, int ex_id, string name_painting, int art_id, int painting_status)
        {

            Painting p = new Painting
            {
                GenreId = genre_id,
                ExhibitionId = ex_id,
                NamePainting = name_painting,
                ArtistId = art_id,
                PaintingStatus = (PaintingStatus)painting_status
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
        public static Painting GetPaintById(Context db, int ident)
        {

            Painting p = db.Paintings.Find(ident);

            return p;
        }
        public static void SaveEditPaint(Context db, int genre_id, int ex_id, string name_paint, int art_id, PaintingStatus paint_status, int id)
        {

            Painting p = GetPaintById(db, id);

            p.GenreId = genre_id;
            p.ExhibitionId = ex_id;
            p.NamePainting = name_paint;
            p.ArtistId = art_id;
            p.PaintingStatus = paint_status;

            db.Entry(p).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }
        public static List<Painting> GetOrderedPaintingName(Context Db)
        {
            return Db.Paintings.OrderBy(e => e.NamePainting).ToList();
        }
        public static List<Painting> GetOrderedPaintingGenre(Context Db)
        {
            return Db.Paintings.OrderBy(e => e.GenreId).ToList();
        }
        public static List<Painting> GetOrderedPaintingArstist(Context Db)
        {
            return Db.Paintings.OrderBy(e => e.ArtistId).ToList();
        }
        public static List<Painting> GetOrderedPaintingExhib(Context Db)
        {
            return Db.Paintings.OrderBy(e => e.ExhibitionId).ToList();
        }
    }
}
