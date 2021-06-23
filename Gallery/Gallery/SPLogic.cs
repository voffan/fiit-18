using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class SPLogic
    {
        public static void AddSellPainting(Context db, int price, int paintId)
        {

            SellPainting emp = new SellPainting
            {
                PaintingId = paintId,
                Cost = price
            };
            db.SellPaintings.Add(emp);
            db.SaveChanges();
        }
        public static void DelSellPainting(Context db, int ident)
        {
            SellPainting emp = db.SellPaintings.Find(ident);
            db.SellPaintings.Remove(emp);
            db.SaveChanges();
        }

        public static SellPainting GetSellById(Context db, int ident)
        {

            SellPainting ex = db.SellPaintings.Find(ident);
            return ex;
        }
        public static void SaveEditEx(Context db, int price,int paintId, int id)
        {

            SellPainting ex = GetSellById(db, id);
            ex.Cost = price;
            ex.PaintingId = paintId;
            db.Entry(ex).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public static List<SellPainting> GetOrderedSellPrice(Context Db)
        {
            return Db.SellPaintings.OrderBy(e => e.Cost).ToList();
        }
       
    }
}
