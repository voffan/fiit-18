using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gallery
{
    class SellLogic
    {
        public static void AddSell(Context db, long price, DateTime date, StatusSell status, int customer_id)
        {

            Sell emp = new Sell
            {
                Price = price,
                Date = date,
                Status = status,
                CustomerId = customer_id
            };
            db.Sells.Add(emp);
            db.SaveChanges();
        }
        public static void DelSell(Context db, int ident)
        {
            Sell emp = db.Sells.Find(ident);
            db.Sells.Remove(emp);
            db.SaveChanges();
        }

        public static Sell GetSellById(Context db, int ident)
        {

            Sell ex = db.Sells.Find(ident);
            return ex;
        }
        public static void SaveEditEx(Context db, long price, DateTime date, int status, int customer_id, int id)
        {

            Sell ex = GetSellById(db, id);
            ex.Price = price;
            ex.Date = date;
            ex.Status = (StatusSell)status;
            ex.CustomerId = customer_id;
            db.Entry(ex).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public static List<Sell> GetOrderedSellPrice(Context Db)
        {
            return Db.Sells.OrderBy(e => e.Price).ToList();
        }
        public static List<Sell> GetOrderedSellDate(Context Db)
        {
            return Db.Sells.OrderBy(e => e.Date).ToList();
        }
        public static List<Sell> GetOrderedSellCust(Context Db)
        {
            return Db.Sells.OrderBy(e => e.CustomerId).ToList();
        }
       
    }
}
