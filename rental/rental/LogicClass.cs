using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental
{
    class LogicClass
    {
        public int gridmode = 0;
        public void GridMode(int _i)
        {
            gridmode = _i;/*
            using (ApplicationContext db = new ApplicationContext())
            {
                switch (_i)
                {
                    case 0:
                        
                        Console.WriteLine("Список объектов:");
                        foreach (Client u in db.Clients)
                        {
                            Console.WriteLine("{0}.{1}", u.Id, u.FullName);
                        }
                        dataGridView1.DataSource = db.Clients.ToList();
                        break;
                    case 1:
                        dataGridView1.DataSource = db.Disks.ToList();
                        break;
                    case 2:
                        dataGridView1.DataSource = db.Movies.ToList();
                        break;
                    case 3:
                        dataGridView1.DataSource = db.Orders.ToList();
                        break;
                    default:
                        break;
                }
            }*/
        }
    }
}
