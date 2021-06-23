using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class JournalLogic
    {
        public static int Idempsda;
        public static void JournalAdd(Context db)
        {

            Journal p = new Journal
            {
                PaintingId = db.Paintings.OrderByDescending(c => c.Id).Select(c => c.Id).FirstOrDefault(),
                EmpId = Idempsda,
                Date = DateTime.Now,
                paintingStatus = db.Paintings.OrderByDescending(c => c.Id).Select(c => c.PaintingStatus).FirstOrDefault(),
                ExhId = db.Paintings.OrderByDescending(c => c.Id).Select(c => c.ExhibitionId).FirstOrDefault()
            };

            db.Journals.Add(p);
            db.SaveChanges();
        }
        public static void JournalRed(Context db, PaintingStatus paintingSt, int exhId, int paintingId)
        {

            Journal p = new Journal
            {
                PaintingId = paintingId,
                EmpId = Idempsda,
                Date = DateTime.Now,
                paintingStatus = paintingSt,
                ExhId = exhId
            };

            db.Journals.Add(p);
            db.SaveChanges();
        }
        public static void SaveJournal(Context db, int paintingId)
        {
            Painting p = GetPaintById(db, paintingId);

            Journal j = new Journal
            {
                PaintingId = paintingId,
                EmpId = Idempsda,
                Date = DateTime.Now,
                paintingStatus = PaintingStatus.Продажа,
                ExhId = p.ExhibitionId
            };
            db.Journals.Add(j);
            db.SaveChanges();
        }
        public static void SaveJournaldel(Context db, int paintingId)
        {
            Painting p = GetPaintById(db, paintingId);

            Journal j = new Journal
            {
                PaintingId = paintingId,
                EmpId = Idempsda,
                Date = DateTime.Now,
                paintingStatus = PaintingStatus.Хранилище,
                ExhId = p.ExhibitionId
            };
            db.Journals.Add(j);
            db.SaveChanges();
        }
        public static Painting GetPaintById(Context db, int ident)
        {
            Painting p = db.Paintings.Find(ident);
            return p;
        }

    }
}
