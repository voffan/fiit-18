using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    public class ExhibitionLogic
    {
        public static void AddEx(string name, int country, string city, DateTime date)
        {
            Context Con = new Context();
            

            Exhibition ex = new Exhibition
            {
                NameExhibition = name, 
                Date = date,
                City = city,
                CountryId = country
            };

            Con.Exhibitions.Add(ex);
            Con.SaveChanges();
        }
    }
}
