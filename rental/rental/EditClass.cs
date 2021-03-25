using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental
{
    class EditClass : ApplicationContext
    {
        public int Get_id()
        {
            int _id = 0;
            return _id;
        }
        public void Addbutton()
        {
            AddClient(0, "KEKW", "89141114444", "qwe@qwe.ru", 0);
        }
        public void AddClient(int _Id, string _FullName, string _PhoneNumber, string _Email, ClientStatus _Status)
        {
            // создаем один объект Client
            Client client1 = new Client { 
                Id = _Id, 
                FullName = _FullName, 
                PhoneNumber = _PhoneNumber, 
                Email = _Email, 
                Status = _Status 
            };
            // добавляем их в бд
            Clients.Add(client1);
            SaveChanges();
        }

        public void AddEmployee(int _Id, string _FullName, string _PhoneNumber, int _PositionEmployeeId, PositionEmployee _positionEmployee)
        {
            // создаем один объект Client
            Employee employee = new Employee { 
                Id = _Id, 
                FullName = _FullName, 
                PhoneNumber = _PhoneNumber, 
                PositionEmployeeId = _PositionEmployeeId, 
                PositionEmployee = _positionEmployee 
            };
            // добавляем их в бд
            Employees.Add(employee);
            SaveChanges();
        }

        public void AddMovie(int _Id, string _Name, int _GenreId, Genre _Genre, int _Year, Country _Country, string _AgeLimit, float _Rating)
        {
            Movie movie = new Movie { 
                Id = _Id, 
                Name = _Name, 
                GenreId = _GenreId, 
                Genre = _Genre, 
                Year = _Year, 
                Country = _Country, 
                AgeLimit = _AgeLimit, 
                Rating = _Rating 
            };
            // добавляем их в бд
            Movies.Add(movie);
            SaveChanges();
        }
        public void AddDisk(int _Id, DiskStatus _Status, List<Movie> _Movies)
        {
            Disk disk = new Disk { 
                Id = _Id, 
                Status = _Status, 
                Movies = _Movies 
            };
            SaveChanges();
        }
        public void AddOrder(int _Ordernumber, float _Cost, DateTime _Date, DateTime _ReturnDate, string _Pledgetype, OrderStatus _Status, List<Disk> _Disks)
        {
            Order order = new Order { 
                Ordernumber = _Ordernumber, 
                Cost = _Cost, 
                Date = _Date, 
                ReturnDate = _ReturnDate, 
                Pledgetype = _Pledgetype, 
                Status = _Status, 
                Disks = _Disks 
            };
            SaveChanges();
        }
        public void DeleteClient(int _id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Client client = new Client();
                client = db.Clients.Find(_id);
                System.Console.WriteLine(client.Email + " Client");
                db.Clients.Remove(client);
                SaveChanges();
            }
        }
    }
}
