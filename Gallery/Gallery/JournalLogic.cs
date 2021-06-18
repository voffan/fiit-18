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
           
    }
}
