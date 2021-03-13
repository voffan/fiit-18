using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    public class ExhibitionLogic
    {
        public static void AddEx(string name, string country, string city, DateTime date)
        {
            Context Con = new Context();
            Country country_name = new Country
            {
                Name = country
            };
            Con.Countries.Add(country_name);
            Con.SaveChanges();
            int id = country_name.Id;

            Exhibition ex = new Exhibition
            {
                NameExhibition = name, 
                Date = date,
                City = city  
            };

            Con.Exhibitions.Add(ex);
            Con.SaveChanges();
        }
    }
}
