using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class CustomerLogic
    {
        public static void AddCust(Context db, string surname, string name, string mid_name, int pass_id, int pass_series, string phone)
        {

            Customer cr = new Customer
            {
                Surname = surname,
                Name = name, 
                Middle_Name = mid_name,
                Passport_id = pass_id, 
                Passport_series = pass_series,
                Phone = phone,
            };

            db.Customers.Add(cr);
            db.SaveChanges();
        }

        public static void DelCust(Context db, int ident)
        {
            Customer cr = db.Customers.Find(ident);
            db.Customers.Remove(cr);
            db.SaveChanges();
        }
        public static Customer GetCustById(Context db, int ident)
        {

            Customer cr = db.Customers.Find(ident);

            return cr;
        }
        public static void SaveEditCust(Context db, int id, string surname, string name, string mid_name, int pass_id, int pass_series, string phone)
        {

            Customer cr = GetCustById(db, id);

            cr.Surname = surname;
            cr.Name = name;
            cr.Middle_Name = mid_name;
            cr.Passport_id = pass_id;
            cr.Passport_series = pass_series;
            cr.Phone = phone;

            db.Entry(cr).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }
        public static List<Customer> GetOrderedCustomerName(Context Db)
        {
            return Db.Customers.OrderBy(e => e.Name).ToList();
        }
        public static List<Customer> GetOrderedCustomerMiddleName(Context Db)
        {
            return Db.Customers.OrderBy(e => e.Middle_Name).ToList();
        }
    }
}
